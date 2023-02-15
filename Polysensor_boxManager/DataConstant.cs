using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{
    static class DataConstant
    {
        public const int ID_TEMP = 1;
        public const string STRING_TEMP = "Temperature"; 
        public const int ID_HUMIDITY = 2;
        public const string STRING_HUMIDITY = "Humidity";
        public const int ID_LUX = 3;
        public const string STRING_LUX = "Brightness";
        public const int ID_ECO2 = 4;
        public const string STRING_ECO2 = "Eco2";
        public const int ID_TOVC = 5;
        public const string STRING_TOVC = "Tovc";
        public const int ID_CO2 = 6;
        public const string STRING_CO2 = "Co2";
        public const int ID_PRESS = 7;
        public const string STRING_PRESS = "Pressure";
        public const int ID_UV = 8;
        public const string STRING_UV = "UV";

        public const int SCD30_ID = 1;
        public const string SCD30_NAME = "scd30";
        public const int SCD30_RUNCONSO = 80000;
        public const int SCD30_SLEEPCONSO = 4000;

        public const int BME280_ID = 2;
        public const string BME280_NAME = "bme280";
        public const int BME280_RUNCONSO = 4000;
        public const int BME280_SLEEPCONSO = 1;

        public const int BME680_ID = 3;
        public const string BME680_NAME = "bme680";
        public const int BME680_RUNCONSO = 4000;
        public const int BME680_SLEEPCONSO = 1;

        public const int SI1145_ID = 4;
        public const string SI1145_NAME = "si1145";
        public const int SI1145_RUNCONSO = 4000;
        public const int SI1145_SLEEPCONSO = 1;

        public const int VEML7700_ID = 5;
        public const string VEML7700_NAME = "veml7700";
        public const int VEML7700_RUNCONSO = 4000;
        public const int VEML7700_SLEEPCONSO = 1;

        public const int SGP30_ID = 6;
        public const string SGP30_NAME = "sgp30";
        public const int SGP30_RUNCONSO = 4000;
        public const int SGP30_SLEEPCONSO = 1;

        public const int SCD41_ID = 7;
        public const string SCD41_NAME = "scd41";
        public const int SCD41_RUNCONSO = 4000;
        public const int SCD41_SLEEPCONSO = 1;

    }
}
