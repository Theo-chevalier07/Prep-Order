using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prep_Order
{
    public partial class DemandeDeplacementStock : Form
    {
        public DemandeDeplacementStock()
        {
            InitializeComponent();
        }

        private void DemandeDeplacementStock_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JULIEN;Database=PrepOrder;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT E.CodeEmplacement, Z.NomZone, P.NomProduit, S.Quantite FROM Stock S INNER JOIN Emplacement E ON S.EmplacementID = E.EmplacementID INNER JOIN Produit P ON S.ProduitID = P.ProduitID INNER JOIN Zone Z ON E.ZoneID = Z.ZoneID WHERE Z.NomZone <> 'Picking' ORDER BY Z.NomZone, E.CodeEmplacement;";
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
                            ListViewItem listItem = new ListViewItem(reader.GetString(0));
                            listItem.SubItems.Add(reader.GetString(1));
                            listItem.SubItems.Add(reader.GetString(2));
                            listItem.SubItems.Add(reader.GetInt32(3).ToString());
                            lv1.Items.Add(listItem);
                            lv1.ItemSelectionChanged += lv1_ItemSelectionChanged;
                        }
                    }
                }
            }

            query = "SELECT U.Nom FROM Utilisateur U INNER JOIN RoleUtilisateur R ON U.RoleID = R.RoleID WHERE R.NomRole = 'Cariste'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb1.Items.Add(reader.GetString(0));
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

                using (SqlCommand cmd = new SqlCommand("AjouterDemandePalette", conn))
                {

                    ListViewItem item = lv1.SelectedItems[0];
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodeEmplacement", item.SubItems[0].Text);
                    cmd.Parameters.AddWithValue("@NomCariste", cb1.Text);
                    cmd.Parameters.AddWithValue("@PreparateurID", Public.id);
                    cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Demande effectuer");
                        
                }
            }
        }
    }
}
