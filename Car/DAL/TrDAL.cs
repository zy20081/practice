using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Car.Model;
namespace Car.DAL
{
    [Serializable]
    partial class TrDAL
   {
       
        /// <summary>
        /// 添加一个新的汽车信息到数据库
        /// </summary>
        /// <param name="tN"></param>
        /// <returns></returns>
        public bool AddNewTrafficToDbase(TrafficInfo tN,int Type)
        {
            bool bRt = false;
            //构造查询语句
            string sqlstr = "insert into tbTraffics(Number,Type,Name,color,DailyRent,YearsOfservice,Load) values(@Number,@Type,@Name,@color,@DailRent,@YearOfservice,@Load)";
            //构造查询语句
            sqlHelper.ExecuteNonQuery(sqlstr, new SqlParameter("@Number", tN.Number),
                                                       new SqlParameter("@Type",Type),
                                                       new SqlParameter("@Name", tN.Name),
                                                       new SqlParameter("@color",tN.Color),
                                                       new SqlParameter("@DailRent", tN.Money),
                                                       new SqlParameter("@YearOfservice", tN.Time),
                                                       new SqlParameter("@Load", tN.Load)
                                      );                                   
            bRt = true;
            return bRt;
        }
        public bool  deleteTraffic(TrafficInfo tN)//删除选中数据
        {
            bool bRt=false;
            string sqlstr = "delete tbTraffics where Number=@Number";
           int res= sqlHelper.ExecuteNonQuery(sqlstr,new SqlParameter("@Number",tN.Number));
           if (res > 0)
           {
               return bRt = true;
           }
           else
           {
               return bRt;
           }
        }
       /// <summary>
        /// 从数据库显示数据
       /// </summary>
       /// <param name="tN"></param>
       /// <param name="m_RM"></param>
        public void showTraffic(TrafficInfo tN, XRentManager m_RM)
        {
            string sqlstr = "select Number,Name,color,YearsOfservice,DailyRent,Load from tbTraffics where IsRented='False'";
            DataTable dt = sqlHelper.ExecuteDataTable(sqlstr);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tN = new TrafficInfo();
                    tN.Number = dr["Number"].ToString();
                    tN.Name = dr["Name"].ToString();
                    tN.Color = dr["Color"].ToString();
                    tN.Time = Convert.ToInt32(dr["YearsOfservice"]);
                    tN.Money = Convert.ToInt32(dr["DailyRent"]);
                    tN.Load = dr["Load"].ToString();
                    m_RM.DicMyTraffics.Add(tN.Name, tN);//放入到集合，保存为了可以循环
                }
            }
        }
         public void addRent( TrafficInfo tN)//加到listback中，更新已出租为1（ture）
        {
            string sqlstr = "insert into tbRentLogs(Number,RentManID,RentDate,RentMoney,RentName)values(@Number,@RentManID,@RentDate,@Money,@RentName)";
            sqlHelper.ExecuteNonQuery(sqlstr, new SqlParameter("@Number",tN.RentNumber),
                                              new SqlParameter("@RentManID",tN.RentManID),
                                              new SqlParameter("@RentDate",tN.RentDate),
                                              new SqlParameter("@Money", tN.Money),
                                              new SqlParameter("@RentName", tN.RentName)
                                       );
            //更新第一个表
            string sqlupdate = "update tbTraffics set IsRented='true' where Number=@Number";
            sqlHelper.ExecuteNonQuery(sqlupdate, new SqlParameter("@Number", tN.RentNumber));        
        }
         public void addlistHire(TrafficInfo tN) //点结算/还车时触发
         {
            
             //更新第一个表
             string sqlstr = "update tbTraffics set IsRented=0 where Number=@Number";
             sqlHelper.ExecuteNonQuery(sqlstr,new SqlParameter("@Number",tN.RentNumber));
             //添加结算的数据到tbAccount
             string sqlInsert = "insert into tbAccount(Number,RentDays,RentMoney,RentName,ReturnDate)values(@Number,@RentDays,@RentMoney,@RentName,@ReturnDate)";
             sqlHelper.ExecuteNonQuery(sqlInsert, new SqlParameter("@Number", tN.RentNumber),
                                                  new SqlParameter("@RentDays", tN.RentDays),
                                                  new SqlParameter("@RentMoney", tN.RentMoney),
                                                  new SqlParameter("@RentName", tN.RentName),
                                                  new SqlParameter("@ReturnDate",tN.ReturnDate)
                                        );
             //最后从还车表中删除
             string sqlDelete = "update tbRentLogs set Isback=1 where Number=@Number";
             sqlHelper.ExecuteNonQuery(sqlDelete, new SqlParameter("@Number", tN.RentNumber));                                         
         }
       /// <summary>
       /// 刷新还车的列表
       /// </summary>
       /// <param name="tN"></param>
       /// <param name="m_RM"></param>
         public void showRent(TrafficInfo tN, XRentManager m_RM)
         {
             string sqlstr = "select R.Number,T.Name,T.color,T.YearsOfservice,T.DailyRent,T.Load,R.RentName,R.RentDate from tbRentLogs as R,tbTraffics as T where R.Number=T.Number and R.Isback='false'";
             DataTable dt = sqlHelper.ExecuteDataTable(sqlstr);
             if (dt != null)
             {
                 foreach (DataRow dr in dt.Rows)
                 {
                     tN = new TrafficInfo();
                     tN.Number = dr["Number"].ToString();
                     tN.Name = dr["Name"].ToString();
                     tN.Color = dr["color"].ToString();
                     tN.Time = Convert.ToInt32(dr["YearsOfservice"]);
                     tN.Money = Convert.ToInt32(dr["DailyRent"]);
                     tN.Load = dr["Load"].ToString();
                     tN.RentName = dr["RentName"].ToString();
                     tN.RentDate = Convert.ToDateTime(dr["RentDate"]);
                     m_RM.DicRenteds.Add(tN.Name, tN);//放入到集合，保存为了可以循环
                 }
             }
         }
         public DataTable showAccount() //显示经营结算
         {
             string sqlstr = "SELECT ROW_NUMBER() over(order by a.RID ) AS 序列号 , A.Number AS 车号, A.RentDays AS 租用天数,A.ReturnDate AS 还车日期, A.RentMoney AS 总计租金, A.RentName AS 租户 FROM tbAccount as A";
              DataTable dt= sqlHelper.ExecuteDataTable(sqlstr);
              return dt;
         }
        /// <summary>
         /// 关键字,模糊查询 
        /// </summary>
        /// <param name="strkey"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
         public DataTable showkey(string strkey,string month,string year)
         {
             string sqlstr = "SELECT ROW_NUMBER() over(order by a.RID ) AS 序列号 , A.Number AS 车号, A.RentDays AS 租用天数,A.ReturnDate AS 还车日期, A.RentMoney AS 总计租金, A.RentName AS 租户 FROM tbAccount as A";
             #region 3个关键字情况
             if (!string.IsNullOrEmpty(strkey) && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(year))
             {
                 sqlstr += string.Format(" where A.Number like '%{0}%'", strkey);
                 sqlstr += string.Format(" and Month(A.ReturnDate) like '{0}'", month);
                 sqlstr += string.Format(" and YEAR(A.ReturnDate) like '{0}'", year);
             }
             if (!string.IsNullOrEmpty(strkey) && string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
             {
                 sqlstr += string.Format(" where A.Number like '%{0}%'", strkey);
             }
             if (!string.IsNullOrEmpty(year) && string.IsNullOrEmpty(strkey) && string.IsNullOrEmpty(month))
             {
                 sqlstr += string.Format(" where YEAR(A.ReturnDate) like '{0}'", year);
             }
             if (!string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year) && string.IsNullOrEmpty(strkey))
             {
                 sqlstr += string.Format(" where Month(A.ReturnDate) like '{0}'", month);
             }
             if (!string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(year) && string.IsNullOrEmpty(strkey))
             {
                 sqlstr += string.Format(" where Month(A.ReturnDate) like '{0}'", month);
                 sqlstr += string.Format(" and YEAR(A.ReturnDate) like '{0}'", year);
             }
             if (!string.IsNullOrEmpty(strkey) && !string.IsNullOrEmpty(year) && string.IsNullOrEmpty(month))
             {
                 sqlstr += string.Format(" where A.Number like '%{0}%'", strkey);
                 sqlstr += string.Format(" and YEAR(A.ReturnDate) like '{0}'", year);
             }
             if (!string.IsNullOrEmpty(strkey) && !string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
             {
                 sqlstr += string.Format(" where A.Number like '%{0}%'", strkey);
                 sqlstr += string.Format(" and Month(A.ReturnDate) like '{0}'", month);
             } 
             #endregion
             DataTable dt =sqlHelper.ExecuteDataTable(sqlstr);
             return dt;
         }
       /// <summary>
       /// 利润按年/月结算
       /// </summary>
       /// <param name="Sunmonth"></param>
       /// <param name="Sunyear"></param>
       /// <param name="CM"></param>
       /// <returns></returns>
         public ccountModel result(string Sunmonth, string Sunyear, ccountModel CM) 
         {
             string sqlstr = "select SUM(RentMoney) from dbo.tbAccount";
             if (!string.IsNullOrEmpty(Sunmonth) && !string.IsNullOrEmpty(Sunyear))
             {
                 sqlstr += string.Format("  where  MONTH(ReturnDate) like '{0}'", Sunmonth);
                 sqlstr += string.Format("and  YEAR(ReturnDate) like '{0}'", Sunyear);
             }
             DataTable dt = sqlHelper.ExecuteDataTable(sqlstr);
             DataRow row = dt.Rows[0];
             CM.reslut = row[0].ToString();
             return CM;
         }
        /// <summary>
        /// 用户验证
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
         public bool username(string uid, string pwd) 
         {
             string sqlstr = "select UID,pwd from tbUsersInfo where UID=@UID and pwd=@pwd and IsDeleted=0 and IsStopped=0";
             DataTable dt =  sqlHelper.ExecuteDataTable(sqlstr,new SqlParameter("@UID",uid),
                                                new SqlParameter("@pwd",pwd));
             if (dt.Rows.Count <= 0) 
             {
                 return false;
             }
             else if (dt.Rows.Count == 1)
             {
                 return true;
             }
             else 
             {
                 throw new Exception("出现了重复数据");
             }
         }
        
    }
}
