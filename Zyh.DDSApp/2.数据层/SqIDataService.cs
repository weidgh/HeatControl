using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.HeatingControlProject;

namespace Zyh.DDSApp
{
    public class SqIDataService
    {

        /// <summary>
        /// 定时器存储数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool AddPLCData(PlcData data) 
        {
          string sql ="Insert into ActualData(InsertTime,PressureIn,PressureOut,TempIn,TempOut,PressureBoiler,LevelBoiler,TempBoiler,LevelTank) values(@InsertTime,@PressureIn,@PressureOut,@TempIn,@TempOut,@PressureBoiler,@LevelBoiler,@TempBoiler,@LevelTank)";

            SqlParameter[] parameters = new SqlParameter[]
            {
               new SqlParameter("@InsertTime",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
               new SqlParameter("@PressureIn", data.PressureIn),
               new SqlParameter("@PressureOut",data.PressureOut),
               new SqlParameter("@TempIn",data.TempIn),
               new SqlParameter("@TempOut",data.TempOut),
               new SqlParameter("@PressureBoiler", data.PressureBoiler),
               new SqlParameter("@LevelBoiler",data.LevelBoiler),
               new SqlParameter("@TempBoiler",data.TempBoiler),
               new SqlParameter("@LevelTank",data.LevelTank)
            };

            return SqlHelper.ExecuteNonQuery(sql, parameters) == 1;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <returns>DataTable数据表格</returns>
        /// <exception cref="Exception"></exception>
        public DataTable GetActualDataByTime(DateTime start, DateTime end) 
        {
            string sql = "Select InsertTime,PressureIn,PressureOut,TempIn,TempOut,PressureBoiler,LevelBoiler,TempBoiler,LevelTank from ActualData where InsertTime between @Start and @End";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Start",start),
                new SqlParameter("@End",end),
            };
            try 
            {
                DataSet dataSet = SqlHelper.GetDataSet(sql, null, sqlParameters);
                if (dataSet.Tables.Count > 0)
                {
                    return dataSet.Tables[0];
                }
                else 
                {
                    throw new Exception("数据查询失败：没有数据表");
                }
            }

            catch (Exception ex) 
            {
                throw new Exception("数据查询失败：" + ex.Message);
            }
        }
    }
}
