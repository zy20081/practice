using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace 三层架构.DAL
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

        public static int ExecuteNonQuery(string sql)//参数执行的语句 执行增删改
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    	public static int ExecNonQuery(string sqlstr, params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand(sqlstr, Conn);
            if (paras != null && paras.Length > 0)
            {
                cmd.Parameters.AddRange(paras);
            }
            
            Conn.Open();
            int res = 0;
            res = cmd.ExecuteNonQuery();
            Conn.Close();
            return res;

        }
        public static object ExecuteScalar(string sql) //查询单个值
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }
        public static object ExecuteScalar(string sql,params SqlParameter[] paras) //查询单个值
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Parameters.AddRange(paras);
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
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
            return dt;

        }
       

    }
}
