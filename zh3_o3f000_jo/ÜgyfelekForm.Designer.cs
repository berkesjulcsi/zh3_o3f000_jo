namespace zh3_o3f000_jo
{
    partial class ÜgyfelekForm
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
            components = new System.ComponentModel.Container();
            csomagoklistb = new ListBox();
            ügyfeleklistb = new ListBox();
            dataGridView1 = new DataGridView();
            ügyfélIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            névDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szülIdőDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telSzámDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bővíthetőEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            csomagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            árDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataJelenBindingSource = new BindingSource(components);
            hozzáadbttn = new Button();
            törlésbttn = new Button();
            csomagoktxtb = new TextBox();
            hozzáadtxtb = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // csomagoklistb
            // 
            csomagoklistb.FormattingEnabled = true;
            csomagoklistb.ItemHeight = 15;
            csomagoklistb.Location = new Point(12, 43);
            csomagoklistb.Name = "csomagoklistb";
            csomagoklistb.Size = new Size(120, 349);
            csomagoklistb.TabIndex = 0;
            csomagoklistb.SelectedIndexChanged += csomagoklistb_SelectedIndexChanged;
            // 
            // ügyfeleklistb
            // 
            ügyfeleklistb.FormattingEnabled = true;
            ügyfeleklistb.ItemHeight = 15;
            ügyfeleklistb.Location = new Point(138, 43);
            ügyfeleklistb.Name = "ügyfeleklistb";
            ügyfeleklistb.Size = new Size(120, 349);
            ügyfeleklistb.TabIndex = 1;
            ügyfeleklistb.SelectedIndexChanged += ügyfeleklistb_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ügyfélIdDataGridViewTextBoxColumn, névDataGridViewTextBoxColumn, szülIdőDataGridViewTextBoxColumn, telSzámDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, bővíthetőEDataGridViewTextBoxColumn, csomagDataGridViewTextBoxColumn, árDataGridViewTextBoxColumn, percekDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dataJelenBindingSource;
            dataGridView1.Location = new Point(264, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(524, 349);
            dataGridView1.TabIndex = 2;
            // 
            // ügyfélIdDataGridViewTextBoxColumn
            // 
            ügyfélIdDataGridViewTextBoxColumn.DataPropertyName = "ÜgyfélId";
            ügyfélIdDataGridViewTextBoxColumn.HeaderText = "ÜgyfélId";
            ügyfélIdDataGridViewTextBoxColumn.Name = "ügyfélIdDataGridViewTextBoxColumn";
            // 
            // névDataGridViewTextBoxColumn
            // 
            névDataGridViewTextBoxColumn.DataPropertyName = "Név";
            névDataGridViewTextBoxColumn.HeaderText = "Név";
            névDataGridViewTextBoxColumn.Name = "névDataGridViewTextBoxColumn";
            // 
            // szülIdőDataGridViewTextBoxColumn
            // 
            szülIdőDataGridViewTextBoxColumn.DataPropertyName = "SzülIdő";
            szülIdőDataGridViewTextBoxColumn.HeaderText = "SzülIdő";
            szülIdőDataGridViewTextBoxColumn.Name = "szülIdőDataGridViewTextBoxColumn";
            // 
            // telSzámDataGridViewTextBoxColumn
            // 
            telSzámDataGridViewTextBoxColumn.DataPropertyName = "TelSzám";
            telSzámDataGridViewTextBoxColumn.HeaderText = "TelSzám";
            telSzámDataGridViewTextBoxColumn.Name = "telSzámDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // bővíthetőEDataGridViewTextBoxColumn
            // 
            bővíthetőEDataGridViewTextBoxColumn.DataPropertyName = "BővíthetőE";
            bővíthetőEDataGridViewTextBoxColumn.HeaderText = "BővíthetőE";
            bővíthetőEDataGridViewTextBoxColumn.Name = "bővíthetőEDataGridViewTextBoxColumn";
            // 
            // csomagDataGridViewTextBoxColumn
            // 
            csomagDataGridViewTextBoxColumn.DataPropertyName = "Csomag";
            csomagDataGridViewTextBoxColumn.HeaderText = "Csomag";
            csomagDataGridViewTextBoxColumn.Name = "csomagDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            árDataGridViewTextBoxColumn.HeaderText = "Ár";
            árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // percekDataGridViewTextBoxColumn
            // 
            percekDataGridViewTextBoxColumn.DataPropertyName = "Percek";
            percekDataGridViewTextBoxColumn.HeaderText = "Percek";
            percekDataGridViewTextBoxColumn.Name = "percekDataGridViewTextBoxColumn";
            // 
            // dataJelenBindingSource
            // 
            dataJelenBindingSource.DataSource = typeof(DataJelen);
            // 
            // hozzáadbttn
            // 
            hozzáadbttn.Location = new Point(57, 398);
            hozzáadbttn.Name = "hozzáadbttn";
            hozzáadbttn.Size = new Size(75, 23);
            hozzáadbttn.TabIndex = 3;
            hozzáadbttn.Text = "Hozzáad";
            hozzáadbttn.UseVisualStyleBackColor = true;
            hozzáadbttn.Click += hozzáadbttn_Click;
            // 
            // törlésbttn
            // 
            törlésbttn.Location = new Point(264, 14);
            törlésbttn.Name = "törlésbttn";
            törlésbttn.Size = new Size(75, 23);
            törlésbttn.TabIndex = 4;
            törlésbttn.Text = "Törlés";
            törlésbttn.UseVisualStyleBackColor = true;
            törlésbttn.Click += törlésbttn_Click;
            // 
            // csomagoktxtb
            // 
            csomagoktxtb.Location = new Point(12, 15);
            csomagoktxtb.Name = "csomagoktxtb";
            csomagoktxtb.Size = new Size(100, 23);
            csomagoktxtb.TabIndex = 5;
            csomagoktxtb.TextChanged += csomagoktxtb_TextChanged;
            // 
            // hozzáadtxtb
            // 
            hozzáadtxtb.Location = new Point(158, 398);
            hozzáadtxtb.Name = "hozzáadtxtb";
            hozzáadtxtb.Size = new Size(100, 23);
            hozzáadtxtb.TabIndex = 6;
            hozzáadtxtb.Validating += hozzáadtxtb_Validating;
            hozzáadtxtb.Validated += hozzáadtxtb_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ÜgyfelekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hozzáadtxtb);
            Controls.Add(csomagoktxtb);
            Controls.Add(törlésbttn);
            Controls.Add(hozzáadbttn);
            Controls.Add(dataGridView1);
            Controls.Add(ügyfeleklistb);
            Controls.Add(csomagoklistb);
            Name = "ÜgyfelekForm";
            Text = "ÜgyfelekForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataJelenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox csomagoklistb;
        private ListBox ügyfeleklistb;
        private DataGridView dataGridView1;
        private Button hozzáadbttn;
        private Button törlésbttn;
        private TextBox csomagoktxtb;
        private TextBox hozzáadtxtb;
        private DataGridViewTextBoxColumn ügyfélIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn névDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szülIdőDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telSzámDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bővíthetőEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn csomagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percekDataGridViewTextBoxColumn;
        private BindingSource dataJelenBindingSource;
        private ErrorProvider errorProvider1;
    }
}