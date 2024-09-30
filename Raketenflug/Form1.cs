using System;
using System.Threading;
using System.Windows.Forms;

namespace Raketenflug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbBezeichnung.Text = "Ariane";
            tbA.Text = "20"; 
            tbHoehe.Text = "500";
            tbAusgabe.Text = "";
            Thread.Sleep(1000);
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double zielhoehe = Convert.ToDouble(tbHoehe.Text); 
            Rakete rakete = new Rakete(a, zielhoehe);
            tbAusgabe.Text = "Zeit\tHöhe\r\n";
            double rueck = 0;
            int s = 0;

            while (rueck < zielhoehe)
            {
                s++;
                rueck += rakete.GibBeschleunigung() * s; 
                tbAusgabe.Text += $"Zeit: {s}\tHöhe: {rueck:F0}\r\n";
            }

            tbAusgabe.Text += $"Die Zielhöhe von {zielhoehe} m wird nach {s} Sekunden erreicht.\r\n"; // Finale Ausgabe
        }

        private void TbA_TextChanged(object sender, EventArgs e)
        {
            btStart.Enabled = true;
        }
    }
}
