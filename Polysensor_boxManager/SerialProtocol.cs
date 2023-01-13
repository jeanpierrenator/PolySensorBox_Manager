using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{
    internal class SerialProtocol
    {
        private static readonly byte[] CONNECT_FRAME = { 0xAA, 0x55 };
        private static readonly byte[] CONNECT_RES_FRAME = { 0x55, 0xAA };

        private static readonly byte TIMESTAMP_HEADER_FRAME = 0x06;

        private static readonly byte[] START_CONFIG_FRAME = { 0x01, 0xFF };
        private static readonly byte[] START_CONFIG_FRAME_RES = { 0x01, 0xFF };
        private static readonly byte[] END_CONFIG_FRAME = { 0x01, 0x00 };
        private static readonly byte[] END_CONFIG_FRAME_RES = { 0x01, 0x00 };
        private static readonly byte CONFIG_FRAME_HEADER = 0x02;
        public static int SendConfig(ConfigModel myConfigModel)
        {
            byte[] buffer;
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(START_CONFIG_FRAME, START_CONFIG_FRAME.Length);
            Thread.Sleep(500);
            buffer = SerialManager.GetInstance().Read();
            if (!buffer.SequenceEqual(START_CONFIG_FRAME_RES))
            {
                return -1;
            }
            List<int> usedSensor = myConfigModel.getListOfUsedSensor();
            foreach (int sensorID in usedSensor)
            {
                int index = 0;
                byte[] tempBuffer = new byte[50];
                tempBuffer[index++] = 0x02;
                tempBuffer[index++] = (byte)sensorID;
                tempBuffer[index++] = (byte)((myConfigModel.getLineNumberOfSensor(sensorID)<<6)+myConfigModel.getListOfPhysicalOfsensor(sensorID).Count);
                foreach (int physical in myConfigModel.getListOfPhysicalOfsensor(sensorID))
                {
                    tempBuffer[index++] = (byte)physical;
                    tempBuffer[index++] = (byte)(myConfigModel.getPeriodeOfPhysical(physical)/65536);
                    tempBuffer[index++] = (byte)(myConfigModel.getPeriodeOfPhysical(physical) / 256);
                    tempBuffer[index++] = (byte)(myConfigModel.getPeriodeOfPhysical(physical));
                }
                tempBuffer[index++] = calculChecksum(tempBuffer,index);
                SerialManager.GetInstance().clear();
                SerialManager.GetInstance().Write(tempBuffer, index);

                Thread.Sleep(500);
                buffer = SerialManager.GetInstance().Read();
                if (buffer.Length >= 2)
                {
                    if (buffer[0] != 0x02 || buffer[1] != tempBuffer[index - 1])
                    {
                        Debug.WriteLine("erreur contenu");
                        break;
                    }
                }
                else
                {
                    Debug.WriteLine("erreur size");
                    break;
                }
            }
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(END_CONFIG_FRAME, START_CONFIG_FRAME.Length);
            Thread.Sleep(500);
            buffer = SerialManager.GetInstance().Read();

            if (!buffer.SequenceEqual(END_CONFIG_FRAME_RES))
            {
                return -1;
            }
            return 0;
        }




        private static byte calculChecksum(byte[] buff , int size)
        {
            int checksum = 0;

            for(int i = 0; i < size; i++)
            {
                checksum += buff[i];
            }
            checksum = checksum % 256;
            return (byte)checksum;
        }
    }
}
