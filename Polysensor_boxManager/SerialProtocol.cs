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
        private const int MillisecondsTimeout = 500;
        private static readonly byte[] CONNECT_FRAME = { 0xAA, 0x55 };
        private static readonly byte[] CONNECT_RES_FRAME = { 0x55, 0xAA };

        private static readonly byte TIMESTAMP_HEADER_FRAME = 0x06;

        private static readonly byte[] START_CONFIG_FRAME = { 0x01, 0xFF };
        private static readonly byte[] START_CONFIG_FRAME_RES = { 0x01, 0xFF };
        private static readonly byte[] END_CONFIG_FRAME = { 0x01, 0x00 };
        private static readonly byte[] END_CONFIG_FRAME_RES = { 0x01, 0x00 };
        private static readonly byte CONFIG_FRAME_HEADER = 0x02;

        private static readonly byte[] START_READ_CONFIG_FRAME = { 0x03, 0xFF };
        private static readonly byte[] START_READ_CONFIG_FRAME_RES = { 0x03, 0xFF };
        private static readonly byte[] READ_CONFIG_FRAME_END = { 0x03, 0x00 };

        private static readonly byte READ_CONFIG_FRAME_HEADER = 0x04;
        private static readonly byte[] READ_CONFIG_OK_FRAME = { 0x04, 0xFF };
        private static readonly byte[] READ_CONFIG_BAD_FRAME = { 0x04, 0x00 };
        public static int SendConfig(ConfigModel myConfigModel)
        {
            byte[] buffer;
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(START_CONFIG_FRAME, START_CONFIG_FRAME.Length);
            Thread.Sleep(MillisecondsTimeout);
            buffer = SerialManager.GetInstance().Read();
            if (!buffer.SequenceEqual(START_CONFIG_FRAME_RES))
            {
                return -1;
            }
            List<int> usedSensor = myConfigModel.getListOfUsedSensor();
            foreach (int sensorID in usedSensor)
            {
            restart:
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

                Thread.Sleep(MillisecondsTimeout);
                buffer = SerialManager.GetInstance().Read();
                if (buffer.Length >= 2)
                {
                    if (buffer[0] != 0x02 || buffer[1] != 0xFF)
                    {
                        Debug.WriteLine("erreur contenu");
                        goto restart;
                        break;
                    }
                }
                else
                {
                    Debug.WriteLine("erreur size");
                    //goto restart;
                    break;
                }
            }
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(END_CONFIG_FRAME, START_CONFIG_FRAME.Length);
            Thread.Sleep(MillisecondsTimeout);
            buffer = SerialManager.GetInstance().Read();

            if (!buffer.SequenceEqual(END_CONFIG_FRAME_RES))
            {
                return -1;
            }
            return 0;
        }

        public static int sendConnectionFrame()
        {
            byte[] buffer;
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(CONNECT_FRAME, START_CONFIG_FRAME.Length);
            Thread.Sleep(MillisecondsTimeout);
            buffer = SerialManager.GetInstance().Read();

            if (!buffer.SequenceEqual(CONNECT_RES_FRAME))
            {
                return -1;
            }
            return 0;
        }

        public static ConfigModel readConfigFromBox()
        {
            byte[] buffer;
            ConfigModel model = new ConfigModel();
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(START_READ_CONFIG_FRAME, START_READ_CONFIG_FRAME.Length);
            Thread.Sleep(MillisecondsTimeout);
            buffer = SerialManager.GetInstance().Read();
            if (!buffer.SequenceEqual(START_READ_CONFIG_FRAME_RES))
            {
                return null;
            }
            SerialManager.GetInstance().clear();
            SerialManager.GetInstance().Write(READ_CONFIG_BAD_FRAME, READ_CONFIG_BAD_FRAME.Length);
            while (!buffer.SequenceEqual(READ_CONFIG_FRAME_END))
            {
                Thread.Sleep(MillisecondsTimeout);
                buffer = SerialManager.GetInstance().Read();
                if (buffer[0] == READ_CONFIG_FRAME_HEADER)
                {
                    if (validateFrame(buffer) == 1)
                    {
                        Debug.WriteLine("bad checksum");
                        SerialManager.GetInstance().clear();
                        SerialManager.GetInstance().Write(READ_CONFIG_BAD_FRAME, READ_CONFIG_BAD_FRAME.Length);
                    }
                    else
                    {
                        parseReadConfigFrame(buffer, model);


                        SerialManager.GetInstance().clear();
                        SerialManager.GetInstance().Write(READ_CONFIG_OK_FRAME, READ_CONFIG_OK_FRAME.Length);
                    }

                }
            }
                
       

            return model;
        }

        private static int parseReadConfigFrame(byte[] buffer , ConfigModel configModel)
        {
            byte sensorID = buffer[1];
            byte nbPhysical = (byte)(buffer[2] & 0b111111);
            byte nbline = (byte)((buffer[2]>>6) & 0b11);
            configModel.setSensorToLine(sensorID, nbline);
            for (int i = 3; i < (nbPhysical * 4) + 3;)
            {
                byte idphysical = buffer[i];
                int periode = (int)((buffer[i + 1]<<16) + (buffer[i + 2] << 8) + buffer[i + 3]);
                configModel.updateValue(idphysical, sensorID, periode);
                i += 4;
            }
            return 0;
        }


        private static int validateFrame(byte[] buffer)
        {
            byte size = (byte)((((buffer[2])& 0b111111)*4)+3);
            if(calculChecksum(buffer,size) != buffer[size])
            {
                return 1;
            }
            return 0;
        }



        private static byte calculChecksum(byte[] buff , int size)
        {
            int checksum = 0;

            for(int i = 1; i < size; i++)
            {
                checksum += buff[i];
            }
            checksum = checksum % 256;
            return (byte)checksum;
        }
    }
}
