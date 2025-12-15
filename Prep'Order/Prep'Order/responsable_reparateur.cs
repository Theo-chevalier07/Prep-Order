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
    public partial class responsable_reparateur : Form
    {
        public responsable_reparateur()
        {
            InitializeComponent();
        }

        private void responsable_reparateur_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=JULIEN;Database=PrepOrder;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT Login, MotDePasseHash, RoleID, UtilisateurId  FROM [Utilisateur]";


        }
    }
}
