    using System;
    using System.IO.Ports;

    namespace Antenna
    {
        class WorkWithArduino
        {
            public bool arduinoFound = false;
            SerialPort [] portSearched = new SerialPort [20] ;
            public string [] serialNumber = new string [20];
            public int iterationSearch = 0;

        public bool checkConnection(string COM, string id)
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = COM;

            try
            {
                serialPort.Open();
            }
            catch
            {
                return false;
            }
            serialPort.Write("hau");//Посылаем сообщение на порт 
            string returnMessage = "";
            System.Threading.Thread.Sleep(2500);
            if (portSearched[iterationSearch].BytesToRead > 0)
            {
                returnMessage = portSearched[iterationSearch].ReadLine();//считываем сообщение
            }
            serialPort.Close();//закрываем порт

            if (returnMessage.Contains("It's Boot-Group Arduino"))//парсим маяк
            {
                serialNumber[iterationSearch] = returnMessage.Substring(24, returnMessage.Length - 24);//парсим идентификатор
                return true;
            }
            else
            {
                return false;
            }

        }
                
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
                    portSearched[iterationSearch].Write("hau");//Посылаем сообщение на порт 
                    string returnMessage ="";
                    System.Threading.Thread.Sleep(2500);
                    if (portSearched[iterationSearch].BytesToRead > 0)
                    {
                        returnMessage = portSearched[iterationSearch].ReadLine();//считываем сообщение
                    }
                    portSearched[iterationSearch].Close();//закрываем порт

                    if (returnMessage.Contains("It's Boot-Group Arduino"))//парсим маяк
                    {
                        serialNumber[iterationSearch] = returnMessage.Substring(24, returnMessage.Length - 24);//парсим идентификатор
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
