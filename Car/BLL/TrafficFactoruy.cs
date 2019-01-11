using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.DAL;
using Car.Model;
namespace Car.BLL
{
    class TrafficFactoruy
    {     ///方法：负责根据指定的类型创建不同的汽车对象，用父类返回对象
        public static TrafficInfo CreatNewTraffic(string type)//父类，创建新对象，，string 类型 参数
        {
            TrafficInfo tR = null;
            switch (type) 
            {
                case "Car": tR = new Xcar(); break;
                case "Truck": tR = new XTruck(); break;
            }
            return tR;
        }
    }
}
