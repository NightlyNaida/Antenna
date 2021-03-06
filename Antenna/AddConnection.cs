﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Management;

namespace Antenna
{
    public partial class AddConnection : Form
    {
        SerialPort[] ports = new SerialPort[20]; //Массив портов, куда записываются найденные адрес АС;

        WorkWithArduino workWithArduino; //Класс взаимодействия с платами Arduino
        Gamma gamma = new Gamma(); //Класс для шифрования и дешифрования данных
        WorkWithDB withDB = new WorkWithDB();//Класс для взаимодействия с базой данных
        WorkWithClient withClient = new WorkWithClient();//Класс для взаимодействия с аппратной част

        BackgroundWorker bw1 = new BackgroundWorker(); // Объект для фонового выполнения инструкций


        MySqlConnection connection = new MySqlConnection();
       

        public AddConnection(MySqlConnection mySqlConnection)

        {
            connection = mySqlConnection;
            InitializeComponent();
        }



        private void Button_Search_Click(object sender, EventArgs e)
        {
            bw1.DoWork += (ea, obj) => searchArduino();//
            bw1.RunWorkerCompleted += (ea, obj) => shwowArd();
            bw1.RunWorkerAsync();
            button_Search.Enabled = false;
            pictureBox_Load_Animation.Visible = true;
            label_CountSearched.Text = "Ищу Arduino";

        }
      
        private void searchArduino()
        {
            workWithArduino = new WorkWithArduino();
            ports = workWithArduino.LetsSearchThisShit();
        }

        private void shwowArd()
        {
            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            bool dublicateSearched = false;//флаг нахождения дубликата
            for (int i = 0; i <= workWithArduino.iterationSearch; i++)//цикл размером в количество итераций поиска платы 
            {
                foreach (DataGridViewRow str in dataGridView1.Rows)//пробегаемся по уже найденным ардуинкам
                {
                    if (str.Cells[1].Value != null)
                    {
                        if (str.Cells[1].Value.ToString() == workWithArduino.serialNumber[i])//если дубликат найден, ставим флаг нахождения дубликата и прерываем цикл поиска
                        {
                            dublicateSearched = true;
                            break;
                        }
                    }
                    else
                    {
                        dublicateSearched = false;
                    }
                }
                if (dublicateSearched == false & ports[i] != null)//если  дубликат не найден, добавляем его в таблицу
                {
                    dataGridView1.Rows.Add(ports[i].PortName, workWithArduino.serialNumber[i]);
                    ports[i] = null;
           
                }
            }
            button_Search.Enabled = true;//Возобновляем доступ к кнопке
            label_CountSearchedValue.Text = (dataGridView1.RowCount-1).ToString();//Меняем лейбел количества найденых подключений
            label_CountSearched.Text = "Найдено антенн";//Меняем подпись
            pictureBox_Load_Animation.Visible = false;//убираем анимацию загрузки
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_AddConnection.Enabled = true;
        }


        private void Button_AddConnection_Click(object sender, EventArgs e)
        {
            Main father = this.Owner as Main;
            bool searchDoublicate = false;
            foreach (DataGridViewRow dgwr in father.dataGridView_Connections.Rows)
            {
                if (dgwr.Cells[1].Value != null & dataGridView1.CurrentRow.Cells[1].Value != null)
                {
                    if (dgwr.Cells[1].Value.ToString() == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                    {
                        searchDoublicate = true;
                        break;
                    }
                }
            }

            if (searchDoublicate == false)
            {
                withDB.insertAntennaInTable("antennas", dataGridView1.CurrentRow.Cells[1].Value.ToString().Replace("\r", ""),
                "name", dataGridView1.CurrentRow.Cells[0].Value.ToString(), "1", withClient.getProcessorId(), connection);
                father.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такое подключение уже имеется");
            }
        }
    }
}
