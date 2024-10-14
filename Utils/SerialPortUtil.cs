using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ModbusFirstTry.Utils
{
    internal static class SerialPortUtil
    {
        public static int[] BaudRate = new int[] { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600 };


        public static int[] DataBits = new int[] { 5, 6, 7, 8 };


        public enum SerialPortWriteTimeout
        {
            Infinite = -1,
            NoTimeout = 0
        }

        /// <summary>
        /// 获取所有 COM 端口的名称
        /// </summary>
        /// <returns></returns>
        public static string[] GetDeviceNames()
        {
            // 使用 WMI 查询带 COM 端口的设备信息（SerialPort得到的name过于简陋）
            ManagementObjectSearcher pnpSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'");
            //得到所有的name，返回数组
            return pnpSearcher.Get().Cast<ManagementObject>().Select(p => p["Name"].ToString()).ToArray();
        }

        /// <summary>
        /// 将设备名转换为端口名
        /// </summary>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        public static string ConvertToPortName(string deviceName)
        {
            string pattern = @"\(COM\d+\)";
            Match match = Regex.Match(deviceName, pattern);
            if (match.Success)
            {
                // 提取匹配的串口名称，并去掉括号
               return match.Value.Trim('(', ')');
            }
            return string.Empty;
        }

    }
}

