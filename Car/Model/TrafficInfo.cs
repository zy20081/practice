using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.Model
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
        public int Time { get; set; }
                                            
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
        /// 获取或设置被出租的汽车（对象）
        /// </summary>
        public TrafficInfo RentTraffic { set; get; }
        /// <summary>
        /// 获取或设置租车人的证件号
        /// </summary>
        public string RentManID { set; get; }
        /// <summary>
        /// 获取或设置出租车人姓名
        /// </summary>
        public string RentName { set; get; }
        /// <summary>
        /// 获取或设置出租车的车牌号
        /// </summary>
        public string RentNumber { set; get; }
        /// <summary>
        /// 获取或设置出租日期
        /// </summary>
        public DateTime RentDate { set; get; }
        /// <summary>
        /// 获取或设置还车日期
        /// </summary>
        public DateTime ReturnDate { set; get; }
        /// <summary>
        /// 获取或设置出租天数
        /// </summary>
        public int RentDays
        {
            get 
            {
                TimeSpan ts = ReturnDate -RentDate;
                int day = Convert.ToInt32(ts.ToString("dd"));
                if (day <= 0)
                    day = 1;
                return day;
            }
        }
        /// <summary>
        /// 获取出租总金额
        /// </summary>
        public double RentMoney
        {
            get
            {
                return this.RentDays * Money;
            }

        }
    }

}
