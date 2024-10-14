namespace ModbusFirstTry
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.panelTop = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.lblTipMsg = new Sunny.UI.UIMarkLabel();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.uiAvatar2 = new Sunny.UI.UIAvatar();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnConnect = new Sunny.UI.UIButton();
            this.cboStopBits = new Sunny.UI.UIComboBox();
            this.cboDataBits = new Sunny.UI.UIComboBox();
            this.cboParitys = new Sunny.UI.UIComboBox();
            this.cboBaudRates = new Sunny.UI.UIComboBox();
            this.btnRefresh = new Sunny.UI.UISymbolButton();
            this.cboPorts = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.btnSend = new Sunny.UI.UIButton();
            this.txtSendMsg = new Sunny.UI.UITextBox();
            this.uiLabel24 = new Sunny.UI.UILabel();
            this.lblShowMsg = new Sunny.UI.UILabel();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.chkStart_B = new Sunny.UI.UICheckBox();
            this.lblBrightness_L = new Sunny.UI.UILabel();
            this.uiLabel23 = new Sunny.UI.UILabel();
            this.uiLabel22 = new Sunny.UI.UILabel();
            this.lblBrightness_H = new Sunny.UI.UILabel();
            this.uiLabel20 = new Sunny.UI.UILabel();
            this.uiLabel18 = new Sunny.UI.UILabel();
            this.uiLabel19 = new Sunny.UI.UILabel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.chkStart_H = new Sunny.UI.UICheckBox();
            this.lblHumidity_L = new Sunny.UI.UILabel();
            this.uiLabel21 = new Sunny.UI.UILabel();
            this.lblHumidity_H = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.chkStart_T = new Sunny.UI.UICheckBox();
            this.lblTemperature_L = new Sunny.UI.UILabel();
            this.lblTemperature_H = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.umBrightness = new Zhaoxi.CustControls.UMeter();
            this.umHumidity = new Zhaoxi.CustControls.UMeter();
            this.umTemperature = new Zhaoxi.CustControls.UMeter();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel25 = new Sunny.UI.UILabel();
            this.uiLabel26 = new Sunny.UI.UILabel();
            this.chkTemperature = new Sunny.UI.UICheckBox();
            this.chkHumidity = new Sunny.UI.UICheckBox();
            this.chkBrightness = new Sunny.UI.UICheckBox();
            this.pvTrends = new OxyPlot.WindowsForms.PlotView();
            this.chkState_01 = new Sunny.UI.UICheckBox();
            this.chkState_02 = new Sunny.UI.UICheckBox();
            this.chkState_03 = new Sunny.UI.UICheckBox();
            this.chkState_all = new Sunny.UI.UICheckBox();
            this.chkState_05 = new Sunny.UI.UICheckBox();
            this.chkState_04 = new Sunny.UI.UICheckBox();
            this.panelTop.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiTitlePanel1.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.DPIScale = true;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblTipMsg);
            this.panelTop.Controls.Add(this.uiSmoothLabel1);
            this.panelTop.Controls.Add(this.uiAvatar2);
            this.panelTop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelTop.Location = new System.Drawing.Point(1, 1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.panelTop.Size = new System.Drawing.Size(1038, 70);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(929, 21);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 32);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.Symbol = 361453;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTipMsg
            // 
            this.lblTipMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTipMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTipMsg.Location = new System.Drawing.Point(522, 31);
            this.lblTipMsg.MarkPos = Sunny.UI.UIMarkLabel.UIMarkPos.Right;
            this.lblTipMsg.Name = "lblTipMsg";
            this.lblTipMsg.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblTipMsg.Size = new System.Drawing.Size(387, 20);
            this.lblTipMsg.TabIndex = 3;
            this.lblTipMsg.Text = "等待学习卡连接";
            this.lblTipMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipMsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.lblTipMsg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.lblTipMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(89, 19);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectSize = 3;
            this.uiSmoothLabel1.Size = new System.Drawing.Size(290, 34);
            this.uiSmoothLabel1.TabIndex = 2;
            this.uiSmoothLabel1.Text = "初探Modbus上位机协议";
            this.uiSmoothLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.uiSmoothLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.uiSmoothLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // uiAvatar2
            // 
            this.uiAvatar2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar2.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar2.Image = global::ModbusFirstTry.Properties.Resources.logo;
            this.uiAvatar2.Location = new System.Drawing.Point(11, 3);
            this.uiAvatar2.Margin = new System.Windows.Forms.Padding(0);
            this.uiAvatar2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar2.Name = "uiAvatar2";
            this.uiAvatar2.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar2.TabIndex = 1;
            this.uiAvatar2.Text = "uiAvatar2";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiPanel1.Controls.Add(this.btnConnect);
            this.uiPanel1.Controls.Add(this.cboStopBits);
            this.uiPanel1.Controls.Add(this.cboDataBits);
            this.uiPanel1.Controls.Add(this.cboParitys);
            this.uiPanel1.Controls.Add(this.cboBaudRates);
            this.uiPanel1.Controls.Add(this.btnRefresh);
            this.uiPanel1.Controls.Add(this.cboPorts);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(26, 76);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(984, 45);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(887, 4);
            this.btnConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 35);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "连接设备";
            this.btnConnect.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cboStopBits
            // 
            this.cboStopBits.DataSource = null;
            this.cboStopBits.FillColor = System.Drawing.Color.White;
            this.cboStopBits.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStopBits.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboStopBits.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboStopBits.Location = new System.Drawing.Point(806, 6);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStopBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboStopBits.Size = new System.Drawing.Size(74, 32);
            this.cboStopBits.SymbolSize = 24;
            this.cboStopBits.TabIndex = 9;
            this.cboStopBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboStopBits.Watermark = "";
            // 
            // cboDataBits
            // 
            this.cboDataBits.DataSource = null;
            this.cboDataBits.FillColor = System.Drawing.Color.White;
            this.cboDataBits.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDataBits.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboDataBits.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboDataBits.Location = new System.Drawing.Point(673, 5);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDataBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboDataBits.Size = new System.Drawing.Size(63, 32);
            this.cboDataBits.SymbolSize = 24;
            this.cboDataBits.TabIndex = 8;
            this.cboDataBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboDataBits.Watermark = "";
            // 
            // cboParitys
            // 
            this.cboParitys.DataSource = null;
            this.cboParitys.FillColor = System.Drawing.Color.White;
            this.cboParitys.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboParitys.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboParitys.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboParitys.Location = new System.Drawing.Point(528, 5);
            this.cboParitys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboParitys.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboParitys.Name = "cboParitys";
            this.cboParitys.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboParitys.Size = new System.Drawing.Size(75, 32);
            this.cboParitys.SymbolSize = 24;
            this.cboParitys.TabIndex = 7;
            this.cboParitys.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboParitys.Watermark = "";
            // 
            // cboBaudRates
            // 
            this.cboBaudRates.DataSource = null;
            this.cboBaudRates.FillColor = System.Drawing.Color.White;
            this.cboBaudRates.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBaudRates.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboBaudRates.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboBaudRates.Location = new System.Drawing.Point(384, 5);
            this.cboBaudRates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBaudRates.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboBaudRates.Name = "cboBaudRates";
            this.cboBaudRates.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboBaudRates.Size = new System.Drawing.Size(74, 32);
            this.cboBaudRates.SymbolSize = 24;
            this.cboBaudRates.TabIndex = 6;
            this.cboBaudRates.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboBaudRates.Watermark = "";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.IsCircle = true;
            this.btnRefresh.Location = new System.Drawing.Point(276, 6);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 35);
            this.btnRefresh.Symbol = 61473;
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.DataSource = null;
            this.cboPorts.FillColor = System.Drawing.Color.White;
            this.cboPorts.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPorts.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboPorts.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboPorts.Location = new System.Drawing.Point(53, 8);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPorts.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboPorts.Size = new System.Drawing.Size(216, 29);
            this.cboPorts.SymbolSize = 24;
            this.cboPorts.TabIndex = 5;
            this.cboPorts.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboPorts.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(743, 12);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(56, 20);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "停止位";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(610, 12);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(56, 20);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "数据位";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(465, 12);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(56, 20);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "检验位";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(321, 12);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(56, 20);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "波特率";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 12);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(43, 20);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "串口";
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.White;
            this.uiPanel2.Controls.Add(this.uiTitlePanel1);
            this.uiPanel2.Controls.Add(this.uiPanel5);
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Controls.Add(this.umBrightness);
            this.uiPanel2.Controls.Add(this.umHumidity);
            this.uiPanel2.Controls.Add(this.umTemperature);
            this.uiPanel2.Controls.Add(this.uiLabel8);
            this.uiPanel2.Controls.Add(this.uiLabel7);
            this.uiPanel2.Controls.Add(this.uiLabel6);
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.FillColor2 = System.Drawing.Color.White;
            this.uiPanel2.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.ForeColor = System.Drawing.Color.White;
            this.uiPanel2.ForeDisableColor = System.Drawing.Color.White;
            this.uiPanel2.Location = new System.Drawing.Point(26, 129);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(984, 327);
            this.uiPanel2.TabIndex = 3;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.btnSend);
            this.uiTitlePanel1.Controls.Add(this.txtSendMsg);
            this.uiTitlePanel1.Controls.Add(this.uiLabel24);
            this.uiTitlePanel1.Controls.Add(this.lblShowMsg);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(710, 5);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(270, 317);
            this.uiTitlePanel1.TabIndex = 8;
            this.uiTitlePanel1.Text = "OLED显示屏";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Location = new System.Drawing.Point(3, 275);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(263, 35);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "发送文本";
            this.btnSend.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSendMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSendMsg.Location = new System.Drawing.Point(3, 173);
            this.txtSendMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSendMsg.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSendMsg.Multiline = true;
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Padding = new System.Windows.Forms.Padding(5);
            this.txtSendMsg.ShowText = false;
            this.txtSendMsg.Size = new System.Drawing.Size(263, 95);
            this.txtSendMsg.TabIndex = 2;
            this.txtSendMsg.Text = "hello world";
            this.txtSendMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSendMsg.Watermark = "";
            // 
            // uiLabel24
            // 
            this.uiLabel24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel24.Location = new System.Drawing.Point(6, 146);
            this.uiLabel24.Name = "uiLabel24";
            this.uiLabel24.Size = new System.Drawing.Size(260, 23);
            this.uiLabel24.TabIndex = 1;
            this.uiLabel24.Text = "输入显示的字符串(英文-60)";
            // 
            // lblShowMsg
            // 
            this.lblShowMsg.BackColor = System.Drawing.Color.DimGray;
            this.lblShowMsg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowMsg.ForeColor = System.Drawing.Color.Cyan;
            this.lblShowMsg.Location = new System.Drawing.Point(3, 38);
            this.lblShowMsg.Name = "lblShowMsg";
            this.lblShowMsg.Size = new System.Drawing.Size(263, 104);
            this.lblShowMsg.TabIndex = 0;
            this.lblShowMsg.Text = "hello world";
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.chkStart_B);
            this.uiPanel5.Controls.Add(this.lblBrightness_L);
            this.uiPanel5.Controls.Add(this.uiLabel23);
            this.uiPanel5.Controls.Add(this.uiLabel22);
            this.uiPanel5.Controls.Add(this.lblBrightness_H);
            this.uiPanel5.Controls.Add(this.uiLabel20);
            this.uiPanel5.Controls.Add(this.uiLabel18);
            this.uiPanel5.Controls.Add(this.uiLabel19);
            this.uiPanel5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel5.Location = new System.Drawing.Point(429, 206);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Size = new System.Drawing.Size(196, 116);
            this.uiPanel5.TabIndex = 7;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkStart_B
            // 
            this.chkStart_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStart_B.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkStart_B.ForeColor = System.Drawing.Color.Orange;
            this.chkStart_B.Location = new System.Drawing.Point(150, 82);
            this.chkStart_B.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkStart_B.Name = "chkStart_B";
            this.chkStart_B.Size = new System.Drawing.Size(38, 21);
            this.chkStart_B.TabIndex = 17;
            // 
            // lblBrightness_L
            // 
            this.lblBrightness_L.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrightness_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblBrightness_L.Location = new System.Drawing.Point(76, 43);
            this.lblBrightness_L.Name = "lblBrightness_L";
            this.lblBrightness_L.Size = new System.Drawing.Size(66, 24);
            this.lblBrightness_L.TabIndex = 14;
            this.lblBrightness_L.Text = "0";
            this.lblBrightness_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel23
            // 
            this.uiLabel23.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel23.Location = new System.Drawing.Point(148, 50);
            this.uiLabel23.Name = "uiLabel23";
            this.uiLabel23.Size = new System.Drawing.Size(45, 17);
            this.uiLabel23.TabIndex = 15;
            this.uiLabel23.Text = "cd/m2";
            // 
            // uiLabel22
            // 
            this.uiLabel22.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel22.Location = new System.Drawing.Point(148, 14);
            this.uiLabel22.Name = "uiLabel22";
            this.uiLabel22.Size = new System.Drawing.Size(45, 17);
            this.uiLabel22.TabIndex = 14;
            this.uiLabel22.Text = "cd/m2";
            // 
            // lblBrightness_H
            // 
            this.lblBrightness_H.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrightness_H.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblBrightness_H.Location = new System.Drawing.Point(76, 8);
            this.lblBrightness_H.Name = "lblBrightness_H";
            this.lblBrightness_H.Size = new System.Drawing.Size(66, 24);
            this.lblBrightness_H.TabIndex = 13;
            this.lblBrightness_H.Text = "0";
            this.lblBrightness_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel20
            // 
            this.uiLabel20.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel20.Location = new System.Drawing.Point(3, 86);
            this.uiLabel20.Name = "uiLabel20";
            this.uiLabel20.Size = new System.Drawing.Size(67, 17);
            this.uiLabel20.TabIndex = 13;
            this.uiLabel20.Text = "[启用模拟]";
            // 
            // uiLabel18
            // 
            this.uiLabel18.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel18.Location = new System.Drawing.Point(3, 14);
            this.uiLabel18.Name = "uiLabel18";
            this.uiLabel18.Size = new System.Drawing.Size(67, 17);
            this.uiLabel18.TabIndex = 11;
            this.uiLabel18.Text = "[历史最高]";
            // 
            // uiLabel19
            // 
            this.uiLabel19.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel19.Location = new System.Drawing.Point(3, 50);
            this.uiLabel19.Name = "uiLabel19";
            this.uiLabel19.Size = new System.Drawing.Size(67, 17);
            this.uiLabel19.TabIndex = 12;
            this.uiLabel19.Text = "[历史最低]";
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.chkStart_H);
            this.uiPanel4.Controls.Add(this.lblHumidity_L);
            this.uiPanel4.Controls.Add(this.uiLabel21);
            this.uiPanel4.Controls.Add(this.lblHumidity_H);
            this.uiPanel4.Controls.Add(this.uiLabel14);
            this.uiPanel4.Controls.Add(this.uiLabel17);
            this.uiPanel4.Controls.Add(this.uiLabel15);
            this.uiPanel4.Controls.Add(this.uiLabel16);
            this.uiPanel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel4.Location = new System.Drawing.Point(225, 206);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Size = new System.Drawing.Size(196, 116);
            this.uiPanel4.TabIndex = 7;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkStart_H
            // 
            this.chkStart_H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStart_H.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkStart_H.ForeColor = System.Drawing.Color.Orange;
            this.chkStart_H.Location = new System.Drawing.Point(139, 82);
            this.chkStart_H.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkStart_H.Name = "chkStart_H";
            this.chkStart_H.Size = new System.Drawing.Size(38, 21);
            this.chkStart_H.TabIndex = 16;
            // 
            // lblHumidity_L
            // 
            this.lblHumidity_L.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHumidity_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblHumidity_L.Location = new System.Drawing.Point(76, 42);
            this.lblHumidity_L.Name = "lblHumidity_L";
            this.lblHumidity_L.Size = new System.Drawing.Size(66, 24);
            this.lblHumidity_L.TabIndex = 14;
            this.lblHumidity_L.Text = "0";
            this.lblHumidity_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel21
            // 
            this.uiLabel21.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel21.Location = new System.Drawing.Point(156, 50);
            this.uiLabel21.Name = "uiLabel21";
            this.uiLabel21.Size = new System.Drawing.Size(20, 17);
            this.uiLabel21.TabIndex = 14;
            this.uiLabel21.Text = "%";
            // 
            // lblHumidity_H
            // 
            this.lblHumidity_H.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHumidity_H.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblHumidity_H.Location = new System.Drawing.Point(76, 7);
            this.lblHumidity_H.Name = "lblHumidity_H";
            this.lblHumidity_H.Size = new System.Drawing.Size(66, 24);
            this.lblHumidity_H.TabIndex = 13;
            this.lblHumidity_H.Text = "0";
            this.lblHumidity_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel14.Location = new System.Drawing.Point(157, 14);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(20, 17);
            this.uiLabel14.TabIndex = 13;
            this.uiLabel14.Text = "%";
            // 
            // uiLabel17
            // 
            this.uiLabel17.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel17.Location = new System.Drawing.Point(3, 86);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(67, 17);
            this.uiLabel17.TabIndex = 13;
            this.uiLabel17.Text = "[启用模拟]";
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel15.Location = new System.Drawing.Point(3, 14);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(67, 17);
            this.uiLabel15.TabIndex = 11;
            this.uiLabel15.Text = "[历史最高]";
            // 
            // uiLabel16
            // 
            this.uiLabel16.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel16.Location = new System.Drawing.Point(3, 50);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(67, 17);
            this.uiLabel16.TabIndex = 12;
            this.uiLabel16.Text = "[历史最低]";
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.chkStart_T);
            this.uiPanel3.Controls.Add(this.lblTemperature_L);
            this.uiPanel3.Controls.Add(this.lblTemperature_H);
            this.uiPanel3.Controls.Add(this.uiLabel13);
            this.uiPanel3.Controls.Add(this.uiLabel12);
            this.uiPanel3.Controls.Add(this.uiLabel11);
            this.uiPanel3.Controls.Add(this.uiLabel10);
            this.uiPanel3.Controls.Add(this.uiLabel9);
            this.uiPanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(21, 206);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(196, 116);
            this.uiPanel3.TabIndex = 6;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkStart_T
            // 
            this.chkStart_T.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStart_T.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkStart_T.ForeColor = System.Drawing.Color.Orange;
            this.chkStart_T.Location = new System.Drawing.Point(155, 82);
            this.chkStart_T.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkStart_T.Name = "chkStart_T";
            this.chkStart_T.Size = new System.Drawing.Size(38, 21);
            this.chkStart_T.TabIndex = 15;
            // 
            // lblTemperature_L
            // 
            this.lblTemperature_L.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemperature_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTemperature_L.Location = new System.Drawing.Point(83, 43);
            this.lblTemperature_L.Name = "lblTemperature_L";
            this.lblTemperature_L.Size = new System.Drawing.Size(66, 24);
            this.lblTemperature_L.TabIndex = 14;
            this.lblTemperature_L.Text = "0";
            this.lblTemperature_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature_H
            // 
            this.lblTemperature_H.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemperature_H.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTemperature_H.Location = new System.Drawing.Point(83, 8);
            this.lblTemperature_H.Name = "lblTemperature_H";
            this.lblTemperature_H.Size = new System.Drawing.Size(66, 24);
            this.lblTemperature_H.TabIndex = 13;
            this.lblTemperature_H.Text = "55.0";
            this.lblTemperature_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel13.Location = new System.Drawing.Point(162, 50);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(20, 17);
            this.uiLabel13.TabIndex = 12;
            this.uiLabel13.Text = "℃";
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(162, 14);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(20, 17);
            this.uiLabel12.TabIndex = 11;
            this.uiLabel12.Text = "℃";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(3, 86);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(67, 17);
            this.uiLabel11.TabIndex = 10;
            this.uiLabel11.Text = "[启用模拟]";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(3, 50);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(67, 17);
            this.uiLabel10.TabIndex = 9;
            this.uiLabel10.Text = "[历史最低]";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(3, 14);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(67, 17);
            this.uiLabel9.TabIndex = 8;
            this.uiLabel9.Text = "[历史最高]";
            // 
            // umBrightness
            // 
            this.umBrightness.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umBrightness.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umBrightness.Header = "Brightness";
            this.umBrightness.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umBrightness.Location = new System.Drawing.Point(433, 39);
            this.umBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umBrightness.MaxValue = 100;
            this.umBrightness.MinValue = 0;
            this.umBrightness.Name = "umBrightness";
            this.umBrightness.PointColor = System.Drawing.Color.Red;
            this.umBrightness.ScaleLineColor = System.Drawing.Color.Gray;
            this.umBrightness.ScaleValueColor = System.Drawing.Color.Gray;
            this.umBrightness.Size = new System.Drawing.Size(160, 160);
            this.umBrightness.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umBrightness.TabIndex = 5;
            this.umBrightness.Unit = "℃";
            this.umBrightness.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umBrightness.Value = 0D;
            this.umBrightness.ValueColor = System.Drawing.Color.White;
            // 
            // umHumidity
            // 
            this.umHumidity.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umHumidity.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umHumidity.Header = "Humidity";
            this.umHumidity.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umHumidity.Location = new System.Drawing.Point(241, 43);
            this.umHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umHumidity.MaxValue = 100;
            this.umHumidity.MinValue = 0;
            this.umHumidity.Name = "umHumidity";
            this.umHumidity.PointColor = System.Drawing.Color.Red;
            this.umHumidity.ScaleLineColor = System.Drawing.Color.Gray;
            this.umHumidity.ScaleValueColor = System.Drawing.Color.Gray;
            this.umHumidity.Size = new System.Drawing.Size(160, 160);
            this.umHumidity.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umHumidity.TabIndex = 4;
            this.umHumidity.Unit = "℃";
            this.umHumidity.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umHumidity.Value = 0D;
            this.umHumidity.ValueColor = System.Drawing.Color.White;
            // 
            // umTemperature
            // 
            this.umTemperature.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
            this.umTemperature.CenterElipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(155)))), ((int)(((byte)(252)))));
            this.umTemperature.Header = "Temperature";
            this.umTemperature.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umTemperature.Location = new System.Drawing.Point(43, 43);
            this.umTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.umTemperature.MaxValue = 90;
            this.umTemperature.MinValue = -10;
            this.umTemperature.Name = "umTemperature";
            this.umTemperature.PointColor = System.Drawing.Color.Red;
            this.umTemperature.ScaleLineColor = System.Drawing.Color.Gray;
            this.umTemperature.ScaleValueColor = System.Drawing.Color.Gray;
            this.umTemperature.Size = new System.Drawing.Size(160, 160);
            this.umTemperature.SurroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))), ((int)(((byte)(216)))));
            this.umTemperature.TabIndex = 3;
            this.umTemperature.Unit = "℃";
            this.umTemperature.UnitColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(1)))), ((int)(((byte)(70)))), ((int)(((byte)(174)))));
            this.umTemperature.Value = 0D;
            this.umTemperature.ValueColor = System.Drawing.Color.White;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(497, 14);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(60, 23);
            this.uiLabel8.TabIndex = 2;
            this.uiLabel8.Text = "亮度";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(302, 18);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(65, 23);
            this.uiLabel7.TabIndex = 1;
            this.uiLabel7.Text = "湿度";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(105, 18);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(52, 23);
            this.uiLabel6.TabIndex = 0;
            this.uiLabel6.Text = "温度";
            // 
            // uiLabel25
            // 
            this.uiLabel25.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel25.Location = new System.Drawing.Point(23, 463);
            this.uiLabel25.Name = "uiLabel25";
            this.uiLabel25.Size = new System.Drawing.Size(87, 19);
            this.uiLabel25.TabIndex = 4;
            this.uiLabel25.Text = ">>实时曲线";
            // 
            // uiLabel26
            // 
            this.uiLabel26.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel26.Location = new System.Drawing.Point(733, 463);
            this.uiLabel26.Name = "uiLabel26";
            this.uiLabel26.Size = new System.Drawing.Size(87, 19);
            this.uiLabel26.TabIndex = 5;
            this.uiLabel26.Text = ">>状态监控";
            // 
            // chkTemperature
            // 
            this.chkTemperature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTemperature.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkTemperature.ForeColor = System.Drawing.Color.Orange;
            this.chkTemperature.Location = new System.Drawing.Point(486, 463);
            this.chkTemperature.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkTemperature.Name = "chkTemperature";
            this.chkTemperature.Size = new System.Drawing.Size(51, 21);
            this.chkTemperature.TabIndex = 6;
            this.chkTemperature.Tag = "0";
            this.chkTemperature.Text = "温度";
            this.chkTemperature.CheckedChanged += new System.EventHandler(this.chkTrend_CheckedChanged);
            // 
            // chkHumidity
            // 
            this.chkHumidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHumidity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkHumidity.ForeColor = System.Drawing.Color.Green;
            this.chkHumidity.Location = new System.Drawing.Point(543, 463);
            this.chkHumidity.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkHumidity.Name = "chkHumidity";
            this.chkHumidity.Size = new System.Drawing.Size(51, 21);
            this.chkHumidity.TabIndex = 7;
            this.chkHumidity.Tag = "1";
            this.chkHumidity.Text = "湿度";
            this.chkHumidity.CheckedChanged += new System.EventHandler(this.chkTrend_CheckedChanged);
            // 
            // chkBrightness
            // 
            this.chkBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBrightness.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBrightness.ForeColor = System.Drawing.Color.SpringGreen;
            this.chkBrightness.Location = new System.Drawing.Point(600, 463);
            this.chkBrightness.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkBrightness.Name = "chkBrightness";
            this.chkBrightness.Size = new System.Drawing.Size(51, 21);
            this.chkBrightness.TabIndex = 8;
            this.chkBrightness.Tag = "2";
            this.chkBrightness.Text = "亮度";
            this.chkBrightness.CheckedChanged += new System.EventHandler(this.chkTrend_CheckedChanged);
            // 
            // pvTrends
            // 
            this.pvTrends.Location = new System.Drawing.Point(26, 498);
            this.pvTrends.Name = "pvTrends";
            this.pvTrends.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvTrends.Size = new System.Drawing.Size(705, 163);
            this.pvTrends.TabIndex = 9;
            this.pvTrends.Text = "plotView1";
            this.pvTrends.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvTrends.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvTrends.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // chkState_01
            // 
            this.chkState_01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_01.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_01.Location = new System.Drawing.Point(731, 498);
            this.chkState_01.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_01.Name = "chkState_01";
            this.chkState_01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_01.Size = new System.Drawing.Size(95, 70);
            this.chkState_01.TabIndex = 10;
            this.chkState_01.Tag = "0";
            this.chkState_01.Text = "一号灯珠";
            this.chkState_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_01.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // chkState_02
            // 
            this.chkState_02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_02.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_02.Location = new System.Drawing.Point(832, 498);
            this.chkState_02.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_02.Name = "chkState_02";
            this.chkState_02.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_02.Size = new System.Drawing.Size(95, 70);
            this.chkState_02.TabIndex = 11;
            this.chkState_02.Tag = "1";
            this.chkState_02.Text = "二号灯珠";
            this.chkState_02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_02.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // chkState_03
            // 
            this.chkState_03.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_03.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_03.Location = new System.Drawing.Point(933, 498);
            this.chkState_03.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_03.Name = "chkState_03";
            this.chkState_03.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_03.Size = new System.Drawing.Size(95, 70);
            this.chkState_03.TabIndex = 12;
            this.chkState_03.Tag = "2";
            this.chkState_03.Text = "三号灯珠";
            this.chkState_03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_03.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // chkState_all
            // 
            this.chkState_all.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_all.Location = new System.Drawing.Point(933, 591);
            this.chkState_all.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_all.Name = "chkState_all";
            this.chkState_all.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_all.Size = new System.Drawing.Size(95, 70);
            this.chkState_all.TabIndex = 15;
            this.chkState_all.Tag = "all";
            this.chkState_all.Text = "总控开关";
            this.chkState_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_all.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // chkState_05
            // 
            this.chkState_05.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_05.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_05.Location = new System.Drawing.Point(832, 591);
            this.chkState_05.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_05.Name = "chkState_05";
            this.chkState_05.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_05.Size = new System.Drawing.Size(95, 70);
            this.chkState_05.TabIndex = 14;
            this.chkState_05.Tag = "4";
            this.chkState_05.Text = "五号灯珠";
            this.chkState_05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_05.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // chkState_04
            // 
            this.chkState_04.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkState_04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkState_04.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState_04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkState_04.Location = new System.Drawing.Point(731, 591);
            this.chkState_04.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkState_04.Name = "chkState_04";
            this.chkState_04.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkState_04.Size = new System.Drawing.Size(95, 70);
            this.chkState_04.TabIndex = 13;
            this.chkState_04.Tag = "3";
            this.chkState_04.Text = "四号灯珠";
            this.chkState_04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkState_04.Click += new System.EventHandler(this.ChkLight_Click);
            // 
            // FrmMain
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1040, 680);
            this.ControlBox = false;
            this.Controls.Add(this.chkState_all);
            this.Controls.Add(this.chkState_05);
            this.Controls.Add(this.chkState_04);
            this.Controls.Add(this.chkState_03);
            this.Controls.Add(this.chkState_02);
            this.Controls.Add(this.chkState_01);
            this.Controls.Add(this.pvTrends);
            this.Controls.Add(this.chkBrightness);
            this.Controls.Add(this.chkHumidity);
            this.Controls.Add(this.chkTemperature);
            this.Controls.Add(this.uiLabel26);
            this.Controls.Add(this.uiLabel25);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 680);
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIAvatar uiAvatar2;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UIMarkLabel lblTipMsg;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cboPorts;
        private Sunny.UI.UISymbolButton btnRefresh;
        private Sunny.UI.UIComboBox cboBaudRates;
        private Sunny.UI.UIComboBox cboParitys;
        private Sunny.UI.UIComboBox cboDataBits;
        private Sunny.UI.UIComboBox cboStopBits;
        private Sunny.UI.UIButton btnConnect;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Zhaoxi.CustControls.UMeter umTemperature;
        private Zhaoxi.CustControls.UMeter umBrightness;
        private Zhaoxi.CustControls.UMeter umHumidity;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel20;
        private Sunny.UI.UILabel uiLabel18;
        private Sunny.UI.UILabel uiLabel19;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel21;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel23;
        private Sunny.UI.UILabel uiLabel22;
        private Sunny.UI.UILabel lblTemperature_H;
        private Sunny.UI.UILabel lblTemperature_L;
        private Sunny.UI.UILabel lblBrightness_L;
        private Sunny.UI.UILabel lblBrightness_H;
        private Sunny.UI.UILabel lblHumidity_L;
        private Sunny.UI.UILabel lblHumidity_H;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UILabel lblShowMsg;
        private Sunny.UI.UILabel uiLabel24;
        private Sunny.UI.UITextBox txtSendMsg;
        private Sunny.UI.UIButton btnSend;
        private Sunny.UI.UILabel uiLabel25;
        private Sunny.UI.UILabel uiLabel26;
        private Sunny.UI.UICheckBox chkTemperature;
        private Sunny.UI.UICheckBox chkHumidity;
        private Sunny.UI.UICheckBox chkBrightness;
        private OxyPlot.WindowsForms.PlotView pvTrends;
        private Sunny.UI.UICheckBox chkState_01;
        private Sunny.UI.UICheckBox chkState_02;
        private Sunny.UI.UICheckBox chkState_03;
        private Sunny.UI.UICheckBox chkState_all;
        private Sunny.UI.UICheckBox chkState_05;
        private Sunny.UI.UICheckBox chkState_04;
        private Sunny.UI.UICheckBox chkStart_T;
        private Sunny.UI.UICheckBox chkStart_B;
        private Sunny.UI.UICheckBox chkStart_H;
    }
}

