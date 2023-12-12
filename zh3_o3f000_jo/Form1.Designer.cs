namespace zh3_o3f000_jo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            csomagokbttn = new Button();
            üzletekbttn = new Button();
            excelbttn = new Button();
            tudnivalókbttn = new Button();
            ügyfelekbttn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // csomagokbttn
            // 
            csomagokbttn.Location = new Point(60, 72);
            csomagokbttn.Name = "csomagokbttn";
            csomagokbttn.Size = new Size(75, 23);
            csomagokbttn.TabIndex = 0;
            csomagokbttn.Text = "Csomagok";
            csomagokbttn.UseVisualStyleBackColor = true;
            csomagokbttn.Click += csomagokbttn_Click;
            // 
            // üzletekbttn
            // 
            üzletekbttn.Location = new Point(60, 101);
            üzletekbttn.Name = "üzletekbttn";
            üzletekbttn.Size = new Size(75, 23);
            üzletekbttn.TabIndex = 1;
            üzletekbttn.Text = "Üzletek";
            üzletekbttn.UseVisualStyleBackColor = true;
            üzletekbttn.Click += üzletekbttn_Click;
            // 
            // excelbttn
            // 
            excelbttn.Location = new Point(60, 130);
            excelbttn.Name = "excelbttn";
            excelbttn.Size = new Size(75, 23);
            excelbttn.TabIndex = 2;
            excelbttn.Text = "Excel";
            excelbttn.UseVisualStyleBackColor = true;
            excelbttn.Click += excelbttn_Click;
            // 
            // tudnivalókbttn
            // 
            tudnivalókbttn.Location = new Point(60, 227);
            tudnivalókbttn.Name = "tudnivalókbttn";
            tudnivalókbttn.Size = new Size(75, 23);
            tudnivalókbttn.TabIndex = 3;
            tudnivalókbttn.Text = "Tudnivalók";
            tudnivalókbttn.UseVisualStyleBackColor = true;
            tudnivalókbttn.Click += tudnivalókbttn_Click;
            // 
            // ügyfelekbttn
            // 
            ügyfelekbttn.Location = new Point(60, 256);
            ügyfelekbttn.Name = "ügyfelekbttn";
            ügyfelekbttn.Size = new Size(75, 23);
            ügyfelekbttn.TabIndex = 4;
            ügyfelekbttn.Text = "Ügyfelek";
            ügyfelekbttn.UseVisualStyleBackColor = true;
            ügyfelekbttn.Click += ügyfelekbttn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 38);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "UserControlok:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 196);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Formok:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ügyfelekbttn);
            Controls.Add(tudnivalókbttn);
            Controls.Add(excelbttn);
            Controls.Add(üzletekbttn);
            Controls.Add(csomagokbttn);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button csomagokbttn;
        private Button üzletekbttn;
        private Button excelbttn;
        private Button tudnivalókbttn;
        private Button ügyfelekbttn;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}