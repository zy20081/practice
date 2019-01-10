using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace code
{
    class CreateDaL
    { ///增加 
        private  SqlConnection conn; //连接

        public  SqlConnection Conn
        {
            get
            {
                if (conn == null || conn.State == ConnectionState.Broken)
                {
                    conn = new SqlConnection(model.constr);
                }
                return conn;
            }

        }
       public  DataTable ExecuteDataTable(string sql, params SqlParameter[] paras) //查询结果集比较少的sql
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
            catch 
            { }
            return dt;
          }
       public static string toNetType(string dataType) //数据库类型和C#类型换下
       {
           switch (dataType)
           {
               case "int": return "int";
               case "nvarchar":
               case "varchar":
               case "nchar":
                   return "string";
               case "bit": return "bool";
               case "datetime": return "DateTime";
               default: return "object";
           }

       }
        /// <summary>
       /// 创建model
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
       public StringBuilder createModel(string tablename)
       {
           DataTable dtCols = ExecuteDataTable("SELECT * FROM  INFORMATION_SCHEMA.COlUMNS where Table_name=@table", new SqlParameter("@table", tablename));
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("using System;");
           sb.AppendLine("using System.Text;");
           sb.AppendLine("using System.Data;");
           sb.AppendLine("using System.Data.SqlClient;");
           sb.AppendLine("using System.Collections.Generic;");
           sb.AppendLine("");
           sb.AppendLine("namespace " + model.RootNamespace + ".Model");
           sb.AppendLine("{");
           sb.AppendLine("partial class" + "  " + tablename + "Model");
           sb.AppendLine("{");
           foreach (DataRow dr in dtCols.Rows)
           {
               string colname = dr["COLUMN_NAME"].ToString();
               string dateType = dr["DATA_TYPE"].ToString();
               string netType = toNetType(dateType);
               sb.AppendLine("public" + "  " + netType + "  " + colname + "  " + "{get;set;}");
           }
           sb.AppendLine("}");
           sb.AppendLine("}");
           return sb;

       }
       /// <summary>
       /// 创建model
       /// </summary>
       /// <param name="tablename"></param>
       /// <returns></returns>
       public StringBuilder creatDAL(string tablename )//创建DAL
       {
           {
               DataTable dtCols = ExecuteDataTable("SELECT * FROM  INFORMATION_SCHEMA.COlUMNS where Table_name=@table and  COLUMN_NAME<>'ID' ", new SqlParameter("@table", tablename));
               string[] colnames = new string[dtCols.Rows.Count];//定义列为数组下面好用jion逗号分开
               for (int i = 0; i < dtCols.Rows.Count; i++)
               {
                   DataRow row = dtCols.Rows[i];
                   string colname = (string)row["Column_Name"];
                   colnames[i] = colname;
               }
               string[] parameters = new string[dtCols.Rows.Count];//values后面的参数
               for (int i = 0; i < parameters.Length; i++)
               {
                   parameters[i] = "@" + colnames[i];
               }
            
               StringBuilder sb = new StringBuilder();
               sb.AppendLine("using System;");
               sb.AppendLine("using System.Text;");
               sb.AppendLine("using System.Data;");
               sb.AppendLine("using System.Data.SqlClient;");
               sb.AppendLine("using System.Collections.Generic;");
               sb.AppendLine("using " + model.RootNamespace + ".Model;");
               sb.AppendLine("");
               sb.AppendLine("namespace " + model.RootNamespace + ".DAL");
               sb.AppendLine("{");
               sb.AppendLine("partial class" + "  " + tablename + "DAL");
               sb.AppendLine("{");
               #region 字符串并接（增加） 
               sb.AppendLine("public int insert(" + tablename + "Model" + "  " +"model){");
               sb.AppendLine("object obj=sqlHelper.ExecuteNonQuery(");
               sb.AppendLine("\"insert into  " + tablename + "(" + string.Join(",", colnames) + ")values(" + string.Join(",", parameters) + ");select identity\"");
               foreach (string colname in colnames)
               {
                   sb.AppendLine(",new SqlParameter(\"" + colname + "\",model." + colname + ")");
               }
               sb.AppendLine(");");
               sb.AppendLine("return Convert.ToInt32(obj);");
               sb.AppendLine("}");
               #endregion
               #region 字符串并接（删）
               sb.AppendLine("public int Delete(int id){");
               sb.AppendLine("object obj=sqlHelper.ExecuteNonQuery(");
               sb.AppendLine("\"delete from  " + tablename + " where id=@id\",");
               sb.AppendLine("new SqlParameter(\"id\",id));");
               sb.AppendLine("return Convert.ToInt32(obj);");
               sb.AppendLine("}"); 
               #endregion
               #region 字符串并接（更新）
               sb.AppendLine("public int Update(" + tablename + "Model" + "  " + "model){");
               sb.AppendLine("object obj=sqlHelper.ExecuteNonQuery(");
               sb.AppendLine("\"update  " + tablename + " set " + "(" + string.Join(",", colnames) + ")where id=@id\",");
               sb.AppendLine("new SqlParameter(\"id\",model.");
               sb.AppendLine(colnames[0]);
               sb.AppendLine("));");
               sb.AppendLine("return Convert.ToInt32(obj);");
               sb.AppendLine("}");
               #endregion
               #region 字符串并接（查询多行数据）
               sb.AppendLine("public " + tablename + "Model" + "  selectMoreRows(int id){");
               sb.AppendLine("DataTable dt = sqlHelper.ExecuteDataTable(\"select * from "
                   + tablename + "  where id=@id\",");
               sb.AppendLine("new SqlParameter(\"id\",id));");
               sb.AppendLine("if (dt.Rows.Count <= 0){return null;}");
               sb.AppendLine(" else if (dt.Rows.Count == 1){");
               sb.AppendLine(tablename + "Model" + "  model= new  " + tablename + "Model();");
               sb.AppendLine("DataRow row = dt.Rows[0];");
               foreach (DataRow dr in dtCols.Rows)
               {
                   string colname = dr["COLUMN_NAME"].ToString();
                   string dateType = dr["DATA_TYPE"].ToString();
                   string netType = toNetType(dateType);
                   sb.AppendLine("model." + colname + "=" + "(" + netType + ")" + "row[\"" + colname + "\"];");
               }
               sb.AppendLine("return  model;");
               sb.AppendLine("}");
               sb.AppendLine("else{throw new Exception(\"出现多条数据\");}");
               sb.AppendLine("}");
               #endregion

               #region 查询所有值用到了IEumerable接口
               sb.AppendLine("public IEnumerable<" + tablename + "Model" + "> ListAll(){");
               sb.AppendLine("List<" + tablename + "Model" + "> list = new List<" +
                 tablename + "Model" + ">();");
               sb.AppendLine("DataTable dt = sqlHelper.ExecuteDataTable(\"select * from " +
               tablename + "\");");
               sb.AppendLine("foreach (DataRow row in dt.Rows){");
               sb.AppendLine(tablename + "Model" + "  model= new  " + tablename + "Model();");
               foreach (DataRow dr in dtCols.Rows)
               {
                   string colname = dr["COLUMN_NAME"].ToString();
                   string dateType = dr["DATA_TYPE"].ToString();
                   string netType = toNetType(dateType);
                   sb.AppendLine("model." + colname + "=" + "(" + netType + ")" + "row[\"" + colname + "\"];");
               }
               sb.AppendLine("list.Add(model);}");
               sb.AppendLine("return list;}"); 
               #endregion
              
               sb.AppendLine("}");
               sb.AppendLine("}");
               return sb;
              
           }
           
       }
       public StringBuilder creatBLL(string tablename) //创建BLL
       {
           DataTable dtCols = ExecuteDataTable("SELECT * FROM  INFORMATION_SCHEMA.COlUMNS where Table_name=@table and  COLUMN_NAME<>'ID' ", new SqlParameter("@table", tablename));
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("using System;");
           sb.AppendLine("using System.Text;");
           sb.AppendLine("using System.Data;");
           sb.AppendLine("using System.Data.SqlClient;");
           sb.AppendLine("using System.Collections.Generic;");
           sb.AppendLine("using " + model.RootNamespace + ".DAL;");
           sb.AppendLine("using " + model.RootNamespace + ".Model;");
           sb.AppendLine("namespace " + model.RootNamespace + ".BLL");
           sb.AppendLine("{");
           sb.AppendLine("partial class" + "  " + tablename + "BLL");
           sb.AppendLine("{");
           #region 字符串并接（增加）
           sb.AppendLine("public int insert(" + tablename + "Model" + "  " + "model){");
           sb.AppendLine("return new  "+tablename+"DAL().");
           sb.AppendLine("insert(model);");
           sb.AppendLine("}");
           #endregion
           #region 字符串并接（删）
           sb.AppendLine("public int Delete(int id){");
           sb.AppendLine("return new  " + tablename + "DAL().");
           sb.AppendLine("Delete(id);");
           sb.AppendLine("}");
           #endregion
           #region 字符串并接（更新）
           sb.AppendLine("public int Update(" + tablename + "Model" + "  " + "model){");
           sb.AppendLine("return new  " + tablename + "DAL().");
           sb.AppendLine("Update(model);");
           sb.AppendLine("}");
           #endregion
           #region 字符串并接（查询多行数据）
           sb.AppendLine("public " + tablename + "Model" + "  selectMoreRows(int id){");
           sb.AppendLine("return new  " + tablename + "DAL().");
           sb.AppendLine("selectMoreRows(id);");
           sb.AppendLine("}");
           #endregion
           #region 查询所有值用到了IEumerable接口
           sb.AppendLine("public IEnumerable<" + tablename + "Model" + ">  ListAll(){");
           sb.AppendLine("return new  " + tablename + "DAL().");
           sb.AppendLine("ListAll();");
           sb.AppendLine("}");
           #endregion
           sb.AppendLine("}");
           sb.AppendLine("}");
           return sb;
       }
    }
}
