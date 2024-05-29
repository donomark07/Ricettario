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
    }
}
