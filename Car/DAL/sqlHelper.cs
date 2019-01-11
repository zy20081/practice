using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Car.Model;
namespace Car.DAL
{
    class sqlHelper
    {
        private static string constr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //封装方法的原则：把不变大的放到方法里，把变化的放参数中到
        private static SqlConnection conn; //连接

        public static SqlConnection Conn
        {
            get
            {
                if (conn == null || conn.State == ConnectionState.Broken)
                {
                    conn = new SqlConnection(constr);
                }
                return conn;
            }

        }
        /// <summary>
        /// 析构函数，自动消除，防止没有删除完，程序自动调用
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        ~sqlHelper()
        {
            Dispose();
        }
        public void Dispose() //写个方法可以调用回收
        {
            if (conn != null)
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                conn.Dispose();
            }
        }

        public static int ExecuteNonQuery(string sql)//参数执行的语句 执行增删改
        {
                using (SqlCommand cmd = Conn.CreateCommand())
                {
                    Conn.Open();
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }   
        }
 	    public static int ExecuteNonQuery(string sqlstr, params SqlParameter[] paras)
        {  using(SqlConnection conn=new SqlConnection(constr)){
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
                if (paras != null && paras.Length > 0)
                {
                    cmd.Parameters.AddRange(paras);
                }

                conn.Open();
                int res = 0;
                res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
        }

        }
        public static object ExecuteScalar(string sql) //查询单个值
        {
                using (SqlCommand cmd = Conn.CreateCommand())
                {
                    Conn.Open();
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
        }
        public static object ExecuteScalar(string sql,params SqlParameter[] paras) //查询单个值
        {
                using (SqlCommand cmd = Conn.CreateCommand())
                {
                    Conn.Open();
                    cmd.Parameters.AddRange(paras);
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
        }
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] paras) //查询结果集比较少的sql
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            if (paras != null && paras.Length > 0)
            {
                cmd.Parameters.AddRange(paras);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                adapter.Dispose();
            }
            return dt;
        }
    }
}
