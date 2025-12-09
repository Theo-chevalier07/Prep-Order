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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JULIEN;Database=bdd_prep-order;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT produitID, nomProduit, Quantite, nomZone FROM [Produit] inner join [Zone] on Zone.zoneID = produit.zoneID inner join [Stock] on stock.produitID = produit.produitID";
            


        }

    }
}
