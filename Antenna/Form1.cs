using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.IO;

namespace Antenna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //////////объявление переменных//////////
        public string serverAdress;//переменная адреса подключения, корректируется в ходе выполнения
        public string serverPort;//порт СУБД
        public string serverDataBaseName; //имя Базы
        public string serverAdressNonCorrect; //имя Базы не корректируется

        public bool connectionParametersIsChanged = false;// флаг смены параметров подключения
        public bool trueAuthorization; //флаг статуса авторизации
        ////////////////////
        

        //////////объявление объектов//////////
        BackgroundWorker firstBW;//компоненты фонового выполнения кода

        private ToolStripStatusLabel connectionStatusLabel = new ToolStripStatusLabel();// экземпляр ячейки в statusstrip(статус соединения)

        public ToolStripStatusLabel changeStatusLabel = new ToolStripStatusLabel();// экземпляр ячейки в statusstrip(изменение параметров подключени)
        ////////////////////
        

        //////////объявление классов//////////
        WorkWithDB wwDB = new WorkWithDB();//класс описывающий взаимодействие с сервером и СУБД

        MySqlConnection connection = new MySqlConnection();//Класс соединения с БД

        SavedParameters savedParameters = new SavedParameters();//класс взаимодействия с JSON файлом
        ////////////////////


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_LetsConnection_click(object sender, EventArgs e)
        {
            label_TryConnection.Visible = true;
            pictureBox_LoadingAnimation.Visible = true;
            if (String.IsNullOrWhiteSpace(login_textBox.Text) || String.IsNullOrWhiteSpace(password_textBox.Text))//проверка полей ввода на пустоту
            {
                {
                    MessageBox.Show("Ошибка: Одно из или оба поля ввода пустые."); //если поля пустые, то не пускаю дальше
                    label_TryConnection.Visible = false;
                    pictureBox_LoadingAnimation.Visible = false;
                }
            }

            else
            {

                if (connectionParametersIsChanged == true) //Если параметры соединения были изменены, то предложу сохранить их
                {
                    if (MessageBox.Show("Сохранить новые параметры подключения?", "Указаны новые параметры подключения", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        savedParameters.connectionParameters = new ConnectionParameter();//дочерний субкласс взаимодействия с JSON файлом, который описывает поля для сохранения;
                        savedParameters.connectionParameters.IP = serverAdress;
                        savedParameters.connectionParameters.Port = serverPort;
                        savedParameters.connectionParameters.NameDB = serverDataBaseName;
                        savedParameters.connectionParameters.IPNonCorrect = serverAdress;
                        string serialized = JsonConvert.SerializeObject(savedParameters);//сериализация в формат JSON
                        File.Delete("parameters.json");//удаление старого файла настроек; !!!!!!!ПЕРЕДЕЛАТЬ!!!!!!!!
                        File.AppendAllText("parameters.json", serialized);


                    }
                }


                firstBW = new BackgroundWorker();
                firstBW.DoWork += (obj, ea) => ConnectionToBase(serverAdress, Convert.ToInt32(serverPort), serverDataBaseName,
                login_textBox.Text, password_textBox.Text); //Асинхронный вызов метода проверки доступности сервера
                firstBW.RunWorkerCompleted += (obj, ea) => OpeningMainForm(connection);
                firstBW.RunWorkerAsync();//окно открывается после ошибки соединения 

            }
        }

        private void OpeningMainForm(MySqlConnection mySqlConnection)
        {
            if (trueAuthorization == true)
            {
                Main main = new Main(mySqlConnection);
                main.Show();
                this.Hide();
            }
            label_TryConnection.Visible = false;
            pictureBox_LoadingAnimation.Visible = false;
        }

        private void ConnectionToBase(string host, int port, string database, string username, string password)
        {
            connection = wwDB.ConnectToBase(host, port, database, username, password);//инициализация подключения к базе
            try
            {
                connection.Open();
                //MainWindow mainWindow = new MainWindow(conn);
                connection.Close();
                trueAuthorization = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Ошибка:" + e1.Message);
                trueAuthorization = false;
            }
        }

 


        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("parameters.json");
            string json = sr.ReadToEnd();
            SavedParameters sp = JsonConvert.DeserializeObject<SavedParameters>(json);
       
            serverAdress = sp.connectionParameters.IP;//стандартный адрес сервера базы данных
            serverAdress = serverAdress.Replace(" ", "");
            serverAdress = serverAdress.Replace("_", "");
            serverAdress = serverAdress.Replace('"'.ToString(), "");
            serverAdress = serverAdress.Replace(",",".");
            serverPort = sp.connectionParameters.Port;//стандартный порт СУБД
            serverDataBaseName = sp.connectionParameters.NameDB;//стандартное имя Базы
            serverAdressNonCorrect = sp.connectionParameters.IPNonCorrect;

            firstBW = new BackgroundWorker();
            firstBW.DoWork += (obj, ea) => PingServer(); //Асинхронный вызов метода проверки доступности сервера
            firstBW.RunWorkerAsync();


        }

        private void PingServer() //определение метода проверки соединения с сервером
        {
            connectionStatusLabel.Text = "Проверяю подключение к серверу...";
            connectionStatusLabel.Text = wwDB.ConnectionStatus(serverAdress);


            if (connectionStatusLabel.Text != "Сервер недоступен")
            {
                connectionStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                connectionStatusLabel.ForeColor = Color.Red;
            }

            statusStrip1.Items.Add(connectionStatusLabel);
        }

        private void Label_LetsChangeConnectionOptions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены в смене стандартных параметров подключеня?", "Смена параметров подключения",MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                ChangeConnectionParameters changeConnectionParameters = new ChangeConnectionParameters();
                changeConnectionParameters.Owner = this;
                changeConnectionParameters.ShowDialog();
            }
        }

        private void Password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Button_LetsConnection_click(button_LetsConnection, new EventArgs());
            }
        }
    }
}
