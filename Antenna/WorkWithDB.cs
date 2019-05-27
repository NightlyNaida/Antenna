using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.IO;
using System.Data.Common;
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

        private static MySqlDataReader QueryEmployee(MySqlConnection conn)
        {
            string sql = "SELECT id_model_of_equip, m_equip, name_of_model_id, types_id,count_model FROM model_of equip;";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
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

        public void insertIntoTabelEquip(string model, string name_model, string type_model, string count_model, MySqlConnection connection)
        {
            string sql = "insert_model_procedure";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@name_model", name_model);
            cmd.Parameters.AddWithValue("@type_model", type_model);
            cmd.Parameters.AddWithValue("@count_model_fromapp", count_model);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
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

