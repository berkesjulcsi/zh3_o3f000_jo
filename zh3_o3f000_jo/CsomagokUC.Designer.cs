namespace zh3_o3f000_jo
{
    partial class CsomagokUC
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
            csomagoklistb = new ListBox();
            csomagoktxtb = new TextBox();
            időttxtb = new TextBox();
            fizütxtb = new TextBox();
            ártxtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // csomagoklistb
            // 
            csomagoklistb.FormattingEnabled = true;
            csomagoklistb.ItemHeight = 15;
            csomagoklistb.Location = new Point(550, 191);
            csomagoklistb.Name = "csomagoklistb";
            csomagoklistb.Size = new Size(120, 94);
            csomagoklistb.TabIndex = 0;
            csomagoklistb.SelectedIndexChanged += csomagoklistb_SelectedIndexChanged;
            // 
            // csomagoktxtb
            // 
            csomagoktxtb.Location = new Point(550, 162);
            csomagoktxtb.Name = "csomagoktxtb";
            csomagoktxtb.Size = new Size(100, 23);
            csomagoktxtb.TabIndex = 1;
            csomagoktxtb.TextChanged += csomagoktxtb_TextChanged;
            // 
            // időttxtb
            // 
            időttxtb.Location = new Point(444, 191);
            időttxtb.Name = "időttxtb";
            időttxtb.Size = new Size(100, 23);
            időttxtb.TabIndex = 2;
            // 
            // fizütxtb
            // 
            fizütxtb.Location = new Point(338, 191);
            fizütxtb.Name = "fizütxtb";
            fizütxtb.Size = new Size(100, 23);
            fizütxtb.TabIndex = 3;
            // 
            // ártxtb
            // 
            ártxtb.Location = new Point(232, 191);
            ártxtb.Name = "ártxtb";
            ártxtb.Size = new Size(100, 23);
            ártxtb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 151);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "Ár:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 151);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Fiz. Ütemezés:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 151);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Időtartam:";
            // 
            // CsomagokUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ártxtb);
            Controls.Add(fizütxtb);
            Controls.Add(időttxtb);
            Controls.Add(csomagoktxtb);
            Controls.Add(csomagoklistb);
            Name = "CsomagokUC";
            Size = new Size(725, 441);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomagoklistb;
        private TextBox csomagoktxtb;
        private TextBox időttxtb;
        private TextBox fizütxtb;
        private TextBox ártxtb;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
