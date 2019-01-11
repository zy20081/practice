using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    [Serializable]
    public class TrafficInfo
    {   
        public TrafficInfo() { }///无参数的构造方法
        //public  string Run(int speed);//抽象方法
        private string number;
        /// <summary>
        /// 车牌号
        /// </summary>
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string name;
        /// <summary>
        /// 车名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string color;
        /// <summary>
        /// 车颜色
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// 使用时间
        /// </summary>
        public string Time { get; set; }
                               
                         
        private int money;
        /// <summary>
        /// 租金
        /// </summary>
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        private string load;
        /// <summary>
        /// 载重量
        /// </summary>
        public string Load
        {
            get { return load; }
            set { load = value; }
        }
        /// <summary>
        /// 出租时间
        /// </summary>
        public string datatime { get; set; }
        /// <summary>
        /// 租户
        /// </summary>
        public string tenement { get; set; }
        public int speed { get; set; }
 ///计算总租金
        //public abstract double  ComputeRent(float rentDays); 
   

         
    }

}
