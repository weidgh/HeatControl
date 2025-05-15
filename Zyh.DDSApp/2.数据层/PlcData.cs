using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyh.DDSApp
{
    /// <summary>
    /// PLC状态实体类
    /// </summary>
    public class PlcData
    {
        /// <summary>
        /// 进水泵状态
        /// </summary>
        public bool FeedPumpState { get; set; }
        /// <summary>
        /// 加水泵状态
        /// </summary>
        public bool AddPumpState { get; set; }
        /// <summary>
        /// 燃气泵状态
        /// </summary>
        public bool AirPumpState { get; set; }
        /// <summary>
        /// 循环泵状态
        /// </summary>
        public bool CirclePumpState { get; set; }
        /// <summary>
        /// 出水阀状态
        /// </summary>
        public bool OutValveState { get; set; }
        /// <summary>
        /// 系统状态
        /// </summary>
        public bool SystemState { get; set; }
        /// <summary>
        /// 进水压力
        /// </summary>
        public float PressureIn { get; set; }
        /// <summary>
        /// 出水压力
        /// </summary>
        public float PressureOut { get; set; }
        /// <summary>
        /// 进水温度
        /// </summary>
        public float TempIn { get; set; }
        /// <summary>
        /// 出水温度
        /// </summary>
        public float TempOut { get; set; }
        /// <summary>
        /// 锅炉压力
        /// </summary>
        public float PressureBoiler { get; set; }
        /// <summary>
        /// 锅炉液位
        /// </summary>
        public float LevelBoiler { get; set; }
        /// <summary>
        /// 锅炉温度
        /// </summary>
        public float TempBoiler { get; set; }
        /// <summary>
        /// 储水罐液位
        /// </summary>
        public float LevelTank { get; set; }
        /// <summary>
        /// 管道流动压力
        /// </summary>
        public float Ldyl { get; set; }
        /// <summary>
        /// 测试使用的整数，课程没有讲解
        /// </summary>
        public int TTCsIn { get; set;}
        /// <summary>
        /// 自定义
        /// </summary>
        public bool SsJkState { get; set; }

    }
}
