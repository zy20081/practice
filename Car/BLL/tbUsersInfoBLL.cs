using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.Model;
using Car.DAL;
using System.Data;
namespace Car.BLL
{
    partial class TrafficBLL
    {///增加用户的方法
        public void AddNew(Users model) 
        {
            new TrDAL().AddNew(model);
        }
        /// <summary>
        /// 修改密码的方法
        /// </summary>
        /// <param name="model"></param>
        public void Update(Users model) 
        {
          bool alter= new TrDAL().Update(model);
          if (alter==false) 
          {
              throw new Exception("密码不正确");
          }
        }
        //查询数据
        public IEnumerable<Users> ListAll() 
        {
          return  new TrDAL().ListAll();
        }
        //关键字搜索
        public DataTable showkey(string strkey) 
        {
            return new TrDAL().showkey(strkey);
        }
        //删除
        public void Delete(Users model) 
        {
            new TrDAL().Delete(model);
        }

    }
}
