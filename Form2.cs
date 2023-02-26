using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probarControles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            trackBar1.MouseUp += trackBar1_MouseUp;
        }

        private void trackBar1_MouseUp(object senger, EventArgs e)
        {
            int value = trackBar1.Value;
            label2.Text = value.ToString();
            if (value < 5)
            {
                MessageBox.Show("Sentim que el producte no t'hagi agradat, deixa'ns els teus comentaris en la pàgina web");
            } 
            else if (value > 5)
            {
                MessageBox.Show("Estem contents que el producte t'hagi agradat, no obstant això, ens pots deixar comentaris de millora");
            }
        }
    }
}
