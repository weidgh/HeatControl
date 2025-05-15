using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.HeatingControlProject;

namespace Zyh.DDSApp
{
    public class PlclnfoService
    {
        /// <summary>
        /// 读取配置文件返回对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Plclnfo GetPlcInfoByPath(string path) 
        {
            //创建PLC对象
          Plclnfo info = new Plclnfo();

            //读取数据给属性赋值
            info.IPAddress = IniConfigHelper.ReadIniData("PLC信息", "IP地址.", "192.168.1.0", path);
            info.CpuType = (CpuType)Enum.Parse(typeof(CpuType), IniConfigHelper.ReadIniData
                ("PLC信息","CPU型号","S7200Smart",path),true);
            info.Rack = Convert.ToInt16(IniConfigHelper.ReadIniData("PLC信息", "机架号", "0", path));
            info.Slot = Convert.ToInt16(IniConfigHelper.ReadIniData("PLC信息", "插槽号", "0", path));

            //返回对象
            return info ;
        }


        /// <summary>
        /// 保存对象到指定文件
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool SePlcInfoToPath(Plclnfo info, string path) 
        {
           bool result  = true;

            result &= IniConfigHelper.WriteIniData("PLC信息", "lP地址", info.IPAddress, path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "CPU地址", info.CpuType.ToString(), path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "机架号", info.Rack.ToString(), path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "插槽号", info.Slot.ToString(), path);

            return result ;
        }

    }
}
