using System.Data.SqlClient;

namespace SINHVIEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //dataGridView1.DataSource = CSDL.Instance.dt;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = CSDL.Instance.TimSV("18CTT1", 1);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = CSDL.Instance.TimSV("18CTT2", 1);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.DataSource = CSDL.Instance.TimSV("18CTT3", 1);
            }
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = CSDL.Instance.dt;
            }
        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string x;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           x= textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== null) {
                MessageBox.Show("Nhap lai!");
            }

            dataGridView1.DataSource = CSDL.Instance.TimSV(x,0);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form2 d = new Form2();
            d.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                string ms;
                foreach(DataGridViewRow row in dataGridView1.SelectedRows) 
                {
                    ms = row.Cells["MSSV"].Value.ToString();
                    CSDL.Instance.DeleteSV(ms);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
   
                if (dataGridView1.Rows.Count > 0)
                {
                    string ms;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        ms = row.Cells["MSSV"].Value.ToString();
                        CSDL.Instance.DeleteSV(ms);
                    }
                }
                Form2 d = new Form2();
                d.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            List<SV> t = new List<SV>();
            if (comboBox2.SelectedIndex == 0) ///MSSV
            {
               // CSDL.Instance.SortByMSSV();
                dataGridView1.DataSource = CSDL.Instance.Sort(t, QLSV.Instance.CompareMSSV);
            }
            if (comboBox2.SelectedIndex == 1) //name
            {
                dataGridView1.DataSource = CSDL.Instance.Sort(t, QLSV.Instance.CompareName);
            }
            if (comboBox2.SelectedIndex == 2) // Lop
            {
                dataGridView1.DataSource = CSDL.Instance.Sort(t, QLSV.Instance.CompareLopSH);
            }
            if (comboBox2.SelectedIndex == 3)// nam sinh
            {
                dataGridView1.DataSource = CSDL.Instance.Sort(t, QLSV.Instance.CompareNamSinh);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from dbo.SQLSV1";
            dataGridView1.DataSource = CSDL.Instance.GetRecords(query);
        }
    }
}