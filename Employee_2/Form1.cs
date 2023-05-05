using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-H8KCJ9G;database=vinay;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("insert into emp values("+textBox2.Text+",'"+textBox3.Text+"','"+textBox4.Text+"',"+textBox5.Text+")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-H8KCJ9G;database=vinay;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select * from Emp", con);
            con.Open();
            SqlDataReader dataReader= cmd.ExecuteReader();
            dataGridView1.DataSource = dataReader;
            
            con.Close();

           
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-H8KCJ9G;database=vinay;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("update from Emp set Empname=@Empname,Emplocation=@Emplocation,Empage=@empage where Empid=@Empid",con);
            cmd.Parameters.AddWithValue("@Empname", textBox3);
            cmd.Parameters.AddWithValue("@Emplocation", textBox4);
            cmd.Parameters.AddWithValue("@Empage", textBox5);
            cmd.Parameters.AddWithValue("@Empid", textBox2);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-H8KCJ9G;database=vinay;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("delete from emp  where Empid=@Empid", con);
            cmd.Parameters.AddWithValue("@Empid", textBox2);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
