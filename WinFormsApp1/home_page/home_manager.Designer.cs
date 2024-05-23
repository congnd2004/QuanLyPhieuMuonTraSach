namespace C_PRL.home_page
{
    partial class home_manager
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(120, 291);
            label1.Name = "label1";
            label1.Size = new Size(562, 288);
            label1.TabIndex = 1;
            label1.Text = "                  Nhóm 4 \r\n\r\nLeader: Nguyễn Quang Khải\r\nMember: Ninh Minh Quang\r\n                 Bạch Hồng Liên\r\n                 Nguyễn Đức Công\r\n                 Nguyễn Hoàng Bảo Khanh\r\n\r\n";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Picture2;
            panel1.Location = new Point(750, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 480);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Stencil", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(291, 29);
            label2.Name = "label2";
            label2.Size = new Size(966, 78);
            label2.TabIndex = 3;
            label2.Text = "Dự Án : Quản lý thư viện sách";
            // 
            // home_manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "home_manager";
            Size = new Size(1577, 973);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
