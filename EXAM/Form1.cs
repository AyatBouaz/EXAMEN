using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAM
{
    public partial class Form1 : Form
    {
        static string chaine = @"Data Source=DESKTOP-OFLO969\SQLEXPRESS;Initial Catalog=biblio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

 
        public Form1()
        {
            InitializeComponent();
        }

        private void exam_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }
             private void afficher_Click(object sender, EventArgs e)
            {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into ayaaa values('" + textBox2.Text + "','" + textBox1.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
            textBox2.Clear();
            textBox1.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ex_Click(object sender, EventArgs e)
        {

        }
    }
}
