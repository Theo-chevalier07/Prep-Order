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
    public partial class etatDesRacksStockage : Form
    {
        public etatDesRacksStockage()
        {
            InitializeComponent();
        }

        private void etatDesRacksStockage_Load(object sender, EventArgs e)
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
                        }
                    }
                }
            }
        }
    }
}
