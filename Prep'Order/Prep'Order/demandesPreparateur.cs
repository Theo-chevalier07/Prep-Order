using Microsoft.Data.SqlClient;
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
    public partial class demandesPreparateur : Form
    {
        public demandesPreparateur()
        {
            InitializeComponent();
        }

        private void demandesPreparateur_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=JULIEN;Database=PrepOrder;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "Select D.DemandeID, NomProduit, QuantiteDemandee, D.ZoneID from DemandePalette D inner join Produit P on D.ProduitID = P.ProduitID inner join CommandeLigne C on D.LigneId = C.LigneId inner join Reapprovisionnement R on D.DemandeID = R.DemandeID where CaristeID = @id and Statut <> 'Terminé'";
            int role;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Public.id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem listItem = new ListViewItem(reader.GetInt32(0).ToString());
                            listItem.SubItems.Add(reader.GetString(1));
                            listItem.SubItems.Add(reader.GetInt32(2).ToString());
                            listItem.SubItems.Add(reader.GetInt32(3).ToString());
                            lv1.Items.Add(listItem);
                            lv1.ItemSelectionChanged += lv1_ItemSelectionChanged;
                        }
                    }
                }
            }
        }
        private void lv1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string nom = e.Item.SubItems[0].Text;
                string quantite = e.Item.SubItems[1].Text;
                string zone = e.Item.SubItems[2].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élément dans la liste.");
                return;
            }
            string connectionString = "Server=JULIEN;Database=PrepOrder;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("changerTerminéCommande", conn))
                {
                    
                        ListViewItem item = lv1.SelectedItems[0];
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", item.SubItems[0].Text);
                    cmd.ExecuteNonQuery();
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                        MessageBox.Show("Déplacement effectuer de la palette : "+ item.SubItems[0].Text);
                        Form parent = this.MdiParent;
                        this.Close();
                        demandesPreparateur f = new demandesPreparateur();
                        f.MdiParent = parent;
                        f.WindowState = FormWindowState.Maximized;
                        f.Show();
                    }
                }
            }

        }
    }
}
