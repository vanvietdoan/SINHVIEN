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

namespace SINHVIEN
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             cnd = cnn.CreateCommand();
            cnd.CommandText = "delete from dbo.QLSV1 where MSSV = '"+tb_MSSV.Text+"' ";
            cnd.ExecuteNonQuery();
            loaddata();
            
        }
        
        SqlConnection cnn;
        SqlCommand cnd;
        string str= @"Data Source=DESKTOP-2Q7653F\MSSQLSERVERD;Initial Catalog=hello;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
         
        void loaddata()
        {
            cnd = cnn.CreateCommand();
            cnd.CommandText = "select * from dbo.QLSV1";
            adapter.SelectCommand= cnd;
            table.Clear();
            adapter.Fill(table); 

            dataGridView1.DataSource=table;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
             cnn = new SqlConnection(str);
             cnn.Open();
             loaddata();
            //string query = "select * from dbo.QLSV1";
            //dataGridView1.DataSource = DataQLSV.Instance.GetRecords(query);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MSSV.ReadOnly= true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            tb_MSSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tB_Name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tb_LopSH.Text= dataGridView1.Rows[i].Cells[2].Value.ToString();
            tb_NamSinh.Text= dataGridView1.Rows[i].Cells[3].Value.ToString();
            tb_DTB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            if (dataGridView1.Rows[i].Cells[5].Value.ToString() =="Nam")
                radioButton_Nam.Checked = true;
            if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Nu")
                radioButton_Nu.Checked = true;
           // checkBox_AnhThe = Convert.ToBoolean( dataGridView1.Rows[i].Cells[6].Value.ToString());




        }
        int NS ;
        double DiemTB;
        Boolean AT= false,CCCD=false,CMND=false;
        string Gender;


        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            cnd = cnn.CreateCommand();
            cnd.CommandText = "insert into dbo.QLSV1 values('"+tb_MSSV.Text+"', N'"+tB_Name.Text+"' , '"+tb_LopSH.Text+"', '"+NS+"','"+DiemTB+"', '"+Gender+"', '"+AT+ "','"+CCCD+ "','"+CMND+"')";
            cnd.ExecuteNonQuery();
            loaddata();
        }

        private void tb_DTB_TextChanged(object sender, EventArgs e)
        {
             DiemTB = Convert.ToDouble(tb_DTB.Text);
        }

        private void tb_NamSinh_TextChanged(object sender, EventArgs e)
        {
            NS = int.Parse(tb_NamSinh.Text);
        }

        private void checkBox_AnhThe_CheckedChanged(object sender, EventArgs e)
        {
            AT = true;
        }

        private void checkBox_CCCD_CheckedChanged(object sender, EventArgs e)
        {
            CCCD = true;
        }

        private void checkBox_CMND_CheckedChanged(object sender, EventArgs e)
        {
            CMND = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cnd = cnn.CreateCommand();
            cnd.CommandText = "update dbo.QLSV1 set MSSV='" + tb_MSSV.Text + "', Name = N'" + tB_Name.Text + "' , LopSH='" + tb_LopSH.Text + "',NamSinh ='" + NS + "',DiemTB ='" + DiemTB + "',GioiTinh= '" + Gender + "',AnhThe= '" + AT + "',CCCD='" + CCCD + "',CMND='" + CMND + "' where MSSV='"+tb_MSSV.Text+"' " ;
            cnd.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // khoi tao
            tb_MSSV.ReadOnly= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select * from dbo.QLSV1";
            dataGridView1.DataSource = DataQLSV.Instance.GetRecords(query);
        }

        private void radioButton_Nam_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Nam";
        }

        private void radioButton_Nu_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Nu";
        }
    }
}
