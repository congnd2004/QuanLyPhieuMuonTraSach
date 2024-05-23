namespace C_PRL.home_page
{
    partial class history
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
            pn_history = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            txttimkiem = new TextBox();
            dtglichsu = new DataGridView();
            pn_history.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtglichsu).BeginInit();
            SuspendLayout();
            // 
            // pn_history
            // 
            pn_history.Controls.Add(label1);
            pn_history.Controls.Add(panel2);
            pn_history.Location = new Point(0, 3);
            pn_history.Name = "pn_history";
            pn_history.Size = new Size(1577, 970);
            pn_history.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Image = Properties.Resources.icons8_time_machine_641;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(545, 32);
            label1.Name = "label1";
            label1.Size = new Size(421, 91);
            label1.TabIndex = 1;
            label1.Text = "    Lịch sử mượn sách";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txttimkiem);
            panel2.Controls.Add(dtglichsu);
            panel2.Location = new Point(31, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 869);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_move_left_96;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(106, 77);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(1200, 85);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(306, 38);
            txttimkiem.TabIndex = 1;
            txttimkiem.TextChanged += txttimkiem_TextChanged_1;
            // 
            // dtglichsu
            // 
            dtglichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglichsu.Location = new Point(23, 129);
            dtglichsu.Name = "dtglichsu";
            dtglichsu.RowHeadersWidth = 51;
            dtglichsu.RowTemplate.Height = 29;
            dtglichsu.Size = new Size(1483, 709);
            dtglichsu.TabIndex = 0;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pn_history);
            Name = "history";
            Size = new Size(1577, 973);
            pn_history.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtglichsu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_history;
        private Panel panel2;
        private Label label1;
        private TextBox txttimkiem;
        private DataGridView dtglichsu;
        private Button button1;
    }
}
