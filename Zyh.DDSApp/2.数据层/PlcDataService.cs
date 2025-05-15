using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using thinger.DataConvertLib;
using static System.Windows.Forms.AxHost;

namespace Zyh.DDSApp
{
    /// <summary>
    /// PLC信息服务类
    /// </summary>
    public class PlcDataService
    {

        #region   创建对象 S7Netlib
        /// <summary>
        /// 创建一个S7Netlib对象
        /// </summary>
        private S7NetLib s7Net;

        /// <summary>
        /// 建立PLC连接
        /// </summary>
        /// <param name="info">PLC信息对象</param>
        /// <exception cref="Exception"></exception>
        public void Connnect(Plclnfo info)
        {
            try
            {
                s7Net = new S7NetLib(info.CpuType, info.IPAddress, info.Rack, info.Slot);
                s7Net.OpenPLC();
            }
            catch (Exception ex)
            {
                throw new Exception("PLC连接失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 断开PLC
        /// </summary>
        public void DisConnect()
        {
            if (s7Net != null)
            {
                s7Net.ClosePLC();
            }
        }
        #endregion

        #region  读取PLC数据
        /// <summary>
        /// 读取PLC数据
        /// </summary>
        /// <returns></returns>
        public PlcData GetPLCData()
        {
            try
            {
                int length = 100;

                byte[] result = s7Net.ReadDataFromPLC(S7.Net.DataType.DataBlock, 1, 0, length);

                if (result != null && result.Length == length)
                {
                    //数据解析  针对不同的数据类型进行解析  布尔  整数  浮点
                    PlcData plcData = new PlcData();

                    //解析布尔  0.0 第一个0表示一个字节的索引  第二个0表示八个位的索引。
                    plcData.FeedPumpState = BitLib.GetBitFromByteArray(result, 0, 0);
                    plcData.AddPumpState = BitLib.GetBitFromByteArray(result, 0, 1);
                    plcData.AirPumpState = BitLib.GetBitFromByteArray(result, 0, 2);
                    plcData.CirclePumpState = BitLib.GetBitFromByteArray(result, 0, 3);
                    plcData.OutValveState = BitLib.GetBitFromByteArray(result, 0, 4);
                    plcData.SsJkState = BitLib.GetBitFromByteArray(result, 0, 5);
                    plcData.SystemState = BitLib.GetBitFromByteArray(result, 2, 0);

                    //解析整数
                    //plcData.TTCsIn = IntLib.GetIntFromByteArray(result, 2);

                    //解析浮点数  4  我使用的是PLC1200
                    plcData.PressureIn = FloatLib.GetFloatFromByteArray(result, 4);
                    plcData.PressureOut = FloatLib.GetFloatFromByteArray(result, 8);
                    plcData.TempIn = FloatLib.GetFloatFromByteArray(result, 12);
                    plcData.TempOut = FloatLib.GetFloatFromByteArray(result, 16);
                    plcData.LevelTank = FloatLib.GetFloatFromByteArray(result, 20);
                    plcData.LevelBoiler = FloatLib.GetFloatFromByteArray(result, 24);
                    plcData.TempBoiler = FloatLib.GetFloatFromByteArray(result, 28);
                    plcData.PressureBoiler = FloatLib.GetFloatFromByteArray(result, 32);
                    plcData.Ldyl = FloatLib.GetFloatFromByteArray(result, 36);


                    return plcData;
                }

                else
                {
                    throw new Exception("PLC读取数据不正确");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("PLC读取数据失败：" + ex.Message);
            }
        }
        #endregion



        #region   泵读取控制
        /// <summary>
        /// 进水泵控制
        /// </summary>
        /// <param name="state"></param>
        public void FeedpumpControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX100.0" : "DB1.DBX100.1";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }

        }

        /// <summary>
        /// 加水泵控制
        /// </summary>
        /// <param name="state"></param>
        public void AddPumpControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX100.2" : "DB1.DBX100.3";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }
        }

        /// <summary>
        /// 燃气泵控制
        /// </summary>
        /// <param name="state"></param>
        public void AirpumpControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX100.4" : "DB1.DBX100.5";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }
        }

        /// <summary>
        /// 循环泵控制
        /// </summary>
        /// <param name="state"></param>
        public void CirclepumpControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX100.6" : "DB1.DBX100.7";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }
        }

        /// <summary>
        /// 出水阀控制
        /// </summary>
        /// <param name="state"></param>
        public void OutValveControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX101.0" : "DB1.DBX101.1";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }
        }

        /// <summary>
        /// 启动信号与停止信号
        /// </summary>
        /// <param name="state"></param>
        public void SsJkControl(bool state)
        {
            if (s7Net != null)
            {
                //获取启动地址，根据state值，获取地址，就是DB1.DBX100.0
                string address = state ? "DB1.DBX101.2" : "DB1.DBX101.3";
                s7Net.WriteDataToPLC(address, true);
                s7Net.WriteDataToPLC(address, false);
            }
            else
            {
                //异常捕获
                throw new Exception("PLC未连接");
            }
        }
        #endregion
    }
}
