﻿using System;
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
    public partial class FormPerhitungan : Form
    {
        public delegate void CreateUpdateEventHandler(Kalkulator klk);
        public event FormPerhitungan.CreateUpdateEventHandler Pembuatan;
        private Kalkulator klk;


        public FormPerhitungan()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            klk = new Kalkulator();
            klk.nama = this.cmbOperasi.Text.ToLower();
            klk.operasi = string.Empty;
            klk.hasils = 0;
            klk.a = Double.Parse(this.txtNilaiA.Text);
            klk.b = Double.Parse(this.txtNilaiB.Text);


            if (this.cmbOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon Pilih Operasinya Terlebih Dahulu !");
            }
            else if (this.cmbOperasi.SelectedIndex == 0)
            {
                klk.hasils = klk.a + klk.b;
                klk.operasi = "+";

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                klk.hasils = klk.a - klk.b;
                klk.operasi = "-";
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                klk.hasils = klk.a * klk.b;
                klk.operasi = "*";
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                klk.hasils = klk.a / klk.b;
                klk.operasi = "/";
            }

            this.Pembuatan(klk);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
