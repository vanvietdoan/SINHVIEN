namespace SINHVIEN
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_CMND = new System.Windows.Forms.CheckBox();
            this.checkBox_CCCD = new System.Windows.Forms.CheckBox();
            this.checkBox_AnhThe = new System.Windows.Forms.CheckBox();
            this.tb_DTB = new System.Windows.Forms.TextBox();
            this.tb_LopSH = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tb_NamSinh = new System.Windows.Forms.TextBox();
            this.tb_MSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(711, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(551, 237);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(103, 50);
            this.btn_Thêm.TabIndex = 1;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(551, 314);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 62);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(551, 413);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 54);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_CMND);
            this.groupBox2.Controls.Add(this.checkBox_CCCD);
            this.groupBox2.Controls.Add(this.checkBox_AnhThe);
            this.groupBox2.Location = new System.Drawing.Point(336, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 131);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hồ sơ";
            // 
            // checkBox_CMND
            // 
            this.checkBox_CMND.AutoSize = true;
            this.checkBox_CMND.Location = new System.Drawing.Point(21, 103);
            this.checkBox_CMND.Name = "checkBox_CMND";
            this.checkBox_CMND.Size = new System.Drawing.Size(70, 23);
            this.checkBox_CMND.TabIndex = 2;
            this.checkBox_CMND.Text = "CMND";
            this.checkBox_CMND.UseVisualStyleBackColor = true;
            this.checkBox_CMND.CheckedChanged += new System.EventHandler(this.checkBox_CMND_CheckedChanged);
            // 
            // checkBox_CCCD
            // 
            this.checkBox_CCCD.AutoSize = true;
            this.checkBox_CCCD.Location = new System.Drawing.Point(21, 69);
            this.checkBox_CCCD.Name = "checkBox_CCCD";
            this.checkBox_CCCD.Size = new System.Drawing.Size(65, 23);
            this.checkBox_CCCD.TabIndex = 1;
            this.checkBox_CCCD.Text = "CCCD";
            this.checkBox_CCCD.UseVisualStyleBackColor = true;
            this.checkBox_CCCD.CheckedChanged += new System.EventHandler(this.checkBox_CCCD_CheckedChanged);
            // 
            // checkBox_AnhThe
            // 
            this.checkBox_AnhThe.AutoSize = true;
            this.checkBox_AnhThe.Location = new System.Drawing.Point(20, 33);
            this.checkBox_AnhThe.Name = "checkBox_AnhThe";
            this.checkBox_AnhThe.Size = new System.Drawing.Size(79, 23);
            this.checkBox_AnhThe.TabIndex = 0;
            this.checkBox_AnhThe.Text = "Ảnh Thẻ";
            this.checkBox_AnhThe.UseVisualStyleBackColor = true;
            this.checkBox_AnhThe.CheckedChanged += new System.EventHandler(this.checkBox_AnhThe_CheckedChanged);
            // 
            // tb_DTB
            // 
            this.tb_DTB.Location = new System.Drawing.Point(146, 434);
            this.tb_DTB.Name = "tb_DTB";
            this.tb_DTB.Size = new System.Drawing.Size(165, 25);
            this.tb_DTB.TabIndex = 45;
            this.tb_DTB.TextChanged += new System.EventHandler(this.tb_DTB_TextChanged);
            // 
            // tb_LopSH
            // 
            this.tb_LopSH.Location = new System.Drawing.Point(146, 321);
            this.tb_LopSH.Name = "tb_LopSH";
            this.tb_LopSH.Size = new System.Drawing.Size(165, 25);
            this.tb_LopSH.TabIndex = 44;
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(146, 276);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(165, 25);
            this.tB_Name.TabIndex = 43;
            // 
            // tb_NamSinh
            // 
            this.tb_NamSinh.Location = new System.Drawing.Point(146, 375);
            this.tb_NamSinh.Name = "tb_NamSinh";
            this.tb_NamSinh.Size = new System.Drawing.Size(165, 25);
            this.tb_NamSinh.TabIndex = 42;
            this.tb_NamSinh.TextChanged += new System.EventHandler(this.tb_NamSinh_TextChanged);
            // 
            // tb_MSSV
            // 
            this.tb_MSSV.Location = new System.Drawing.Point(146, 227);
            this.tb_MSSV.Name = "tb_MSSV";
            this.tb_MSSV.Size = new System.Drawing.Size(165, 25);
            this.tb_MSSV.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(27, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "DiemTB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(27, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Năm Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(27, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "LopSH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(27, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "MSSV:";
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(27, 36);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(56, 23);
            this.radioButton_Nam.TabIndex = 12;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            this.radioButton_Nam.CheckedChanged += new System.EventHandler(this.radioButton_Nam_CheckedChanged);
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(28, 72);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(45, 23);
            this.radioButton_Nu.TabIndex = 13;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            this.radioButton_Nu.CheckedChanged += new System.EventHandler(this.radioButton_Nu_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioButton_Nu);
            this.groupBox1.Controls.Add(this.radioButton_Nam);
            this.groupBox1.Location = new System.Drawing.Point(337, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 118);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới Tính";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(694, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 117);
            this.button1.TabIndex = 48;
            this.button1.Text = "Bỏ Khóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_DTB);
            this.Controls.Add(this.tb_LopSH);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.tb_NamSinh);
            this.Controls.Add(this.tb_MSSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Thêm;
        private Button btn_Xoa;
        private Button btn_sua;
        private GroupBox groupBox2;
        private CheckBox checkBox_CMND;
        private CheckBox checkBox_CCCD;
        private CheckBox checkBox_AnhThe;
        private TextBox tb_DTB;
        private TextBox tb_LopSH;
        private TextBox tB_Name;
        private TextBox tb_NamSinh;
        private TextBox tb_MSSV;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButton_Nam;
        private RadioButton radioButton_Nu;
        private Label label6;
        private GroupBox groupBox1;
        private Button button1;
    }
}