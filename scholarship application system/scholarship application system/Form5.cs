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

namespace scholarship_application_system
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            load1();
        }

        public void load1()
        {
            dbconnect connect = new dbconnect();
            connect.Connect();

            string sql = "SELECT * FROM tbl_student";
            MySqlCommand cmd = new MySqlCommand(sql, connect.dbcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            this.dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dbconnect connect = new dbconnect();
            connect.Connect();

            string select = "SELECT * FROM tbl_student where student_id LIKE '" + this.textBox1.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(select, connect.dbcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            this.dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
