using NPoco.Expressions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using RedGate.SQLCompare.Engine.Options;


namespace SINHVIEN
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S = @"Data Source=DESKTOP-2Q7653F\MSSQLSERVERD;Initial Catalog=hello;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(S);
            string query = "select * from dbo.QLSV1";
            SqlCommand cmd = new SqlCommand(query, cnn);
            List<SV> l = new List<SV>();
            cnn.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while( r.Read())
            {
                l.Add(new SV
                {

                    MSSV = r["MSSV"].ToString(),
                    Name = r["Name"].ToString(),
                    DiemTB = Convert.ToDouble(r["DiemTB"].ToString()),
                    

                }) ; 
            }
            cnn.Close();
            dataGridView1.DataSource = l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string S = @"Data Source=DESKTOP-2Q7653F\MSSQLSERVERD;Initial Catalog=hello;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(S);
            string query = "select * from dbo.SV";
            SqlDataAdapter da = new SqlDataAdapter(query,cnn);
            SqlCommand cmd = new SqlCommand(query, cnn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "select * from dbo.SQLSV1";
            dataGridView1.DataSource = DBHelper.Instance.GetRecords(query);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string S = @"Data Source=DESKTOP-2Q7653F\MSSQLSERVERD;Initial Catalog=hello;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(S);
            SqlParameter p1 = new SqlParameter("@Name", textBox1.Text);
            string query = "select * from dbo.SV where NameSV =" + "@Name";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add(p1);
            List<SV> l = new List<SV>();
            cnn.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                l.Add(new SV
                {   
                    MSSV = r["MSSV"].ToString(),
                    Name = r["Name"].ToString(),
                   // DiemTB = Convert.ToDouble(r["DiemTB"].ToString()),
                });
            }
            cnn.Close();
            dataGridView1.DataSource = l;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }

    
}
