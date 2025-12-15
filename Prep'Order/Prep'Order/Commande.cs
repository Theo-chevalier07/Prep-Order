using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        }

        private void bt_reparateur_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichierCsv = new OpenFileDialog()
            {
                Title = "Selectionner un fichier CSV",
                Filter = "Fichier CSV (*.csv)|*.csv",
                Multiselect = false,
            };

            if (fichierCsv.ShowDialog() == DialogResult.OK)
            {
                lv_objet.Items.Clear();

                string[] lignes = File.ReadAllLines(fichierCsv.FileName);

                for (int i = 1; i < lignes.Length; i++)
                {
                    string[] valeurs = lignes[i].Split(',');

                    if (valeurs.Length == 4)
                    {
                        ListViewItem item = new ListViewItem(valeurs[0]); // ID
                        item.SubItems.Add(valeurs[1]); // Nom
                        item.SubItems.Add(valeurs[2]); // Quantité
                        item.SubItems.Add(valeurs[3]); // Zone

                        lv_objet.Items.Add(item);
                    }
                }
            }
        }

        private void bt_assignerReparateur_Click(object sender, EventArgs e)
        {
            responsable_reparateur nouvellePage = new responsable_reparateur();
            nouvellePage.Show();
            this.Hide();
        }
    }
}

