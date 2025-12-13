using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prep_Order
{
    public partial class Caristes : Form
    {
        public Caristes()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void demandesPréparateursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            demandesPreparateur demandesPreparateur = new demandesPreparateur();
            demandesPreparateur.MdiParent = this;
            demandesPreparateur.WindowState = FormWindowState.Maximized;
            demandesPreparateur.Show();
        }

        private void etatDesRacksStockageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            etatDesRacksStockage racks = new etatDesRacksStockage();
            racks.MdiParent = this;
            racks.WindowState = FormWindowState.Maximized;
            racks.Show();
        }
    }
}
