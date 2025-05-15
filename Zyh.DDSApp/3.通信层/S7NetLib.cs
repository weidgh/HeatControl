using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyh.DDSApp
{   
    internal class S7NetLib
    {
        /// <summary>
        /// 私有字段：西门子S7协议的PLC通信类对象
        /// </summary>
        private Plc s7NetPlc = null;

        /// <summary>
        /// 公有属性 PLC的CPU型号
        /// </summary>
        public CpuType CPUType { get; set; }

        /// <summary>
        /// 公有属性 PLC的IP地址
        /// </summary>
        public string IPAddess { get; set; }

        /// <summary>
        /// 公有属性 PLC的CPU机架号
        /// </summary>
        public short Rack { get; set; }

        /// <summary>
        /// 公有属性 PLC的插槽号
        /// </summary>
        public short Slot { get; set; }
        /// <summary>
        /// 构造函数，用于创建一个 S7.Net 的实例
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ip"></param>
        /// <param name="rack"></param>
        /// <param name="slot"></param>
        public S7NetLib(CpuType type,  string ip, short rack, short slot)
        {
           CPUType = type;
            IPAddess = ip;
            Rack = rack;
            Slot = slot;
        }

        /// <summary>
        /// 打开PLC连接
        /// </summary>
        public void OpenPLC() 
        {
             //判断通信对象是否为null
            if (s7NetPlc == null) 
            {
               s7NetPlc = new Plc(CPUType, IPAddess, Rack, Slot);
            }
            //判断连接是否打开
            if (!s7NetPlc.IsConnected) 
            {
                s7NetPlc.ReadTimeout = 100;
                s7NetPlc.WriteTimeout = 100;
                s7NetPlc.Open();
            }

        }

        /// <summary>
        /// 关闭PLC连接
        /// /// </summary>
        public void ClosePLC() 
        {
            if (s7NetPlc != null && s7NetPlc.IsConnected)
            {
             s7NetPlc.Close();
            }
        }

        /// <summary>
        /// 公共方法，向PLC变量单个写入
        /// </summary>
        /// <param name="varAddress"></param>
        /// <param name="varValue"></param>
        public void WriteDataToPLC(string varAddress, object varValue) 
        {
          OpenPLC();
            lock (this)//规定枷锁，防止并发
            {
                this.s7NetPlc.Write(varAddress, varValue);
            }
        }

        /// <summary>
        /// 从PLC批量读取
        /// </summary>
        /// <param name="dataType">存储区类型</param>
        /// <param name="db">DB号</param>
        /// <param name="startByteAdr">开始的字节地址</param>
        /// <param name="count">读取的字节数量</param>
        /// <returns></returns>
        public byte[] ReadDataFromPLC(DataType dataType,int db, int startByteAdr, int count) 
        {
            OpenPLC();
            lock (this) 
            {
                byte[] result = this.s7NetPlc.ReadBytes(dataType, db, startByteAdr, count);
                return result;
            }
        }
    }
}
