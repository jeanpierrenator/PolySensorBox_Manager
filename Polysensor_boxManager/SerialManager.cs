using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysensor_boxManager
{
    internal class SerialManager
    {
        private static SerialPort _serialPort;
        public static bool isOpen = false;
        private static SerialManager _instance;
        private SerialManager()
        {
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = _serialPort.PortName;
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = _serialPort.Parity;
            _serialPort.DataBits = _serialPort.DataBits;
            _serialPort.StopBits = _serialPort.StopBits;
            _serialPort.Handshake = _serialPort.Handshake;
           // _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }

        ~SerialManager()
        {
            _serialPort.Close();
        }

        public void OpenPort()
        {
            _serialPort.Open();

            isOpen = true;
        }
        public void ClosePort()
        {
            _serialPort.Close();
            isOpen = false;
        }

        public static SerialManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SerialManager();
            }
            return _instance;
        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50);
            int size = _serialPort.BytesToRead;
            byte[] returnBytes = new byte[size];
            _serialPort.Read(returnBytes, 0, size);
        }

        public void Write(byte[] printBytes, int sizeData)
        {
            _serialPort.Write(printBytes, 0, sizeData);
        }
        public byte[] Read()
        {
            int size = _serialPort.BytesToRead;
            byte[] returnBytes = new byte[size];
            _serialPort.Read(returnBytes, 0, size);
            return returnBytes;
        }
        public void clear()
        {
            _serialPort.DiscardInBuffer();
        }

        // Display Port values and prompt user to enter a port.
        public static String[] GetAvailablePort()
        {
            return SerialPort.GetPortNames();
        }
        public void SetPortName(string portName)
        {
            _serialPort.PortName = portName;
        }

    }
}
