namespace zh3_o3f000_jo
{
    partial class TudnivalókForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TudnivalókForm));
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 0;
            label1.Text = "Hogyan Jött létre az adatbázis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Mit tartalmaz az adatbázis:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 44);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(407, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 161);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(407, 96);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 260);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "Mit csinál a projektem:";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 278);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(407, 96);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // TudnivalókForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox3);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TudnivalókForm";
            Text = "TudnivalókForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label3;
        private RichTextBox richTextBox3;
    }
}