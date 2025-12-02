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
            Responsable r = new Responsable();  
            this.Close();
            r.Show();
        }
    }
}
