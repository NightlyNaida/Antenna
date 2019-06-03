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
using System.Management;

namespace Antenna
{
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection();
        WorkWithDB workWithDB = new WorkWithDB();
        WorkWithClient WithClient = new WorkWithClient();
        BackgroundWorker bw = new BackgroundWorker();
        DataTable data;
        WorkWithArduino WithArduino = new WorkWithArduino();
        public Main(MySqlConnection mySqlConnection)
        {
            connection = mySqlConnection;
            InitializeComponent();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
   
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddConnection addConnection = new AddConnection(connection);
            addConnection.Owner = this;
            addConnection.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_Connections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadingTable()
        {
            Invoke((MethodInvoker)delegate
            {
                dataGridView_Connections.Visible = false;
                pictureBox_Load_Animation.Visible = true;
                label_load_Animation.Visible = true;
            });
            const string quote = "\"";
            string where = quote + WithClient.getProcessorId() + quote;
            data = workWithDB.takeFromBase("adress_antenna, idefinder_antenna", "base_antenna.antennas", where, connection);
        }

        private void updateTable()
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dataGridView_Connections.Rows.Add();
            }
            {

            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dataGridView_Connections.Rows[i].Cells[0].Value = data.Rows[i][0].ToString();
                dataGridView_Connections.Rows[i].Cells[1].Value = data.Rows[i][1].ToString();
            }
            dataGridView_Connections.Visible = true;
            pictureBox_Load_Animation.Visible = false;
            label_load_Animation.Visible = false;
            checkingConnections();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            bw.DoWork += (ea, obj) => loadingTable();
            bw.RunWorkerCompleted += (ea, obj) => updateTable();
            bw.RunWorkerAsync();
        }

        private void checkingConnections()
        {
            
BackgroundWorker[] bw = new BackgroundWorker[dataGridView_Connections.Rows.Count];
            for (int i = 0; i < dataGridView_Connections.Rows.Count - 1; i++)
            {
                dataGridView_Connections.Rows[i].Cells[2].Value = "Проверяю...";
                bw[i] = new BackgroundWorker();
                bw[i].DoWork += (ea, obj) =>
                {
                if (dataGridView_Connections.Rows[i].Cells[0].Value != null & dataGridView_Connections.Rows[i].Cells[1].Value != null)
                    {
                        if (WithArduino.checkConnection(dataGridView_Connections.Rows[i].Cells[0].Value.ToString(), dataGridView_Connections.Rows[i].Cells[1].Value.ToString()) == true)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                dataGridView_Connections.Rows[i].Cells[2].Value = "Есть соединение";
                            });
                        }

                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                dataGridView_Connections.Rows[i].Cells[2].Value = "Нет соединения";
                            });
                        }
                    }
                };
                bw[i].RunWorkerAsync();

            }
        }
    }
}
