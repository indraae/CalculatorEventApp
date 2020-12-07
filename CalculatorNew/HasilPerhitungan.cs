using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorNew
{
    public partial class HasilPerhitungan : Form
    {
        public HasilPerhitungan()
        {
            InitializeComponent();
        }


        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormPerhitungan f2 = new FormPerhitungan();
            f2.Pembuatan += Pembuatan;
            f2.ShowDialog();
        }

        private void lstboxHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Pembuatan(Kalkulator klk)
        {
            lstboxHasil.Items.Add("Hasil " + klk.nama + " " + klk.a + " " + klk.operasi + " " + klk.b + " " + "=" + " " + klk.hasils);
        }
    }
}
