using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{  [Serializable]
   public class XRentManager
    {
       public XRentManager()
       {
           m_DicMyTraffics = new Dictionary<string, TrafficInfo>();
           m_DicRenteds = new Dictionary<string, TrafficInfo>();//出租集合
       }
        ///字典集合：保存可以出租的车
       private Dictionary<string, TrafficInfo> m_DicMyTraffics;
       internal Dictionary<string, TrafficInfo> DicMyTraffics
            {
                get { return m_DicMyTraffics; }
            }
         /// <summary>
        /// 获取可以出租的汽车集合
        /// </summary>
          private Dictionary<string, TrafficInfo> m_DicRenteds;
       /// <summary>
       /// 汽车入库或者出租的车回库
       /// </summary>
          internal Dictionary<string, TrafficInfo> DicRenteds
            {
              get { return m_DicRenteds; }
            }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="t">要入库的车</param>
          internal void InputLibry(TrafficInfo t) 
         {
             if (DicMyTraffics.ContainsKey(t.Number))
                 throw new Exception("已经有人添加了这个号码");
                 this.DicMyTraffics.Add(t.Number, t);
         
           
             if(this.DicRenteds.ContainsKey(t.Number))
             {
                 this.DicRenteds.Remove(t.Number);
             }
         }
           /// <summary>
           ///  出租汽车
           /// </summary>
           /// <param name="t"></param>
          internal void Rent(TrafficInfo t)//出租
         {
             this.DicRenteds.Add(t.Number, t);//添加到了出租集合里；
             this.DicMyTraffics.Remove(t.Number);
         }
  
    }
}
