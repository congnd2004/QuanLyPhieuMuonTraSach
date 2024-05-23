namespace C_PRL.home_page
{
    partial class Reader_manager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dtgdocgia = new DataGridView();
            btnxoa = new Button();
            btnsua = new Button();
            btnnew = new Button();
            btnthem = new Button();
            panel2 = new Panel();
            label9 = new Label();
            txtphone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            datecard = new DateTimePicker();
            datebird = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtdoituong = new TextBox();
            txtdiachi = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            textcode = new TextBox();
            label2 = new Label();
            txtseach = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgdocgia).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dtgdocgia);
            panel1.Controls.Add(btnxoa);
            panel1.Controls.Add(btnsua);
            panel1.Controls.Add(btnnew);
            panel1.Controls.Add(btnthem);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtseach);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(14, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1542, 937);
            panel1.TabIndex = 0;

            // 
            // dtgdocgia
            // 
            dtgdocgia.AllowUserToAddRows = false;
            dtgdocgia.BackgroundColor = SystemColors.ButtonFace;
            dtgdocgia.BorderStyle = BorderStyle.Fixed3D;
            dtgdocgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgdocgia.Location = new Point(17, 136);
            dtgdocgia.Name = "dtgdocgia";
            dtgdocgia.RowHeadersVisible = false;
            dtgdocgia.RowHeadersWidth = 51;
            dtgdocgia.RowTemplate.Height = 29;
            dtgdocgia.Size = new Size(1067, 765);
            dtgdocgia.TabIndex = 10;
            dtgdocgia.CellClick += dtgdocgia_CellClick;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = Properties.Resources.icons8_trash_1002;
            btnxoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.ForeColor = Color.Transparent;
            btnxoa.Location = new Point(1326, 688);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(158, 77);
            btnxoa.TabIndex = 9;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = Properties.Resources.icons8_computer_support_96__1_2;
            btnsua.BackgroundImageLayout = ImageLayout.Zoom;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.ForeColor = Color.Transparent;
            btnsua.Location = new Point(1326, 562);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(158, 77);
            btnsua.TabIndex = 8;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnnew
            // 
            btnnew.BackgroundImage = Properties.Resources.icons8_insert_page_962;
            btnnew.BackgroundImageLayout = ImageLayout.Zoom;
            btnnew.FlatStyle = FlatStyle.Flat;
            btnnew.ForeColor = Color.Transparent;
            btnnew.Location = new Point(1118, 688);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(162, 77);
            btnnew.TabIndex = 7;
            btnnew.UseVisualStyleBackColor = true;
            btnnew.Click += btnnew_Click;
            // 
            // btnthem
            // 
            btnthem.BackgroundImage = Properties.Resources.icons8_insert_column_right_965;
            btnthem.BackgroundImageLayout = ImageLayout.Zoom;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.ForeColor = Color.Transparent;
            btnthem.Location = new Point(1118, 562);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(162, 77);
            btnthem.TabIndex = 6;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtphone);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(datecard);
            panel2.Controls.Add(datebird);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtdoituong);
            panel2.Controls.Add(txtdiachi);
            panel2.Controls.Add(txtname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textcode);
            panel2.Location = new Point(1118, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 442);
            panel2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(192, 255, 255);
            label9.Location = new Point(26, 208);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 13;
            label9.Text = "số điện thoại";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(149, 201);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(204, 27);
            txtphone.TabIndex = 12;
            txtphone.KeyPress += txtphone_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(192, 255, 255);
            label8.Location = new Point(26, 379);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 11;
            label8.Text = "ngày đăng kí";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(192, 255, 255);
            label7.Location = new Point(30, 313);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 10;
            label7.Text = "ngày sinh";
            // 
            // datecard
            // 
            datecard.Format = DateTimePickerFormat.Short;
            datecard.Location = new Point(149, 374);
            datecard.Name = "datecard";
            datecard.Size = new Size(204, 27);
            datecard.TabIndex = 9;
            // 
            // datebird
            // 
            datebird.Format = DateTimePickerFormat.Short;
            datebird.Location = new Point(149, 308);
            datebird.Name = "datebird";
            datebird.Size = new Size(204, 27);
            datebird.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 255, 255);
            label6.Location = new Point(29, 262);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 7;
            label6.Text = "đối tượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 255, 255);
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 6;
            label5.Text = "địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 255, 255);
            label4.Location = new Point(26, 94);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên độc giả";

            // 
            // txtdoituong
            // 
            txtdoituong.Location = new Point(149, 259);
            txtdoituong.Name = "txtdoituong";
            txtdoituong.Size = new Size(204, 27);
            txtdoituong.TabIndex = 4;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(149, 146);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(204, 27);
            txtdiachi.TabIndex = 3;
            // 
            // txtname
            // 
            txtname.Location = new Point(149, 87);
            txtname.Name = "txtname";
            txtname.Size = new Size(204, 27);
            txtname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 255, 255);
            label3.Location = new Point(18, 31);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã độc giả";
            // 
            // textcode
            // 
            textcode.Location = new Point(149, 31);
            textcode.Name = "textcode";
            textcode.Size = new Size(204, 27);
            textcode.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(728, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Seach";
            // 
            // txtseach
            // 
            txtseach.Location = new Point(796, 75);
            txtseach.Multiline = true;
            txtseach.Name = "txtseach";
            txtseach.Size = new Size(288, 40);
            txtseach.TabIndex = 1;
            txtseach.TextChanged += txtseach_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Image = Properties.Resources.icons8_read_online_483;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(558, -11);
            label1.Name = "label1";
            label1.Size = new Size(362, 60);
            label1.TabIndex = 1;
            label1.Text = "             Reader managerment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reader_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Reader_manager";
            Size = new Size(1577, 973);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgdocgia).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtseach;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox textcode;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtdoituong;
        private TextBox txtdiachi;
        private TextBox txtname;
        private Label label8;
        private Label label7;
        private DateTimePicker datecard;
        private DateTimePicker datebird;
        private Button btnxoa;
        private Button btnsua;
        private Button btnnew;
        private Button btnthem;
        private Label label9;
        private TextBox txtphone;
        private DataGridView dtgdocgia;
    }
}
