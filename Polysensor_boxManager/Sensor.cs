using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class Sensor
       {

        private int idField;

        private string nameField;

        private int runConsoField;

        private int sleepConsoField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public int runConso
        {
            get
            {
                return this.runConsoField;
            }
            set
            {
                this.runConsoField = value;
            }
        }

        /// <remarks/>
        public int sleepConso
        {
            get
            {
                return this.sleepConsoField;
            }
            set
            {
                this.sleepConsoField = value;
            }
        }
        public Sensor(int idField, string nameField, int runConsoField, int sleepConsoField)
        {
            this.idField = idField;
            this.nameField = nameField;
            this.runConsoField = runConsoField;
            this.sleepConsoField = sleepConsoField;
        }
    }



}
