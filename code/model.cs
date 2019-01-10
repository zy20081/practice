using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code
{
    class model
    {
       static public string FilePath { get; set; } //路径
       static public string constr { get; set; }//连接字符串
       static public string BuilderDAL { get; set; }//DAL拼接数据
       static public string BuilderModel { get; set; }//Model拼接数据
       static public string BuilderBLL { get; set; }//BLL拼接数据
       static public string RootNamespace { get; set; }//命名空间
    }
}
