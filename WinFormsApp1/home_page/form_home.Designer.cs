namespace C_PRL.home_page
{
    partial class form_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_home));
            label1 = new Label();
            button1 = new Button();
            pt_main = new PictureBox();
            btn_homepage = new Button();
            brn_user = new Button();
            btn_book = new Button();
            btn_reader = new Button();
            btn_loan = new Button();
            bth_retunr = new Button();
            btn_satatistical = new Button();
            ((System.ComponentModel.ISupportInitialize)pt_main).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.icons8_menu_48__1_1;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(1, 4);
            label1.Name = "label1";
            label1.Size = new Size(163, 62);
            label1.TabIndex = 0;
            label1.Text = "          Quản Lý            Thư Viện";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.icons8_shutdown_48__2_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1829, 8);
            button1.Name = "button1";
            button1.Size = new Size(71, 58);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pt_main
            // 
            pt_main.BackColor = Color.Transparent;
            pt_main.BorderStyle = BorderStyle.Fixed3D;
            pt_main.Location = new Point(332, 105);
            pt_main.Name = "pt_main";
            pt_main.Size = new Size(1577, 973);
            pt_main.TabIndex = 2;
            pt_main.TabStop = false;
            // 
            // btn_homepage
            // 
            btn_homepage.BackColor = Color.Transparent;
            btn_homepage.FlatStyle = FlatStyle.Flat;
            btn_homepage.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_homepage.ForeColor = Color.Transparent;
            btn_homepage.Image = Properties.Resources.icons8_home_48;
            btn_homepage.Location = new Point(0, 105);
            btn_homepage.Margin = new Padding(0);
            btn_homepage.Name = "btn_homepage";
            btn_homepage.Size = new Size(321, 104);
            btn_homepage.TabIndex = 1;
            btn_homepage.Text = " HomePage";
            btn_homepage.TextAlign = ContentAlignment.MiddleLeft;
            btn_homepage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_homepage.UseVisualStyleBackColor = false;
            btn_homepage.Click += btn_homepage_Click;
            // 
            // brn_user
            // 
            brn_user.BackColor = Color.Transparent;
            brn_user.FlatStyle = FlatStyle.Flat;
            brn_user.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            brn_user.ForeColor = Color.Transparent;
            brn_user.Image = Properties.Resources.icons8_user_folder_40;
            brn_user.Location = new Point(0, 214);
            brn_user.Margin = new Padding(0);
            brn_user.Name = "brn_user";
            brn_user.Size = new Size(321, 104);
            brn_user.TabIndex = 3;
            brn_user.Text = "User Managerment";
            brn_user.TextAlign = ContentAlignment.MiddleLeft;
            brn_user.TextImageRelation = TextImageRelation.ImageBeforeText;
            brn_user.UseVisualStyleBackColor = false;
            brn_user.Click += brn_user_Click;
            // 
            // btn_book
            // 
            btn_book.BackColor = Color.Transparent;
            btn_book.FlatStyle = FlatStyle.Flat;
            btn_book.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_book.ForeColor = Color.Transparent;
            btn_book.Image = Properties.Resources.icons8_book_40;
            btn_book.Location = new Point(1, 323);
            btn_book.Margin = new Padding(0);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(321, 104);
            btn_book.TabIndex = 4;
            btn_book.Text = "Book Managerment";
            btn_book.TextAlign = ContentAlignment.MiddleLeft;
            btn_book.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_book.UseVisualStyleBackColor = false;
            btn_book.Click += btn_book_Click;
            // 
            // btn_reader
            // 
            btn_reader.BackColor = Color.Transparent;
            btn_reader.FlatStyle = FlatStyle.Flat;
            btn_reader.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reader.ForeColor = Color.Transparent;
            btn_reader.Image = Properties.Resources.icons8_read_online_48;
            btn_reader.Location = new Point(1, 431);
            btn_reader.Margin = new Padding(0);
            btn_reader.Name = "btn_reader";
            btn_reader.Size = new Size(321, 104);
            btn_reader.TabIndex = 5;
            btn_reader.Text = "Reader  Managerment";
            btn_reader.TextAlign = ContentAlignment.MiddleLeft;
            btn_reader.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reader.UseVisualStyleBackColor = false;
            btn_reader.Click += btn_reader_Click;
            // 
            // btn_loan
            // 
            btn_loan.BackColor = Color.Transparent;
            btn_loan.FlatStyle = FlatStyle.Flat;
            btn_loan.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_loan.ForeColor = Color.Transparent;
            btn_loan.Image = (Image)resources.GetObject("btn_loan.Image");
            btn_loan.Location = new Point(1, 539);
            btn_loan.Margin = new Padding(0);
            btn_loan.Name = "btn_loan";
            btn_loan.Size = new Size(321, 104);
            btn_loan.TabIndex = 6;
            btn_loan.Text = "Loan Managerment";
            btn_loan.TextAlign = ContentAlignment.MiddleLeft;
            btn_loan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_loan.UseVisualStyleBackColor = false;
            btn_loan.Click += btn_loan_Click;
            // 
            // bth_retunr
            // 
            bth_retunr.BackColor = Color.Transparent;
            bth_retunr.FlatStyle = FlatStyle.Flat;
            bth_retunr.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            bth_retunr.ForeColor = Color.Transparent;
            bth_retunr.Image = (Image)resources.GetObject("bth_retunr.Image");
            bth_retunr.Location = new Point(1, 647);
            bth_retunr.Margin = new Padding(0);
            bth_retunr.Name = "bth_retunr";
            bth_retunr.Size = new Size(321, 104);
            bth_retunr.TabIndex = 7;
            bth_retunr.Text = "Return Managerment";
            bth_retunr.TextAlign = ContentAlignment.MiddleLeft;
            bth_retunr.TextImageRelation = TextImageRelation.ImageBeforeText;
            bth_retunr.UseVisualStyleBackColor = false;
            bth_retunr.Click += bth_retunr_Click;
            // 
            // btn_satatistical
            // 
            btn_satatistical.BackColor = Color.Transparent;
            btn_satatistical.FlatStyle = FlatStyle.Flat;
            btn_satatistical.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_satatistical.ForeColor = Color.Transparent;
            btn_satatistical.Image = (Image)resources.GetObject("btn_satatistical.Image");
            btn_satatistical.Location = new Point(2, 755);
            btn_satatistical.Margin = new Padding(0);
            btn_satatistical.Name = "btn_satatistical";
            btn_satatistical.Size = new Size(321, 104);
            btn_satatistical.TabIndex = 8;
            btn_satatistical.Text = "Statistical";
            btn_satatistical.TextAlign = ContentAlignment.MiddleLeft;
            btn_satatistical.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_satatistical.UseVisualStyleBackColor = false;
            // 
            // form_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Image_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1912, 1106);
            Controls.Add(btn_satatistical);
            Controls.Add(bth_retunr);
            Controls.Add(btn_loan);
            Controls.Add(btn_reader);
            Controls.Add(btn_book);
            Controls.Add(brn_user);
            Controls.Add(btn_homepage);
            Controls.Add(pt_main);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "form_home";
            Text = "form_home";
            WindowState = FormWindowState.Maximized;
            Load += form_home_Load;
            ((System.ComponentModel.ISupportInitialize)pt_main).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pt_main;
        private Button btn_homepage;
        private Button brn_user;
        private Button btn_book;
        private Button btn_reader;
        private Button btn_loan;
        private Button bth_retunr;
        private Button btn_satatistical;
    }
}