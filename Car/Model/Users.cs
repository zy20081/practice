using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.Model
{
    [Serializable]
    public class Users
    {
        public string UID { get; set; }
        public string pwd { get; set; }
        public string sex { get; set; }
        public DateTime stoptime
        {
            get;
            set;
        }
        public DateTime SelectStopTime { get; set; }
    }
}
