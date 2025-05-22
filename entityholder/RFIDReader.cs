using System.IO.Ports;
namespace VeterinaryClinicApp
{
    public class RFIDReader
    {
        private SerialPort serialPort;
        public event Action<string> OnRFIDScanned;
        public RFIDReader(string portName, int baudRate = 9600)
        {
            serialPort = new SerialPort(portName, baudRate)
            {
                ReadTimeout = 500, 
                WriteTimeout = 500, 
                NewLine = "\r\n" 
            };
            serialPort.DataReceived += SerialPort_DataReceived;
        }
        public void StartReading()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to open serial port {serialPort.PortName}: {ex.Message}");
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string rfidTag = serialPort.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(rfidTag))
                {
                    OnRFIDScanned?.Invoke(rfidTag);
                }
            }
            catch (TimeoutException)
            {
                Console.WriteLine("Data reading timeout.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading data from RFID reader: {ex.Message}");
            }
        }
        public void StopReading()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while closing serial port: {ex.Message}");
            }
        }
    }
}
