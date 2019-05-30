
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Data;


namespace Antenna
{
    class WorkWithDB
    {
        //метод подключения к базе
        public  MySqlConnection ConnectToBase(string host, int port, string database, string username, string password)
        {
            //host - адрес подключения port - порт подключения database - название базы данных 
            //username - имя пользователя password - пароль пользователя


            //формирование строки запроса в типе string
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            //создание экземпляра соединения
            MySqlConnection conn = new MySqlConnection(connString);
           
            return conn;
        }

        //метод проверки доступ сервера
        public string ConnectionStatus(string adress)
        {
            string pingt; //время задержки
            string status; //статус подключения
            string fullstr; //строка, которая вернется после выполнения метода

            Ping ping = new System.Net.NetworkInformation.Ping();
            PingReply pingReply = ping.Send(adress);

            if (pingReply.Status != IPStatus.TimedOut)//начало опроса сервера и формирование итоговой строки
            {
                status = pingReply.Status.ToString();
                pingt = pingReply.RoundtripTime.ToString();
                fullstr = "Статус: " + status + " Пинг: " + pingt; 
            }

            else
            {
                fullstr = "Сервер недоступен";
            }

            return fullstr;
        }


        public DataTable exportFromBase(string select, string from, string where,  MySqlConnection connection)
        {
            string sql = "SELECT " + select +"FROM " + from + where  + ";";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            return dt;
        }

        public void deleteRowInTable(string from, string where, MySqlConnection connection)
        {

            string sql = "DELETE FROM " + from + " WHERE(" + where + ");";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void updateRowInTable(string from, string set, string where, MySqlConnection connection)
        {

            string sql = "UPDATE " + from +" SET "+ set + " WHERE(" + where + ");";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }


    }
}

