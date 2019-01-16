using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 三层架构.Model;
using System.Data.SqlClient;
using System.Data;
namespace 三层架构.DAL
{
    class PersonDAL
    {
        public int selectNew(users model)//查询单个数据
        {
            object ExecuteScalar = sqlHelper.ExecuteScalar("select userpass from username where userid=@id and userpass=@pwd", new SqlParameter("@id", model.userid), new SqlParameter("@pwd", model.userpass));
            return Convert.ToInt32(ExecuteScalar);
        }
        public int insert(users model) //增加数据
        {

         return sqlHelper.ExecNonQuery("insert into username(userid,userpass) values(@id,@pass)", new SqlParameter("@id", model.userid), new SqlParameter("@pass", model.userpass));
        }
        public int delete(users model) //删除数据
        {
          return sqlHelper.ExecNonQuery("delete from username where userid=@id",new SqlParameter("id",model.userid));
        }
        public int update(int id,users model) //更新数据
        {
            return sqlHelper.ExecNonQuery("update username set userid =@userid where ID=@id", new SqlParameter("@userid",model.userid), new SqlParameter("@id",id));
        }
        public users get(string id) //查询数据
        {
            DataTable dt = sqlHelper.ExecuteDataTable("select * from username where userid=@id", new SqlParameter("@id", id));
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else if (dt.Rows.Count >= 1)
            {
                users model = new users();
                DataRow row = dt.Rows[0];
                model.userid = row["userid"].ToString();
                model.userpass = Convert.ToInt32(row["userpass"]);
                return model;
            }
            else 
            {
                throw new Exception("");
            }
        }
        public IEnumerable<users> GetAll() //查询所有值用到了IEumerable接口
        {
            DataTable dt = sqlHelper.ExecuteDataTable("select * from username");
            List<users> list=new List<users>();
            foreach (DataRow row in dt.Rows) 
            {
                users model = new users();
                model.id = Convert.ToInt32(row["id"]);
                model.userid = row["userid"].ToString();
                model.userpass = Convert.ToInt32(row["userpass"]);
                list.Add(model);
            }
            return list;
 
        }
    }
}
