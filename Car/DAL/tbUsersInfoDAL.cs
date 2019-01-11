using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Car.Model;
using System.Security.Cryptography;
namespace Car.DAL
{
    partial class TrDAL
    {///MD5����
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
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');//���ܺ���ַ���
            }
            return sTemp.ToLower();//���ػ�ȥ
        }
        //����û���������
        public void AddNew(Users model)
        {
            string sql = "insert into tbUsersInfo(UID,pwd,sex)  values(@UID,@pwd,@sex)";
            sqlHelper.ExecuteNonQuery(sql
             , new SqlParameter("UID", model.UID)
             , new SqlParameter("pwd", GetMD5(model.pwd + "zy"))//��һ���θ���ȫ
             , new SqlParameter("sex", model.sex)
             );
        }
        public bool Update(Users model)
        {
            string sql = "update tbUsersInfo set UID=@UID,pwd=@pwd,sex=@sex where UID=@UID";
            int rows = sqlHelper.ExecuteNonQuery(sql
            , new SqlParameter("UID", model.UID)
            , new SqlParameter("pwd", model.pwd)
            , new SqlParameter("sex", model.sex)
            );
            return rows > 0;
        }
        public bool Delete(Users model) //����ɾ��
        {
            int rows = sqlHelper.ExecuteNonQuery("update  tbUsersInfo set IsDeleted=1 where UID=@UID",
            new SqlParameter("UID", model.UID));
            return rows > 0;
        }
        private static Users ToModel(DataRow row)
        {
            Users model = new Users();
            model.UID = row.IsNull("UID") ? null : (System.String)row["UID"];
            model.pwd = row.IsNull("pwd") ? null : (System.String)row["pwd"];
            model.sex = row.IsNull("sex") ? null : (System.String)row["sex"];
            return model;
        }
        public Users Get(string userID)
        {
            DataTable dt = sqlHelper.ExecuteDataTable("select UID,pwd,sex from tbUsersInfo  where UID=@UID",
            new SqlParameter("UID", userID));
            if (dt.Rows.Count > 1)
            { throw new Exception("more than 1 row was found"); }
            if (dt.Rows.Count <= 0) { return null; }
            DataRow row = dt.Rows[0];
            Users model = ToModel(row);
            return model;
        }
        public IEnumerable<Users> ListAll()
        {
            List<Users> list = new List<Users>();
            DataTable dt = sqlHelper.ExecuteDataTable("select UID,pwd,sex from tbUsersInfo where IsDeleted=0");
            foreach (DataRow row in dt.Rows)
            {
                list.Add(ToModel(row));
            }
            return list;
        }
        //�ؼ��ֲ�ѯ
        public DataTable showkey(string strkey)
        {

            string str = "select UID,pwd,sex from tbUsersInfo";
            if (!string.IsNullOrEmpty(strkey))
            {
                str += string.Format(" where UID like '%{0}%'", strkey);
            }
            DataTable dt = sqlHelper.ExecuteDataTable(str);
            return dt;
        }
        //�ѽ�ֹ�����Ϊfalse�����Ե�
        public bool stoppedFalse(string userID)
        {
            string sql = "update tbUsersInfo set IsStopped=0 where UID=@UID";
            int rows = sqlHelper.ExecuteNonQuery(sql
            , new SqlParameter("UID", userID)
            );
            return rows > 0;
        }
        //�ѽ�ֹ�����Ϊtrue�������û���ֹ��
        public bool stoppedTrue(string userID)
        {
            string sql = "update tbUsersInfo set IsStopped=1 where UID=@UID";
            int rows = sqlHelper.ExecuteNonQuery(sql
            , new SqlParameter("UID", userID)
            );
            return rows > 0;
        }
        //��ѯֹͣ��ֵ
        public bool selectstopped(string userID)
        {
            DataTable dt = sqlHelper.ExecuteDataTable("select UID,pwd,sex from tbUsersInfo  where UID=@UID and IsStopped=1",
               new SqlParameter("UID", userID));
            if (dt.Rows.Count >= 1)
            { return true; }
            else { return false; }
        }
        //����������ʱ��
        public bool stopTime(string userID)
        {
            string sql = "update dbo.tbUsersInfo set stoptime=GETDATE() where UID=@UID";
            int rows = sqlHelper.ExecuteNonQuery(sql, new SqlParameter("UID", userID));
            return rows > 0;
        }
        //��ѯ�������ʱ��
        public object selectstoptime(string userID)
        {
            string sql = "select stoptime from dbo.tbUsersInfo where UID=@userID";
            object a = sqlHelper.ExecuteScalar(sql, new SqlParameter("@userID", userID));
            return a;
        }
    }
}
