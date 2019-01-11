using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.Model
{
   public class ccountModel
    {   /// <summary>
        /// 关键字搜索月份
        /// </summary>
        public string month
        {
            set;
            get;
        }
        /// <summary>
        /// 关键字搜索年份
        /// </summary>
        public string year
        {
            set;
            get;
        }
        public string reslut { set; get; }
    }
}
