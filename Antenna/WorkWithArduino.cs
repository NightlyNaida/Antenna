using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Antenna
{
    class WorkWithArduino
    {
        public bool arduinoFound = false;
        SerialPort [] portSearched = new SerialPort [20] ;
        public string [] serialNumber = new string [20];
        public int iterationSearch = 0;
        
        public SerialPort [] LetsSearchThisShit()
        {
            
            try
            {
                string[] ports = SerialPort.GetPortNames();// получаем список всех портов 
                for (int i = 0; i <= ports.Length; i++)//Пробегаемся по массиву портов
                {
                    portSearched[iterationSearch] = new SerialPort(ports[i], 9600);//Элементу массива найденных портов, присваиваем каждый порт и проверяем его 
                    if (ArduinoDetected())
                    {
                        iterationSearch++;
                    }
                }
                
            }
            catch { }

            return portSearched;
        }

        private bool ArduinoDetected()
        {
            try
            {
                portSearched[iterationSearch].Open();//Открываем порт
                System.Threading.Thread.Sleep(2000);//таймаут пока прилетит сообщение 
                string returnMessage = portSearched[iterationSearch].ReadLine();//считываем сообщение
                portSearched[iterationSearch].Close();//закрываем порт
                if (returnMessage.Contains("It's Boot-Group Arduino"))//парсим маяк
                {
                    serialNumber[iterationSearch] = returnMessage.Substring(24, 8);//парсим идентификатор
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
