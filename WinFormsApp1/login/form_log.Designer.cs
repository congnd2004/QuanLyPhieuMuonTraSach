namespace C_PRL.login
{
    partial class form_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_log));
            btn_thoat = new Button();
            panel2 = new Panel();
            label1 = new Label();
            txtpasslg = new TextBox();
            txtuserlg = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            checkpass = new CheckBox();
            btn_login = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.DarkOrange;
            btn_thoat.BackgroundImage = Properties.Resources.Close;
            btn_thoat.FlatAppearance.BorderSize = 0;
            btn_thoat.FlatStyle = FlatStyle.Flat;
            btn_thoat.Location = new Point(1279, 0);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(55, 44);
            btn_thoat.TabIndex = 1;
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtpasslg);
            panel2.Controls.Add(txtuserlg);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(checkpass);
            panel2.Controls.Add(btn_login);
            panel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(770, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 499);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(157, 51);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 15;
            label1.Text = "LOGIN IN HERE";
            // 
            // txtpasslg
            // 
            txtpasslg.ForeColor = SystemColors.ScrollBar;
            txtpasslg.Location = new Point(103, 198);
            txtpasslg.Multiline = true;
            txtpasslg.Name = "txtpasslg";
            txtpasslg.Size = new Size(195, 36);
            txtpasslg.TabIndex = 14;
            txtpasslg.Text = "password";
            txtpasslg.Enter += txtpasslg_Enter;
            txtpasslg.Leave += txtpasslg_Leave;
            // 
            // txtuserlg
            // 
            txtuserlg.ForeColor = SystemColors.ScrollBar;
            txtuserlg.Location = new Point(103, 136);
            txtuserlg.Multiline = true;
            txtuserlg.Name = "txtuserlg";
            txtuserlg.Size = new Size(195, 36);
            txtuserlg.TabIndex = 13;
            txtuserlg.Text = "user name";
            txtuserlg.Enter += txtuserlg_Enter;
            txtuserlg.Leave += txtuserlg_Leave;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(298, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(36, 36);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(298, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(36, 36);
            panel3.TabIndex = 4;
            // 
            // checkpass
            // 
            checkpass.AutoSize = true;
            checkpass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkpass.ForeColor = Color.Blue;
            checkpass.Location = new Point(103, 254);
            checkpass.Name = "checkpass";
            checkpass.Size = new Size(139, 24);
            checkpass.TabIndex = 3;
            checkpass.Text = "show password";
            checkpass.UseVisualStyleBackColor = true;
            checkpass.CheckedChanged += checkpass_CheckedChanged;
            // 
            // btn_login
            // 
            btn_login.ForeColor = Color.Gray;
            btn_login.Location = new Point(157, 304);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(117, 57);
            btn_login.TabIndex = 2;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Baskerville Old Face", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(578, 36);
            label3.Name = "label3";
            label3.Size = new Size(587, 92);
            label3.TabIndex = 12;
            label3.Text = "Thư Viện Xanh ";
    
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlText;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1333, 850);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
   
            // 
            // form_log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1333, 850);
            Controls.Add(panel2);
            Controls.Add(btn_thoat);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form_log";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_thoat;
        private Panel panel2;
        private CheckBox checkpass;
        private Button btn_login;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtpasslg;
        private TextBox txtuserlg;
        private Label label1;
    }
}