using System;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks.Dataflow;
namespace Prep_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = identifiant.Text;
            string password = mdp.Text;
            Boolean trouve = false;
            string connectionString = "Server=JULIEN;Database=PrepOrder;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT Login, MotDePasseHash, RoleID, UtilisateurId  FROM [Utilisateur]";
            int role; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() && !trouve)
                        {

                            string loginBase = reader.GetString(0);
                            string mdp = reader.GetString(1);
                            if (loginBase == login && mdp == password)
                            {
                                trouve = true;
                                role = reader.GetInt32(2);
                                Public.id = reader.GetInt32(3);
                                if (role == 1)
                                {
                                    
                                    Responsable r = new Responsable();
                                    r.Show();
                                    this.Hide();

                                }
                                if (role == 3)
                                {
                                    Caristes r = new Caristes();
                                    r.Show();
                                    this.Hide();

                                }
                            }
                        }
                    }
                }
            }
        } 
    }
}
