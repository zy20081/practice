using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.DAL;
using Car.Model;
using System.Data;
using System.Security.Cryptography;
namespace Car.BLL
{
    partial class TrafficBLL
    { ///加密
        public static string GetMD5(string sDataIn)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');//加密后的字符串
            }
            return sTemp.ToLower();//返回回去
        }
        public bool AddNewTrafficToDbase(TrafficInfo tN, int Type) //添加数据
        {
            if (tN is Xcar)
            {
                return new TrDAL().AddNewTrafficToDbase(tN, 1);
            }
            else
            {
                return new TrDAL().AddNewTrafficToDbase(tN, 2);
            }
        }
        public void showTraffic(TrafficInfo tN, XRentManager m_RM)//查询数据
        {
            new TrDAL().showTraffic(tN, m_RM);
        }
        public void addRent(TrafficInfo tN)
        {
            new TrDAL().addRent(tN);
        }
        public void showRent(TrafficInfo tN, XRentManager m_RM)
        {
            new TrDAL().showRent(tN, m_RM);
        }
        public bool deleteTraffic(TrafficInfo tN)//删除选中数据
        {
            return new TrDAL().deleteTraffic(tN);
        }
        public void addlistHire(TrafficInfo tN) //点结算/还车时触发
        {
            new TrDAL().addlistHire(tN);
        }
        public DataTable showAccount() //显示经营结算
        {
            return new TrDAL().showAccount();
        }
        public DataTable showkey(string strkey, string month, string year)//模糊搜索
        {
            return new TrDAL().showkey(strkey, month, year);
        }
        public ccountModel result(string Sunmonth, string Sunyear, ccountModel CM)
        {
            if (string.IsNullOrEmpty(Sunmonth) || string.IsNullOrEmpty(Sunyear))
            {
                throw new Exception("请填写月份或年份");
            }
            return new TrDAL().result(Sunmonth, Sunyear, CM);
        }
        public bool username(string uid, string pwd)
        {
            return new TrDAL().username(uid, GetMD5(pwd + "zy"));//加盐技术
        }
        /// 查询用户名是否存在
        public Users Get(string userID)
        {
            return new TrDAL().Get(userID);
        }
        /// <summary>
        /// 把禁止登入改为false，可以登
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool stoppedFalse(string userID)
        {
            return new TrDAL().stoppedFalse(userID);
        }
        /// <summary>
        /// 把禁止登入改为true，锁定用户禁止登
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool stoppedTrue(string userID)
        {
            return new TrDAL().stoppedTrue(userID);
        }
        /// <summary>
        /// 设置锁定的时间
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool stopTime(string userID) { return new TrDAL().stopTime(userID); }
        /// <summary>
        /// 查询获得锁定时间
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public DateTime selectstoptime(string userID)
        {
             Users  users=new Users();
             users.SelectStopTime = Convert.ToDateTime(new TrDAL().selectstoptime(userID));
             return users.SelectStopTime;
        }
        //查询是否有停止的值
        public bool selectstopped(string userID) {
            return new TrDAL().selectstopped(userID);
        }
    }
}
