using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{

    // REMARQUE : Le code généré peut nécessiter au moins .NET Framework 4.5 ou .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ConfigModel
    {

        private int line1Field;

        private int line2Field;

        private int line3Field;

        private int tempSensorField;

        private int tempPeriodeField;

        private int humidSensorField;

        private int humidPeriodeField;

        private int co2SensorField;

        private int co2PeriodeField;

        private int luxSensorField;

        private int luxPeriodeField;

        private int eCo2SensorField;

        private int eCo2PeriodeField;

        private int tovcSensorField;

        private int tovcPeriodeField;

        private int pressionSensorField;

        private int pressionPeriodeField;

        private int uvSensorField;

        private int uvPeriodeField;

        Dictionary<int, int> physicalIDToSensorID;
        Dictionary<int, int> physicalIDToPhysicalPeriod;

        public ConfigModel()
        {
            physicalIDToPhysicalPeriod = new Dictionary<int, int>();
            physicalIDToSensorID = new Dictionary<int, int>();

            physicalIDToPhysicalPeriod.Add(DataConstant.ID_TEMP, tempPeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_HUMIDITY, humidPeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_CO2, co2PeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_LUX, luxPeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_ECO2, eCo2PeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_TOVC, tovcPeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_UV, uvPeriodeField);
            physicalIDToPhysicalPeriod.Add(DataConstant.ID_PRESS, pressionPeriodeField);

            physicalIDToSensorID.Add(DataConstant.ID_TEMP, tempSensorField);
            physicalIDToSensorID.Add(DataConstant.ID_HUMIDITY, humidSensorField);
            physicalIDToSensorID.Add(DataConstant.ID_CO2, co2SensorField);
            physicalIDToSensorID.Add(DataConstant.ID_LUX, luxSensorField);
            physicalIDToSensorID.Add(DataConstant.ID_ECO2, eCo2SensorField);
            physicalIDToSensorID.Add(DataConstant.ID_TOVC, tovcSensorField);
            physicalIDToSensorID.Add(DataConstant.ID_UV, uvSensorField);
            physicalIDToSensorID.Add(DataConstant.ID_PRESS, pressionSensorField);
        }
        public void clear()
        {
            this.line1Field = 0;
            this.line2Field = 0;
            this.line3Field = 0;
            tempSensorField = 0;
            tempPeriodeField = 0;
            humidSensorField = 0;
            humidPeriodeField= 0;
            co2SensorField = 0;
            co2PeriodeField = 0;
            luxSensorField = 0;
            luxPeriodeField = 0;
            eCo2SensorField = 0;
            eCo2PeriodeField = 0;
            tovcSensorField = 0;
            tovcPeriodeField = 0;
            uvPeriodeField = 0;
            uvSensorField = 0;
            pressionSensorField = 0;
            pressionPeriodeField = 0;
            foreach (int i in physicalIDToSensorID.Keys)
            {
                physicalIDToSensorID[i] = 0;
                physicalIDToSensorID[i] = 0;
            }
        }

        public void updateValue(int physicalID, int sensorID , int sensorPeriod)
        {
            if (physicalID == DataConstant.ID_TEMP)
            {
                tempSensorField = sensorID;
                tempPeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_TEMP] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_TEMP] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_HUMIDITY)
            {
                humidSensorField = sensorID;
                humidPeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_HUMIDITY] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_HUMIDITY] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_LUX)
            {
                luxSensorField = sensorID;
                luxPeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_LUX] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_LUX] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_ECO2)
            {
                eCo2SensorField = sensorID;
                eCo2PeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_ECO2] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_ECO2] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_TOVC)
            {
                tovcSensorField = sensorID;
                tovcPeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_TOVC] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_TOVC] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_CO2)
            {
                co2SensorField = sensorID;
                co2PeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_CO2] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_CO2] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_PRESS)
            {
                pressionSensorField = sensorID;
                pressionPeriodeField = sensorPeriod;
                physicalIDToSensorID[DataConstant.ID_PRESS] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_PRESS] = sensorPeriod;
            }
            if(physicalID ==DataConstant.ID_UV)
            {
                uvPeriodeField = sensorPeriod;
                uvSensorField = sensorID;
                physicalIDToSensorID[DataConstant.ID_UV] = sensorID;
                physicalIDToPhysicalPeriod[DataConstant.ID_UV] = sensorPeriod;
            }
        }
        /// <remarks/>
        public int line1
        {
            get
            {
                return this.line1Field;
            }
            set
            {
                this.line1Field = value;
            }
        }

        /// <remarks/>
        public int line2
        {
            get
            {
                return this.line2Field;
            }
            set
            {
                this.line2Field = value;
            }
        }

        /// <remarks/>
        public int line3
        {
            get
            {
                return this.line3Field;
            }
            set
            {
                this.line3Field = value;
            }
        }

        /// <remarks/>
        public int TempSensor
        {
            get
            {
                return this.tempSensorField;
            }
            set
            {
                this.tempSensorField = value;
            }
        }

        /// <remarks/>
        public int TempPeriode
        {
            get
            {
                return this.tempPeriodeField;
            }
            set
            {
                this.tempPeriodeField = value;
            }
        }

        /// <remarks/>
        public int HumidSensor
        {
            get
            {
                return this.humidSensorField;
            }
            set
            {
                this.humidSensorField = value;
            }
        }

        /// <remarks/>
        public int HumidPeriode
        {
            get
            {
                return this.humidPeriodeField;
            }
            set
            {
                this.humidPeriodeField = value;
            }
        }

        /// <remarks/>
        public int Co2Sensor
        {
            get
            {
                return this.co2SensorField;
            }
            set
            {
                this.co2SensorField = value;
            }
        }

        /// <remarks/>
        public int Co2Periode
        {
            get
            {
                return this.co2PeriodeField;
            }
            set
            {
                this.co2PeriodeField = value;
            }
        }

        /// <remarks/>
        public int LuxSensor
        {
            get
            {
                return this.luxSensorField;
            }
            set
            {
                this.luxSensorField = value;
            }
        }

        /// <remarks/>
        public int LuxPeriode
        {
            get
            {
                return this.luxPeriodeField;
            }
            set
            {
                this.luxPeriodeField = value;
            }
        }

        /// <remarks/>
        public int eCo2Sensor
        {
            get
            {
                return this.eCo2SensorField;
            }
            set
            {
                this.eCo2SensorField = value;
            }
        }

        /// <remarks/>
        public int eCo2Periode
        {
            get
            {
                return this.eCo2PeriodeField;
            }
            set
            {
                this.eCo2PeriodeField = value;
            }
        }

        /// <remarks/>
        public int TovcSensor
        {
            get
            {
                return this.tovcSensorField;
            }
            set
            {
                this.tovcSensorField = value;
            }
        }

        /// <remarks/>
        public int TovcPeriode
        {
            get
            {
                return this.tovcPeriodeField;
            }
            set
            {
                this.tovcPeriodeField = value;
            }
        }

        /// <remarks/>
        public int PressionSensor
        {
            get
            {
                return this.pressionSensorField;
            }
            set
            {
                this.pressionSensorField = value;
            }
        }

        /// <remarks/>
        public int PressionPeriode
        {
            get
            {
                return this.pressionPeriodeField;
            }
            set
            {
                this.pressionPeriodeField = value;
            }
        }

        /// <remarks/>
        public int UvSensor
        {
            get
            {
                return this.uvSensorField;
            }
            set
            {
                this.uvSensorField = value;
            }
        }

        /// <remarks/>
        public int UvPeriode
        {
            get
            {
                return this.uvPeriodeField;
            }
            set
            {
                this.uvPeriodeField = value;
            }
        }
        public int getLineNumberOfSensor(int sensorId)
        {
            if(this.line1Field == sensorId)
            {
                return 1;
            }
            if (this.line2Field == sensorId)
            {
                return 2;
            }
            if (this.line3Field == sensorId)
            {
                return 3;
            }

            return -1;
        }


        public int getPeriodeOfPhysical(int idPhysical)
        {
            return physicalIDToPhysicalPeriod[idPhysical];
        }

        public int getSensorIDofPhysical(int idPhysical)
        {
            return physicalIDToSensorID[idPhysical];
        }

        public List<int> getListOfPhysicalOfsensor(int sensorID)
        {
            List<int> list = new List<int>();

            foreach (int i in physicalIDToSensorID.Keys)
            {
                if(physicalIDToSensorID[i] == sensorID)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public List<int> getListOfUsedSensor()
        {
            List<int> list = new List<int>();

            foreach (int i in physicalIDToSensorID.Keys)
            {
                if (physicalIDToSensorID[i] != 0)
                    list.Add(physicalIDToSensorID[i]);
            }
            list = list.Distinct().ToList();
            return list;
        }
    }

   


}
