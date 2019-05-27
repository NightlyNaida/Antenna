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

namespace Antenna
{
    public partial class Main : Form
    {
        public Main(MySqlConnection mySqlConnection)
        {
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
            AddConnection addConnection = new AddConnection();
            addConnection.Owner = this;
            addConnection.ShowDialog();
        }
    }
}
