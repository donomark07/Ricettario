using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricettario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbc_ricettario.Appearance = TabAppearance.FlatButtons;
            tbc_ricettario.ItemSize = new Size(0, 1);
            tbc_ricettario.SizeMode = TabSizeMode.Fixed;

        }

        private void btn_antipasti_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(1);
        }

        private void btn_primi_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(2);
        }

        private void btn_secondi_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(3);
        }

        private void btn_dolci_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(5);
        }

        private void pb_indietroantipasti_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(0);
        }

        private void pb_indietroprimi_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(0);
        }

        private void pb_indietrosecondi_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(0);
        }

        private void pb_indietrodolci_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(0);
        }

        private void pb_indietrofocacce_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(0);
        }

        private void btn_antipastoterra_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(6);
        }

        private void btn_antipastimare_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(7);
        }

        private void btn_primipasta_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(8);
        }

        private void btn_primiriso_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(9);
        }

        private void btn_secondicarne_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(10);
        }

        private void btn_secondipesce_Click(object sender, EventArgs e)
        {
            tbc_ricettario.SelectTab(11);
        }
    }
}
