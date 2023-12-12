using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_o3f000_jo.Models;

namespace zh3_o3f000_jo
{
    public partial class CsomagokUC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();
        public CsomagokUC()
        {
            InitializeComponent();
            CsomagokSzűrés();
        }
        private void CsomagokSzűrés()
        {
            var megjelen = from x in telefonContext.Csomagoks
                           where x.CsomagNév.Contains(csomagoktxtb.Text)
                           select x;
            csomagoklistb.DataSource = megjelen.ToList();
            csomagoklistb.DisplayMember = "CsomagNév";
        }

        private void csomagoktxtb_TextChanged(object sender, EventArgs e)
        {
            CsomagokSzűrés();
        }

        private void csomagoklistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            időttxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).Időtartam.ToString();
            fizütxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).FizÜtemezés;
            ártxtb.Text = ((Csomagok)csomagoklistb.SelectedItem).Ár.ToString();
        }
    }
}
