namespace zh3_o3f000_jo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void csomagokbttn_Click(object sender, EventArgs e)
        {
            CsomagokUC csomagokUC = new CsomagokUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(csomagokUC);
            panel1.Dock = DockStyle.Fill;
        }

        private void üzletekbttn_Click(object sender, EventArgs e)
        {
            ÜzletekUC üzletekUC = new ÜzletekUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(üzletekUC);
            panel1.Dock = DockStyle.Fill;
        }

        private void excelbttn_Click(object sender, EventArgs e)
        {
            ExcelUC excelUC = new ExcelUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(excelUC);
            panel1.Dock = DockStyle.Fill;
        }

        private void tudnivalókbttn_Click(object sender, EventArgs e)
        {
            TudnivalókForm tudnivalókForm = new TudnivalókForm();
            tudnivalókForm.ShowDialog();
        }

        private void ügyfelekbttn_Click(object sender, EventArgs e)
        {
            ÜgyfelekForm ügyfelekForm = new ÜgyfelekForm();
            ügyfelekForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan be akarod zárni az ablakot?", "Ablak bezárása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}