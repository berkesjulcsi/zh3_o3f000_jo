namespace zh3_o3f000_jo
{
    partial class ExcelUC
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
            excelgenbttn = new Button();
            diagramgenbttn = new Button();
            SuspendLayout();
            // 
            // excelgenbttn
            // 
            excelgenbttn.Location = new Point(209, 141);
            excelgenbttn.Name = "excelgenbttn";
            excelgenbttn.Size = new Size(155, 127);
            excelgenbttn.TabIndex = 0;
            excelgenbttn.Text = "Excel Gen.";
            excelgenbttn.UseVisualStyleBackColor = true;
            excelgenbttn.Click += excelgenbttn_Click;
            // 
            // diagramgenbttn
            // 
            diagramgenbttn.Location = new Point(392, 141);
            diagramgenbttn.Name = "diagramgenbttn";
            diagramgenbttn.Size = new Size(155, 127);
            diagramgenbttn.TabIndex = 1;
            diagramgenbttn.Text = "Diagram Gen.";
            diagramgenbttn.UseVisualStyleBackColor = true;
            diagramgenbttn.Click += diagramgenbttn_Click;
            // 
            // ExcelUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(diagramgenbttn);
            Controls.Add(excelgenbttn);
            Name = "ExcelUC";
            Size = new Size(640, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button excelgenbttn;
        private Button diagramgenbttn;
    }
}
