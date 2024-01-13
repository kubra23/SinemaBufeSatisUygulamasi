using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir = Convert.ToInt16(txbMisir.Text);
            int su = Convert.ToInt16(txbSu.Text);
            int cay = Convert.ToInt16(txbCay.Text);
            int bilet = Convert.ToInt16(txbBilet.Text);

            int misirtoplam =misir * Convert.ToInt32(label9.Text);
            int sutoplam = su * Convert.ToInt32(label10.Text);
            int caytoplam = cay * Convert.ToInt32(label11.Text);
            int bilettoplam = bilet * Convert.ToInt32(label12.Text);

            double fistoplam = misirtoplam+sutoplam+caytoplam+bilettoplam;
            lblFisToplam.Text = fistoplam.ToString(".00 TL");

            kasatutar += fistoplam;
            lblKasaToplam.Text = kasatutar.ToString(".00 TL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbBilet.Text = "";
            txbCay.Text = "";
            txbMisir.Text = "";
            txbSu.Text = "";
            txbMisir.Focus();
        }
    }
}
