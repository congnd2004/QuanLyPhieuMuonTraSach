namespace C_PRL.home_page
{
    partial class book_manager
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
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            datastatis = new DataGridView();
            panel5 = new Panel();
            label3 = new Label();
            txtgia = new TextBox();
            txtTensach = new TextBox();
            cmbtentacgia = new ComboBox();
            label19 = new Label();
            txtsotrang = new TextBox();
            txtsoluong = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtmasach = new TextBox();
            btnsua = new Button();
            btnxoa = new Button();
            btnlammoi = new Button();
            btnthem = new Button();
            paner2 = new Panel();
            dtgtinhtrang = new DataGridView();
            panel2 = new Panel();
            dtgsach = new DataGridView();
            label2 = new Label();
            txttimkiemsach = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datastatis).BeginInit();
            panel5.SuspendLayout();
            paner2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgtinhtrang).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Tai Le", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Image = Properties.Resources.icons8_book_401;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(599, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 95);
            label1.TabIndex = 0;
            label1.Text = "       Book Managerment";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(datastatis);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(paner2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1557, 923);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Picture11;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(1096, 643);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 269);
            panel3.TabIndex = 8;
            // 
            // datastatis
            // 
            datastatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datastatis.Location = new Point(641, 652);
            datastatis.Name = "datastatis";
            datastatis.RowHeadersWidth = 51;
            datastatis.RowTemplate.Height = 29;
            datastatis.Size = new Size(367, 246);
            datastatis.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtgia);
            panel5.Controls.Add(txtTensach);
            panel5.Controls.Add(cmbtentacgia);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(txtsotrang);
            panel5.Controls.Add(txtsoluong);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(txtmasach);
            panel5.Controls.Add(btnsua);
            panel5.Controls.Add(btnxoa);
            panel5.Controls.Add(btnlammoi);
            panel5.Controls.Add(btnthem);
            panel5.Location = new Point(1030, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(504, 565);
            panel5.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 255, 255);
            label3.Location = new Point(14, 306);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 17;
            label3.Text = "giá tiền";
            // 
            // txtgia
            // 
            txtgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtgia.Location = new Point(149, 295);
            txtgia.Multiline = true;
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(337, 39);
            txtgia.TabIndex = 16;
            txtgia.KeyPress += txtgia_KeyPress;
            // 
            // txtTensach
            // 
            txtTensach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTensach.Location = new Point(149, 90);
            txtTensach.Multiline = true;
            txtTensach.Name = "txtTensach";
            txtTensach.Size = new Size(335, 39);
            txtTensach.TabIndex = 15;
            // 
            // cmbtentacgia
            // 
            cmbtentacgia.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbtentacgia.FormattingEnabled = true;
            cmbtentacgia.Location = new Point(149, 353);
            cmbtentacgia.Name = "cmbtentacgia";
            cmbtentacgia.Size = new Size(339, 45);
            cmbtentacgia.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(192, 255, 255);
            label19.Location = new Point(11, 363);
            label19.Name = "label19";
            label19.Size = new Size(120, 28);
            label19.TabIndex = 13;
            label19.Text = "tên tác giả";
            // 
            // txtsotrang
            // 
            txtsotrang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsotrang.Location = new Point(149, 233);
            txtsotrang.Multiline = true;
            txtsotrang.Name = "txtsotrang";
            txtsotrang.Size = new Size(337, 39);
            txtsotrang.TabIndex = 7;
            txtsotrang.KeyPress += txtsotrang_KeyPress;
            // 
            // txtsoluong
            // 
            txtsoluong.Cursor = Cursors.IBeam;
            txtsoluong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsoluong.Location = new Point(149, 160);
            txtsoluong.Multiline = true;
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(337, 39);
            txtsoluong.TabIndex = 6;
            txtsoluong.KeyPress += txtsoluong_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(192, 255, 255);
            label18.Location = new Point(11, 244);
            label18.Name = "label18";
            label18.Size = new Size(95, 28);
            label18.TabIndex = 12;
            label18.Text = "số trang";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(192, 255, 255);
            label17.Location = new Point(10, 171);
            label17.Name = "label17";
            label17.Size = new Size(99, 28);
            label17.TabIndex = 11;
            label17.Text = "số lượng";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(192, 255, 255);
            label16.Location = new Point(11, 101);
            label16.Name = "label16";
            label16.Size = new Size(98, 28);
            label16.TabIndex = 10;
            label16.Text = "tên sách";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(192, 255, 255);
            label15.Location = new Point(14, 37);
            label15.Name = "label15";
            label15.Size = new Size(96, 28);
            label15.TabIndex = 9;
            label15.Text = "mã sách";
            // 
            // txtmasach
            // 
            txtmasach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtmasach.Location = new Point(149, 26);
            txtmasach.Multiline = true;
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(337, 39);
            txtmasach.TabIndex = 4;
            // 
            // btnsua
            // 
            btnsua.BackgroundImage = Properties.Resources.icons8_computer_support_96__1_;
            btnsua.BackgroundImageLayout = ImageLayout.Zoom;
            btnsua.FlatStyle = FlatStyle.Flat;
            btnsua.ForeColor = Color.Transparent;
            btnsua.Location = new Point(277, 427);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(142, 57);
            btnsua.TabIndex = 3;
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackgroundImage = Properties.Resources.icons8_trash_100;
            btnxoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnxoa.FlatStyle = FlatStyle.Flat;
            btnxoa.ForeColor = Color.Transparent;
            btnxoa.Location = new Point(277, 490);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(142, 60);
            btnxoa.TabIndex = 2;
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.BackgroundImage = Properties.Resources.icons8_insert_page_96;
            btnlammoi.BackgroundImageLayout = ImageLayout.Zoom;
            btnlammoi.FlatStyle = FlatStyle.Flat;
            btnlammoi.ForeColor = Color.Transparent;
            btnlammoi.Location = new Point(78, 490);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(142, 60);
            btnlammoi.TabIndex = 1;
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnthem
            // 
            btnthem.BackgroundImage = Properties.Resources.icons8_insert_column_right_961;
            btnthem.BackgroundImageLayout = ImageLayout.Zoom;
            btnthem.FlatStyle = FlatStyle.Flat;
            btnthem.ForeColor = Color.Transparent;
            btnthem.Location = new Point(78, 427);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(142, 57);
            btnthem.TabIndex = 0;
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // paner2
            // 
            paner2.BorderStyle = BorderStyle.Fixed3D;
            paner2.Controls.Add(dtgtinhtrang);
            paner2.Location = new Point(15, 643);
            paner2.Name = "paner2";
            paner2.Size = new Size(530, 266);
            paner2.TabIndex = 1;
            // 
            // dtgtinhtrang
            // 
            dtgtinhtrang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgtinhtrang.Location = new Point(11, 7);
            dtgtinhtrang.Name = "dtgtinhtrang";
            dtgtinhtrang.RowHeadersWidth = 51;
            dtgtinhtrang.RowTemplate.Height = 29;
            dtgtinhtrang.Size = new Size(512, 252);
            dtgtinhtrang.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dtgsach);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txttimkiemsach);
            panel2.Location = new Point(15, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 567);
            panel2.TabIndex = 0;
            // 
            // dtgsach
            // 
            dtgsach.AllowUserToAddRows = false;
            dtgsach.AllowUserToDeleteRows = false;
            dtgsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgsach.Location = new Point(11, 57);
            dtgsach.Name = "dtgsach";
            dtgsach.ReadOnly = true;
            dtgsach.RowHeadersWidth = 51;
            dtgsach.RowTemplate.Height = 29;
            dtgsach.Size = new Size(961, 503);
            dtgsach.TabIndex = 3;
            dtgsach.CellClick += dtgsach_CellClick_1;
            // 
            // label2
            // 
            label2.ForeColor = Color.Transparent;
            label2.Image = Properties.Resources.icons8_search_24__1_;
            label2.Location = new Point(672, 13);
            label2.Name = "label2";
            label2.Size = new Size(49, 38);
            label2.TabIndex = 2;
            // 
            // txttimkiemsach
            // 
            txttimkiemsach.Location = new Point(727, 13);
            txttimkiemsach.Multiline = true;
            txttimkiemsach.Name = "txttimkiemsach";
            txttimkiemsach.Size = new Size(245, 38);
            txttimkiemsach.TabIndex = 1;
            txttimkiemsach.TextChanged += txttimkiemsach_TextChanged_1;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icons8_insert_page_96;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(172, 307);
            button3.Name = "button3";
            button3.Size = new Size(59, 54);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.icons8_computer_support_96__1_;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(268, 249);
            button4.Name = "button4";
            button4.Size = new Size(59, 54);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.icons8_trash_100;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(268, 308);
            button5.Name = "button5";
            button5.Size = new Size(59, 54);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(152, 38);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(196, 25);
            textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(152, 78);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(196, 25);
            textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(152, 119);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(196, 25);
            textBox10.TabIndex = 14;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(152, 162);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(196, 25);
            textBox11.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(192, 255, 255);
            label9.Location = new Point(30, 42);
            label9.Name = "label9";
            label9.Size = new Size(68, 18);
            label9.TabIndex = 12;
            label9.Text = "mã sách";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(192, 255, 255);
            label10.Location = new Point(30, 85);
            label10.Name = "label10";
            label10.Size = new Size(73, 18);
            label10.TabIndex = 17;
            label10.Text = "Tên sách";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(192, 255, 255);
            label11.Location = new Point(30, 126);
            label11.Name = "label11";
            label11.Size = new Size(71, 18);
            label11.TabIndex = 18;
            label11.Text = "số lương";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(192, 255, 255);
            label12.Location = new Point(30, 169);
            label12.Name = "label12";
            label12.Size = new Size(69, 18);
            label12.TabIndex = 19;
            label12.Text = "số trang";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(192, 255, 255);
            label13.Location = new Point(30, 210);
            label13.Name = "label13";
            label13.Size = new Size(86, 18);
            label13.TabIndex = 20;
            label13.Text = "tên tác giả";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 28);
            comboBox1.TabIndex = 21;
            // 
            // book_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "book_manager";
            Size = new Size(1577, 973);
            Load += book_manager_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datastatis).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            paner2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgtinhtrang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel paner2;
        private Panel panel2;
        private Label label2;
        private TextBox txttimkiemsach;
        private Button button5;
        private Button button4;
        private Button button3;
        private ComboBox comboBox1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Panel panel5;
        private Button btnsua;
        private Button btnxoa;
        private Button btnlammoi;
        private Button btnthem;
        private TextBox txtsotrang;
        private TextBox txtsoluong;
        private TextBox txtmasach;
        private Label label15;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private ComboBox cmbtentacgia;
        private DataGridView dtgsach;
        private DataGridView dtgtinhtrang;
        private TextBox txtTensach;
        private DataGridView datastatis;
        private Panel panel3;
        private Reader_manager reader_manager1;
        private TextBox txtgia;
        private Label label3;
    }
}
