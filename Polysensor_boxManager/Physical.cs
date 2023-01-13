using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{
    internal class Physical
    {
        private List<Sensor> sensorList;
        public string name { get; set; }
        public List<Sensor> sensors { 
            get
            {
                return this.sensorList;
            }
            set
            {
                this.sensorList = value;
            } 
        }

        public Physical(string name)
        {
            this.name = name;
            sensorList = new List<Sensor>();
        }



    }
}
