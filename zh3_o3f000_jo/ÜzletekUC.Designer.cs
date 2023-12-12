namespace zh3_o3f000_jo
{
    partial class ÜzletekUC
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
            üzleteklistb = new ListBox();
            üzletektxtb = new TextBox();
            helytxtb = new TextBox();
            mérettxtb = new TextBox();
            tavalyitxtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // üzleteklistb
            // 
            üzleteklistb.FormattingEnabled = true;
            üzleteklistb.ItemHeight = 15;
            üzleteklistb.Location = new Point(508, 153);
            üzleteklistb.Name = "üzleteklistb";
            üzleteklistb.Size = new Size(120, 274);
            üzleteklistb.TabIndex = 0;
            üzleteklistb.SelectedIndexChanged += üzleteklistb_SelectedIndexChanged;
            // 
            // üzletektxtb
            // 
            üzletektxtb.Location = new Point(508, 124);
            üzletektxtb.Name = "üzletektxtb";
            üzletektxtb.Size = new Size(100, 23);
            üzletektxtb.TabIndex = 4;
            üzletektxtb.TextChanged += üzletektxtb_TextChanged;
            // 
            // helytxtb
            // 
            helytxtb.Location = new Point(391, 153);
            helytxtb.Name = "helytxtb";
            helytxtb.Size = new Size(100, 23);
            helytxtb.TabIndex = 5;
            // 
            // mérettxtb
            // 
            mérettxtb.Location = new Point(391, 199);
            mérettxtb.Name = "mérettxtb";
            mérettxtb.Size = new Size(100, 23);
            mérettxtb.TabIndex = 6;
            // 
            // tavalyitxtb
            // 
            tavalyitxtb.Location = new Point(391, 247);
            tavalyitxtb.Name = "tavalyitxtb";
            tavalyitxtb.Size = new Size(100, 23);
            tavalyitxtb.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 161);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Helyszín:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 255);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 9;
            label2.Text = "Tavalyi Vásárlószám:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 207);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "Méret:";
            // 
            // ÜzletekUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tavalyitxtb);
            Controls.Add(mérettxtb);
            Controls.Add(helytxtb);
            Controls.Add(üzletektxtb);
            Controls.Add(üzleteklistb);
            Name = "ÜzletekUC";
            Size = new Size(727, 493);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox üzleteklistb;
        private TextBox üzletektxtb;
        private TextBox helytxtb;
        private TextBox mérettxtb;
        private TextBox tavalyitxtb;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
