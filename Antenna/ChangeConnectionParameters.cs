using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace Antenna
{
    public partial class ChangeConnectionParameters : Form
    {
        
        public ChangeConnectionParameters()
        {
            InitializeComponent();
            
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            string formatedAdress;
            formatedAdress = textBox_IPServer.Text.Replace("_", "");
            formatedAdress = formatedAdress.Replace('"'.ToString(), "");
            formatedAdress = formatedAdress.Replace(",", ".");
            if (String.IsNullOrWhiteSpace(textBox_DBMS_Port.Text) != true & String.IsNullOrWhiteSpace(textBox_NameBD.Text) != true & IsAddressValid(formatedAdress) == true)
            {
                Form1 father = this.Owner as Form1;
                father.serverAdress = textBox_IPServer.Text;
                father.serverPort = textBox_DBMS_Port.Text;
                father.serverDataBaseName = textBox_NameBD.Text;
                father.serverAdressNonCorrect = textBox_IPServer.Text;
                father.connectionParametersIsChanged = true;

                father.changeStatusLabel.Text = "Параметры подключения изменены";
                father.changeStatusLabel.ForeColor = Color.Orange;
                father.statusStrip1.Items.Add(father.changeStatusLabel);

                father.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Одно из полей пустое, проверьте корректность ввода!", "Внимание!");
            }

        

        }

        private void ChangeConnectionParameters_Load(object sender, EventArgs e)
        {
            Form1 father = this.Owner as Form1;

            textBox_IPServer.Mask = "###.###.###.###";
            textBox_IPServer.ValidatingType = typeof(System.Net.IPAddress);

            textBox_IPServer.Text = father.serverAdressNonCorrect;
            textBox_DBMS_Port.Text = father.serverPort;
            textBox_NameBD.Text = father.serverDataBaseName;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsAddressValid(string addrString)
        {
            IPAddress address;
            return IPAddress.TryParse(addrString, out address);
        }
    }
}
