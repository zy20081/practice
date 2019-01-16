using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 三层架构.DAL;
using 三层架构.Model;
namespace 三层架构.BLL
{
    class PersonBLL
    {
        public int selectNew(users model)//查询单个数据
        {
            return new PersonDAL().selectNew(model);
        }
        public int insert(users model) //增加数据
        {

            return new PersonDAL().insert(model);
        }
        public int delete(users model) //删除数据
        {
            return new PersonDAL().delete(model);
        }
        public int update(int id,users model) //删除数据
        {
            return new PersonDAL().update(id,model);
        }
        public users get(string id) //查询数据
        {
            return new PersonDAL().get(id);
        }
        public IEnumerable<users> GetAll() //查询所有数据
        {
            return new PersonDAL().GetAll();
        }
    }
}
