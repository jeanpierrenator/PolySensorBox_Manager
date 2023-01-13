using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Diagnostics;

namespace Polysensor_boxManager
{
    internal class ConfigXMLManager
    {
        public ConfigModel parseData(string file)
        {
           
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigModel));
            ConfigModel configModel;
            using (var reader = new StreamReader(file))
            {
                configModel =  (ConfigModel)xmlSerializer.Deserialize(reader);
            }

            return configModel;

        }
        public void saveConfig(string file, ConfigModel configModel)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigModel));
            using (var writer = new StreamWriter(file))
            {
               xmlSerializer.Serialize(writer,configModel);
            }


        }
    }
}
