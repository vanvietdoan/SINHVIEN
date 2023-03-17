using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINHVIEN
{
   
    public partial class Form2 : Form
    {
        public string store;
        public delegate void EditData(string id, string ten, string lop, bool gioitinh, double tb, DateTime ngaysinh, bool anhh, bool hcb, bool cc);
        public EditData Sender;
        public Form2()
        {
            InitializeComponent();
            //store= null;
            //InitializeComponent();

            
        }
        public Form2(string id)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            Form1 d=new Form1();
            SV svx = new SV (){ MSSV = MaSo, Name = Ten, LopSH = Lop, NamSinh = SN, DiemTB = Diem, GioiTinh = GT, AnhThe = AT, CCCD = cccd, CMND = cmnd };
            if(QLSV.Instance.TimMSSV(MaSo) != true)
            {
                CSDL.Instance.AddSV(svx);
            }
            else
            {
                //update
            }
  
            this.Hide();
           
        }

        public string MaSo;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           MaSo= textBox1.Text;
        }

        public string Ten;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Ten = textBox3.Text;
        }

        public String Lop;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            Lop= textBox4.Text;
        }

        public int SN;

        private void NS_TextChanged(object sender, EventArgs e)
        {
           string a = NS.Text;
           
            SN = int.Parse(a);

        }
        public double Diem;
        private void DTB_TextChanged(object sender, EventArgs e)
        {
            string DiemTB= DTB.Text;
            Diem = double.Parse(DiemTB);
        }
        public string GT;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GT = "Nam";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GT = "Nu";
        }

        public bool AT, cccd,cmnd;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cmnd= true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cccd= true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AT = true;
        }
    }
}
