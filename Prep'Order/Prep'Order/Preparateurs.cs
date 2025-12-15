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
    public partial class Preparateurs : Form
    {
        public Preparateurs()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            commandesDésignerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { commandesDésignerToolStripMenuItem });
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(106, 24);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // commandesDésignerToolStripMenuItem
            // 
            commandesDésignerToolStripMenuItem.Name = "commandesDésignerToolStripMenuItem";
            commandesDésignerToolStripMenuItem.Size = new Size(236, 26);
            commandesDésignerToolStripMenuItem.Text = "Commandes désigner";
            commandesDésignerToolStripMenuItem.Click += commandesDésignerToolStripMenuItem_Click;
            // 
            // Preparateurs
            // 
            ClientSize = new Size(901, 490);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Preparateurs";
            Text = "Préparateurs";
            Load += Preparateurs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandesDésignerToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;

        private void Preparateurs_Load(object sender, EventArgs e)
        {

        }

        private void commandesDésignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandeDesigner c = new CommandeDesigner();
            c.MdiParent = this;
            c.WindowState = FormWindowState.Maximized;
            c.Show();
        }
    }
}
