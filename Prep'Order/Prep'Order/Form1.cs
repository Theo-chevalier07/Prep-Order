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
            string connectionString = "Server=JULIEN;Database=bdd_prep-order;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT identifiant, mdp, idRole FROM [User]";
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
                            role = reader.GetInt32(2);
                            MessageBox.Show(role.ToString());
                            if(role == 1)
                            {
                                Responsable r = new Responsable();
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
