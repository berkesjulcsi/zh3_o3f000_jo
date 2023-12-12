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
    public partial class ÜzletekUC : UserControl
    {
        TelefonContext telefonContext = new TelefonContext();

        public ÜzletekUC()
        {
            InitializeComponent();
            ÜzletekSzűrés();
        }

        private void ÜzletekSzűrés()
        {
            var megjelen = from x in telefonContext.Üzleteks
                           where x.ÜzletNév.Contains(üzletektxtb.Text)
                           select x;
            üzleteklistb.DataSource = megjelen.ToList();
            üzleteklistb.DisplayMember = "ÜzletNév";
        }
        private void üzletektxtb_TextChanged(object sender, EventArgs e)
        {
            ÜzletekSzűrés();
        }

        private void üzleteklistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helytxtb.Text = ((Üzletek)üzleteklistb.SelectedItem).Helyszín;
            mérettxtb.Text = ((Üzletek)üzleteklistb.SelectedItem).Méret;
            tavalyitxtb.Text = ((Üzletek)üzleteklistb.SelectedItem).TavalyiVásárlóSzám.ToString();
        }
    }
}
