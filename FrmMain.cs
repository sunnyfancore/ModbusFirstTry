using Modbus.Device;
using ModbusFirstTry.Utils;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModbusFirstTry
{
    public partial class FrmMain : Sunny.UI.UIForm
    {
        SerialPort serialPort;//串口对象
        IModbusMaster master;//主站对象

        //温度、湿度、亮度相关变量
        double temperatureValue = 0.0;
        double temperatureMin = 100;
        double temperatureMax = 0.0;
        double humidityValue = 0.0;
        double humidityMin = 100;
        double humidityMax = 0.0;
        double brightnessValue = 0.0;
        double brightnessMin = 100;
        double brightnessMax = 0.0;

        public FrmMain()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            //串口下拉框
            RefreshPortNames();
            //波特率
            InitBaudRates();
            //检验位
            InitParitys();
            //数据位
            InitDataBits();
            //停止位
            InitStopBits();
        }

        /// <summary>
        /// 初始化停止位下拉框
        /// </summary>
        private void InitStopBits()
        {
            cboStopBits.DataSource = Enum.GetNames(typeof(StopBits));
            cboStopBits.SelectedItem = "One";
        }

        /// <summary>
        /// 初始化数据位下拉框
        /// </summary>
        private void InitDataBits()
        {
            cboDataBits.DataSource = SerialPortUtil.DataBits;
            cboDataBits.SelectedItem = 8;
        }

        /// <summary>
        /// 初始化校验位下拉框
        /// </summary>
        private void InitParitys()
        {

            cboParitys.DataSource= Enum.GetNames(typeof(Parity));
            cboParitys.SelectedItem = "None";
        }

        /// <summary>
        /// 加载波特率下拉框
        /// </summary>
        private void InitBaudRates()
        {
            //SerialPortUtil.SerialPortBaudRate的枚举值绑定到cboBaudRates
            //cboBaudRates.DataSource = Enum.GetValues(typeof(SerialPortUtil.BaudRate));得到的并不是值，而是属性


            cboBaudRates.DataSource = SerialPortUtil.BaudRate;
            cboBaudRates.SelectedItem = 9600;
        }

        /// <summary>
        /// 获取系统可用的串口列表，并显示在对应的下拉框中
        /// </summary>
        private void RefreshPortNames()
        {
            cboPorts.DataSource = null;
            var deviceList = SerialPortUtil.GetDeviceNames();
            cboPorts.DataSource = deviceList;
            if (cboPorts.Items.Count > 0)
            {
                cboPorts.SelectedIndex = 0;//默认选择第一个端口
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //图表初始化
            InitPlots();
            //页面信息初始化
            InitFormInfo();
        }

        private void InitFormInfo()
        {
            //仪表值重置为0
            umTemperature.Value = 0;
            umHumidity.Value = 0;
            umBrightness.Value = 0;
            //历史值重置0、启动模拟状态为false
            lblTemperature_H.Text = "0.0";
            lblTemperature_L.Text = "0.0";
            chkStart_T.Checked = false;

            lblHumidity_H.Text = "0";
            lblHumidity_L.Text = "0";
            chkStart_H.Checked = false;

            lblBrightness_H.Text = "0";
            lblBrightness_L.Text = "0";
            chkStart_B.Checked = false;

            //曲线显示状态为true
            chkTemperature.Checked = true;
            chkHumidity.Checked = true;
            chkBrightness.Checked = true;

            //显示屏区初始化
            lblShowMsg.Text = "";
            txtSendMsg.Text = "";

            //状态显示区
            chkState_01.Checked = false;
            chkState_02.Checked = false;
            chkState_03.Checked = false;
            chkState_04.Checked = false;
            chkState_05.Checked = false;
            chkState_all.Checked = false;
        }

        PlotModel plotModel = null;
        DateTimeAxis dateTimeAxis;//x轴
        LinearAxis valueAxis;//y轴
        Random random = new Random();
        //图表初始化
        private void InitPlots()
        {
            plotModel = new PlotModel()
            {
                IsLegendVisible = false,
                PlotAreaBorderColor = OxyColors.LightGray,
                PlotAreaBackground = OxyColors.White
            };
            //x轴
            dateTimeAxis = new DateTimeAxis()
            {
                MajorGridlineStyle = LineStyle.Dash,
                MajorGridlineThickness = 0,
                IntervalLength = 5,
                IntervalType = DateTimeIntervalType.Seconds,
                FontSize = 10,
                TextColor = OxyColors.Gray,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                AxislineColor = OxyColors.LightGray,
                StringFormat = "MM:ss"
            };
            plotModel.Axes.Add(dateTimeAxis);
            //y轴
            valueAxis = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Dash,
                IntervalLength = 20,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 110,
                Minimum = -20,
                FontSize = 10,
                TextColor = OxyColors.Gray,
                AxislineColor = OxyColors.LightGray,
            };
            plotModel.Axes.Add(valueAxis);

            //添加三条曲线序列
            var series01 = new LineSeries()
            {
                Color = OxyColors.Orange,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = "温度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            var series02 = new LineSeries()
            {
                Color = OxyColors.Green,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = "湿度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            var series03 = new LineSeries()
            {
                Color = OxyColors.SpringGreen,
                StrokeThickness = 1,
                MarkerType = MarkerType.None,
                Title = " 亮度",
                InterpolationAlgorithm = InterpolationAlgorithms.CanonicalSpline
            };
            DateTime dt = DateTime.Now.AddSeconds(-20);
            plotModel.Axes[0].Minimum = DateTimeAxis.ToDouble(dt);
            for (int i = 0; i < 20; i++)
            {
                dt = dt.AddSeconds(1);
                series01.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), random.Next(0, 100)));
                series02.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), random.Next(0, 100)));
                series03.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), random.Next(0, 100)));
            }
            plotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(dt);
            plotModel.Series.Add(series01);
            plotModel.Series.Add(series02);
            plotModel.Series.Add(series03);
            pvTrends.Model = plotModel;
        }

        #region 窗口拖动
        Point mPoint = new Point();
        bool isMove = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = e.Location;//当前按下的点
            isMove = true;//启动拖动
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            System.Environment.Exit(0);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)//已连接
                {
                    //断开处理
                    serialPort.Close();
                    btnConnect.Text = "连接设备";
                    //更新相关控件的可用性
                    SetControlsEnabled(false);
                    lblTipMsg.Text = "已断开学习卡连接!";
                    lblTipMsg.ForeColor = Color.ForestGreen;
                }
                else  //未连接
                {
                    //连接处理
                    serialPort.PortName = SerialPortUtil.ConvertToPortName(cboPorts.Text);
                    serialPort.BaudRate = int.Parse(cboBaudRates.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParitys.Text);
                    serialPort.DataBits = int.Parse(cboDataBits.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                    serialPort.Open();//打开连接
                    btnConnect.Text = "断开连接";
                    //更新相关控件的可用性
                    SetControlsEnabled(true);
                    //创建主站对象
                    master = ModbusSerialMaster.CreateRtu(serialPort);

                    //开始监控学习卡数据
                    StartMonitor();
                    lblTipMsg.Text = "连接成功，正在监控学习卡数据信息！";
                    lblTipMsg.ForeColor = Color.ForestGreen;
                }
            }
            catch (Exception ex)
            {
                lblTipMsg.Text = $"[异常]{ex.Message}";
                lblTipMsg.ForeColor = Color.DarkRed;
            }
        }

        private void SetControlsEnabled(bool isConnected)
        {
            if (isConnected)
            {
                cboPorts.Enabled = false;
                cboBaudRates.Enabled = false;
                cboParitys.Enabled = false;
                cboDataBits.Enabled = false;
                cboStopBits.Enabled = false;

                chkState_01.Enabled = true;
                chkState_02.Enabled = true;
                chkState_03.Enabled = true;
                chkState_04.Enabled = true;
                chkState_05.Enabled = true;
                chkState_all.Enabled = true;

                btnSend.Enabled = true;
            }
            else
            {
                cboPorts.Enabled = true;
                cboBaudRates.Enabled = true;
                cboParitys.Enabled = true;
                cboDataBits.Enabled = true;
                cboStopBits.Enabled = true;

                chkState_01.Enabled = false;
                chkState_02.Enabled = false;
                chkState_03.Enabled = false;
                chkState_04.Enabled = false;
                chkState_05.Enabled = false;
                chkState_all.Enabled = false;

                btnSend.Enabled = false;
            }
        }

        int[] lastRandoms = new int[3];
        bool[] order = new bool[3] { true, true, true };
        bool isWriting = false;//是否写的状态
        /// <summary>
        /// 启动学习卡数据监听，包含实时数据和状态
        /// </summary>
        private void StartMonitor()
        {
            Task.Run(async () =>
            {
                while (serialPort.IsOpen)
                {
                    try
                    {
                        //读取温度、湿度、亮度
                        ushort[] datas = await master.ReadHoldingRegistersAsync(1, 0, 3);
                        if (datas.Length > 0)
                        {
                            //温度值处理
                            if (chkStart_T.Checked)
                            {
                                //生成模拟数据
                                GenarateRandom(ref lastRandoms[0], ref order[0], -10, 90);
                                temperatureValue = lastRandoms[0];
                            }
                            else
                            {
                                temperatureValue = datas[0] * 0.1f;
                            }
                            if (temperatureMin > temperatureValue)
                                temperatureMin = temperatureValue;
                            if (temperatureMax < temperatureValue)
                                temperatureMax = temperatureValue;

                            //湿度值处理
                            if (chkStart_H.Checked)
                            {
                                //生成模拟数据
                                GenarateRandom(ref lastRandoms[1], ref order[1], 0, 100);
                                humidityValue = lastRandoms[1];
                            }
                            else
                            {
                                humidityValue = datas[1];
                            }
                            if (humidityMin > humidityValue)
                                humidityMin = humidityValue;
                            if (humidityMax < humidityValue)
                                humidityMax = humidityValue;

                            //亮度值处理
                            if (chkStart_B.Checked)
                            {
                                //生成模拟数据
                                GenarateRandom(ref lastRandoms[2], ref order[2], 0, 100);
                                brightnessValue = lastRandoms[2];
                            }
                            else
                            {
                                brightnessValue = datas[2];
                            }
                            if (brightnessMin > brightnessValue)
                                brightnessMin = brightnessValue;
                            if (brightnessMax < brightnessValue)
                                brightnessMax = brightnessValue;

                        }
                        //灯珠状态
                        bool[] blStates = await master.ReadCoilsAsync(1, 0, 5);

                        this.Invoke(new Action(() =>
                        {
                            //呈现仪表值
                            umTemperature.Value = temperatureValue;
                            umHumidity.Value = humidityValue;
                            umBrightness.Value = brightnessValue;
                            //历史值的呈现
                            lblTemperature_H.Text = temperatureMax.ToString("##.#");
                            lblTemperature_L.Text = temperatureMin.ToString("##.#");
                            lblHumidity_H.Text = humidityMax.ToString("##.#");
                            lblHumidity_L.Text = humidityMin.ToString("##.#");
                            lblBrightness_H.Text = brightnessMax.ToString("##.#");
                            lblBrightness_L.Text = brightnessMin.ToString("##.#");
                            //更新灯珠的状态
                            if (!isWriting)
                            {
                                chkState_01.Checked = blStates[0];
                                chkState_02.Checked = blStates[1];
                                chkState_03.Checked = blStates[2];
                                chkState_04.Checked = blStates[3];
                                chkState_05.Checked = blStates[4];
                                chkState_all.Checked = !blStates.ToList().Exists(b => !b);
                            }

                            //图表刷新
                            DateTime dt = DateTime.Now;
                            pvTrends.Model.Axes[0].Minimum = DateTimeAxis.ToDouble(dt.AddSeconds(-20));
                            pvTrends.Model.Axes[0].Maximum = DateTimeAxis.ToDouble(dt);

                            var lineSeries = pvTrends.Model.Series[0] as LineSeries;
                            lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), temperatureValue));
                            if (lineSeries.Points.Count > 20)
                            {
                                lineSeries.Points.RemoveAt(0);
                            }

                            var lineSeries1 = pvTrends.Model.Series[1] as LineSeries;
                            lineSeries1.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), humidityValue));
                            if (lineSeries1.Points.Count > 20)
                            {
                                lineSeries1.Points.RemoveAt(0);
                            }

                            var lineSeries2 = pvTrends.Model.Series[2] as LineSeries;
                            lineSeries2.Points.Add(new DataPoint(DateTimeAxis.ToDouble(dt), brightnessValue));
                            if (lineSeries2.Points.Count > 20)
                            {
                                lineSeries2.Points.RemoveAt(0);
                            }
                            pvTrends.InvalidatePlot(false);
                        }));
                        await Task.Delay(1000);
                    }
                    catch (Exception ex)
                    {
                        lblTipMsg.Text = $"[异常]{ex.Message}";
                        lblTipMsg.ForeColor = Color.DarkRed;
                    }
                }
            });
        }

        /// <summary>
        /// 曲线图的显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTrend_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as UICheckBox;//当前操作的复选框
            int index = int.Parse(chk.Tag.ToString());//一定要设置CheckBox的Tag属性
            pvTrends.Model.Series[index].IsVisible = chk.Checked;//复选框勾选，则显示；否则隐藏
            pvTrends.Model.InvalidatePlot(false);
        }



        /// <summary>
        /// 随机生成数据方法
        /// </summary>
        /// <param name="randomValue">最终生成值</param>
        /// <param name="order">随机数据的创建方向，往大方向 还是往小方向 </param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        private void GenarateRandom(ref int randomValue, ref bool order, int min, int max)
        {
            if (randomValue == 0)
            {
                randomValue = random.Next(Math.Min(min, max), Math.Max(min, max));
            }
            else
            {
                int rv = randomValue;
                if (order)
                {
                    var _max = Math.Min(rv + 20, max);
                    randomValue = random.Next(rv - 5, _max - 1);
                    if (_max == max)
                        order = false;
                }
                else
                {
                    var _min = Math.Max(rv - 20, min);
                    randomValue = random.Next(_min + 1, rv + 5);
                    if (_min == min)
                        order = true;
                }
            }
        }


        /// <summary>
        /// 信息发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            try
            {
                string sendText = txtSendMsg.Text;//接收要发送的文本
                if (string.IsNullOrEmpty(sendText))
                    throw new Exception("请输入有效英文字符");
                if (sendText.Length > 60)
                    throw new Exception("输入的字符长度不能超过60");
                if (sendText.ToList().Exists(s => (int)s > 127))
                    throw new Exception("包含无效字符");

                ushort[] datas = GetUshortData(sendText);

                //写入设备
                await master.WriteMultipleRegistersAsync(1, 8, datas);
                Task.Delay(100).Wait();

                lblShowMsg.Text = sendText;
            }
            catch (Exception ex)
            {
                lblTipMsg.Text = $"[异常]{ex.Message}";
                lblTipMsg.ForeColor = Color.DarkRed;
            }

        }

        /// <summary>
        /// 将字符串转换成ushort数组
        /// </summary>
        /// <param name="sendText"></param>
        /// <returns></returns>
        private ushort[] GetUshortData(string sendText)
        {
            List<byte> byteList = new List<byte>();
            byte[] textBytes = Encoding.ASCII.GetBytes(sendText);//将文本转换为字节数组
            byteList.AddRange(textBytes);
            //ushort 1个ushort=2字节
            if (textBytes.Length % 2 == 1)
            {
                byteList.Add(0x00);
            }

            List<ushort> ushortList = new List<ushort>();
            for (int i = 0; i < byteList.Count; i += 2)
            {
                byte[] item = new byte[2];
                item[0] = byteList[i + 1];
                item[1] = byteList[i];
                ushortList.Add(BitConverter.ToUInt16(item, 0));
            }

            return ushortList.ToArray();
        }

        /// <summary>
        /// 灯珠状态控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ChkLight_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                return;
            try
            {
                isWriting = true;
                UICheckBox chk = sender as UICheckBox;
                if (chk.Tag == null)
                    return;
                string tag = chk.Tag.ToString();// 地址或all
                if (tag == "all")
                {
                    bool blState1 = chkState_01.Checked;
                    bool blState2 = chkState_02.Checked;
                    bool blState3 = chkState_03.Checked;
                    bool blState4 = chkState_04.Checked;
                    bool blState5 = chkState_05.Checked;
                    bool[] allStates = new bool[5] { blState1, blState2, blState3, blState4, blState5 };
                    //将所有灯的状态与统一控制的状态一致
                    for (int i = 0; i < allStates.Length; i++)
                    {
                        if (allStates[i] != chk.Checked)
                            allStates[i] = chk.Checked;
                    }
                    //写入
                    await master.WriteMultipleCoilsAsync(1, 0, allStates);
                    chkState_01.Checked = chk.Checked;
                    chkState_02.Checked = chk.Checked;
                    chkState_03.Checked = chk.Checked;
                    chkState_04.Checked = chk.Checked;
                    chkState_05.Checked = chk.Checked;
                }
                else
                {
                    //单一控制
                    ushort addr = ushort.Parse(tag);//状态地址
                    var setState = chk.Checked;//写入的状态
                    chkState_all.Checked = chkState_01.Checked && chkState_02.Checked && chkState_03.Checked && chkState_04.Checked && chkState_05.Checked;
                    await master.WriteSingleCoilAsync(1, addr, setState);
                }

                isWriting = false;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
