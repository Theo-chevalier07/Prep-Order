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
    public partial class Responsable_accueil : Form
    {
        public Responsable_accueil()
        {
            InitializeComponent();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commande commandeAfficher = new Commande();
            commandeAfficher.Show();
            this.Hide();
        }
    }
}
