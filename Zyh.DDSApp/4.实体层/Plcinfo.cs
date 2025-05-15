using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyh.DDSApp
{
   
    /// <summary>
    /// PLC信息类
    /// </summary>
     public class Plclnfo 
     {
        /// <summary>
        /// IP地址
        /// </summary>
        public string IPAddress { get; set; }
         
        /// <summary>
        /// CPU类型
        /// </summary>
        public CpuType CpuType { get; set; }
        
        /// <summary>
        /// 机架号
        /// </summary>
        public short Rack {  get; set; }

        /// <summary>
        /// 插槽号
        /// </summary>
        public short Slot { get; set; }
             
      }
}