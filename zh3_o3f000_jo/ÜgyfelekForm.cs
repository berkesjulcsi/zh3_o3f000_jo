using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_o3f000_jo.Models;

namespace zh3_o3f000_jo
{
    public partial class ÜgyfelekForm : Form
    {
        TelefonContext telefonContext = new TelefonContext();
        public ÜgyfelekForm()
        {
            InitializeComponent();
            CsomagokSzűrés();
            ÜgyfelekMegjelen();
        }

        private void CsomagokSzűrés()
        {
            var megjelen = from x in telefonContext.Csomagoks
                           where x.CsomagNév.Contains(csomagoktxtb.Text)
                           select x;
            csomagoklistb.DataSource = megjelen.ToList();
            csomagoklistb.DisplayMember = "CsomagNév";
        }

        private void ÜgyfelekMegjelen()
        {
            var csomagid = ((Csomagok)csomagoklistb.SelectedItem).CsomagId;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.CsomagId == csomagid
                           select x;
            ügyfeleklistb.DataSource = megjelen.ToList();
            ügyfeleklistb.DisplayMember = "Név";
        }
        private void DataJelenés()
        {
            var ügyfélnév = ((Ügyfelek)ügyfeleklistb.SelectedItem).Név;
            var megjelen = from x in telefonContext.Ügyfeleks
                           where x.Név == ügyfélnév
                           select new DataJelen
                           {
                               ÜgyfélId = x.ÜgyfélId,
                               Név = x.Név,
                               SzülIdő = x.SzülIdő,
                               TelSzám = x.TelSzám,
                               Email = x.Email,
                               Csomag = x.Csomag.CsomagNév,
                               Ár = x.Csomag.Ár,
                               Percek = x.Csomag.Percek,

                           };
            dataJelenBindingSource.DataSource = megjelen.ToList();
        }

        private void csomagoktxtb_TextChanged(object sender, EventArgs e)
        {
            CsomagokSzűrés();
        }

        private void csomagoklistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ÜgyfelekMegjelen();
        }

        private void ügyfeleklistb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataJelenés();
        }
        private bool Megfelele(string n)
        {
            Regex regex = new Regex("[0-9]{9}$");
            return regex.IsMatch(n);
        }

        private void hozzáadtxtb_Validating(object sender, CancelEventArgs e)
        {
            if (!Megfelele(hozzáadtxtb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(hozzáadtxtb, "9 számból kell állnia!");
            }
        }

        private void hozzáadtxtb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(hozzáadtxtb, "");
        }

        private void hozzáadbttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan hozzá akarsz adni adatot?", "Adat hozzáadása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Ügyfelek üf = new Ügyfelek();
                üf.Név = ((Ügyfelek)ügyfeleklistb.SelectedItem).Név;
                üf.Email = ((Ügyfelek)ügyfeleklistb.SelectedItem).Email;
                üf.TelSzám = hozzáadtxtb.Text;
                telefonContext.Ügyfeleks.Add(üf);
                try
                {
                    telefonContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                DataJelenés();
            }
        }

        private void törlésbttn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan ki szeretnéd törölni a sort?", "Sor törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var törlendőnév = ((DataJelen)dataJelenBindingSource.Current).Név;
                var törlendő = (from x in telefonContext.Ügyfeleks
                               where x.Név == törlendőnév
                               select x).FirstOrDefault();
                telefonContext.Ügyfeleks.Remove(törlendő);
                try
                {
                    telefonContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                DataJelenés();
            }
        }
    }
}
