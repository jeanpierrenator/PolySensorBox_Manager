using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{
    internal class DataModel
    {
        public Dictionary<string, int> physicalStringToId { get; }
        public Dictionary<int, Physical> physicals { get; }

        public Dictionary<int , Sensor> sensors { get; }
        public Dictionary<String, int> sensorStringToId { get; }

        private static DataModel instance;
        private DataModel()
        {
            physicals = new Dictionary<int, Physical>();
            physicalStringToId = new Dictionary<string, int>();
            sensors = new Dictionary<int , Sensor>();
            sensorStringToId = new Dictionary<string, int>();
            initPhysical();
            initCapteur();
        }
        public void initPhysical()
        {
            physicalStringToId.Add(DataConstant.STRING_TEMP, DataConstant.ID_TEMP);
            physicalStringToId.Add(DataConstant.STRING_HUMIDITY, DataConstant.ID_HUMIDITY);
            physicalStringToId.Add(DataConstant.STRING_LUX, DataConstant.ID_LUX);
            physicalStringToId.Add(DataConstant.STRING_ECO2, DataConstant.ID_ECO2);
            physicalStringToId.Add(DataConstant.STRING_TOVC, DataConstant.ID_TOVC);
            physicalStringToId.Add(DataConstant.STRING_CO2, DataConstant.ID_CO2);
            physicalStringToId.Add(DataConstant.STRING_PRESS, DataConstant.ID_PRESS);
            physicalStringToId.Add(DataConstant.STRING_UV, DataConstant.ID_UV);

            physicals.Add(DataConstant.ID_TEMP, new Physical(DataConstant.STRING_TEMP));
            physicals.Add(DataConstant.ID_HUMIDITY, new Physical(DataConstant.STRING_HUMIDITY));
            physicals.Add(DataConstant.ID_LUX, new Physical(DataConstant.STRING_LUX));
            physicals.Add(DataConstant.ID_ECO2, new Physical(DataConstant.STRING_ECO2));
            physicals.Add(DataConstant.ID_TOVC, new Physical(DataConstant.STRING_TOVC));
            physicals.Add(DataConstant.ID_CO2, new Physical(DataConstant.STRING_CO2));
            physicals.Add(DataConstant.ID_PRESS, new Physical(DataConstant.STRING_PRESS));
            physicals.Add(DataConstant.ID_UV, new Physical(DataConstant.STRING_UV));
        }
        public void initCapteur()
        {
            Sensor scd30 = new Sensor(DataConstant.SCD30_ID, DataConstant.SCD30_NAME, DataConstant.SCD30_RUNCONSO, DataConstant.SCD30_SLEEPCONSO);
            physicals[DataConstant.ID_TEMP].sensors.Add(scd30);
            physicals[DataConstant.ID_HUMIDITY].sensors.Add(scd30);
            physicals[DataConstant.ID_CO2].sensors.Add(scd30);
            sensors.Add(DataConstant.SCD30_ID, scd30);
            sensorStringToId.Add(DataConstant.SCD30_NAME, DataConstant.SCD30_ID);


            Sensor bme280 = new Sensor(DataConstant.BME280_ID, DataConstant.BME280_NAME, DataConstant.BME280_RUNCONSO, DataConstant.BME280_SLEEPCONSO);
            physicals[DataConstant.ID_TEMP].sensors.Add(bme280);
            physicals[DataConstant.ID_HUMIDITY].sensors.Add(bme280);
            physicals[DataConstant.ID_PRESS].sensors.Add(bme280);
            physicals[DataConstant.ID_ECO2].sensors.Add(bme280);
            sensors.Add(DataConstant.BME280_ID, bme280);
            sensorStringToId.Add(DataConstant.BME280_NAME, DataConstant.BME280_ID);

            Sensor bme680 = new Sensor(DataConstant.BME680_ID, DataConstant.BME680_NAME, DataConstant.BME680_RUNCONSO, DataConstant.BME680_SLEEPCONSO);
            physicals[DataConstant.ID_TEMP].sensors.Add(bme680);
            physicals[DataConstant.ID_HUMIDITY].sensors.Add(bme680);
            physicals[DataConstant.ID_PRESS].sensors.Add(bme680);
            physicals[DataConstant.ID_ECO2].sensors.Add(bme680);
            sensors.Add(DataConstant.BME680_ID, bme680);
            sensorStringToId.Add(DataConstant.BME680_NAME, DataConstant.BME680_ID);

            Sensor si1145 = new Sensor(DataConstant.SI1145_ID, DataConstant.SI1145_NAME, DataConstant.SI1145_RUNCONSO, DataConstant.SI1145_SLEEPCONSO);
            physicals[DataConstant.ID_UV].sensors.Add(si1145);
            sensors.Add(DataConstant.SI1145_ID, si1145);
            sensorStringToId.Add(DataConstant.SI1145_NAME, DataConstant.SI1145_ID);

            Sensor veml7700 = new Sensor(DataConstant.VEML7700_ID, DataConstant.VEML7700_NAME, DataConstant.VEML7700_RUNCONSO, DataConstant.VEML7700_SLEEPCONSO);
            physicals[DataConstant.ID_LUX].sensors.Add(veml7700);
            sensors.Add(DataConstant.VEML7700_ID, veml7700);
            sensorStringToId.Add(DataConstant.VEML7700_NAME, DataConstant.VEML7700_ID);

            Sensor sgp30 = new Sensor(DataConstant.SGP30_ID, DataConstant.SGP30_NAME, DataConstant.SGP30_RUNCONSO, DataConstant.SGP30_SLEEPCONSO);
            physicals[DataConstant.ID_ECO2].sensors.Add(sgp30);
            physicals[DataConstant.ID_TOVC].sensors.Add(sgp30);
            sensors.Add(DataConstant.SGP30_ID, sgp30);
            sensorStringToId.Add(DataConstant.SGP30_NAME, DataConstant.SGP30_ID);
        }

        public static DataModel getInstance()
        {
            if(instance == null)
            {
                instance = new DataModel();
            }
            return instance;
        }

    }
}
