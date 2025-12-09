namespace Prep_Order
{
    partial class Commande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            commandeToolStripMenuItem = new ToolStripMenuItem();
            afficherToolStripMenuItem = new ToolStripMenuItem();
            utilisateursToolStripMenuItem = new ToolStripMenuItem();
            afficherToolStripMenuItem1 = new ToolStripMenuItem();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandeToolStripMenuItem, utilisateursToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afficherToolStripMenuItem });
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(100, 24);
            commandeToolStripMenuItem.Text = "Commande";
            // 
            // afficherToolStripMenuItem
            // 
            afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            afficherToolStripMenuItem.Size = new Size(224, 26);
            afficherToolStripMenuItem.Text = "Afficher";
            afficherToolStripMenuItem.Click += afficherToolStripMenuItem_Click;
            // 
            // utilisateursToolStripMenuItem
            // 
            utilisateursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afficherToolStripMenuItem1 });
            utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            utilisateursToolStripMenuItem.Size = new Size(96, 24);
            utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // afficherToolStripMenuItem1
            // 
            afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            afficherToolStripMenuItem1.Size = new Size(144, 26);
            afficherToolStripMenuItem1.Text = "Afficher";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(171, 98);
            listView1.Name = "listView1";
            listView1.Size = new Size(466, 207);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "quantités";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Zone";
            columnHeader4.Width = 150;
            // 
            // Commande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Name = "Commande";
            Text = "Commande";
            Load += Commande_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandeToolStripMenuItem;
        private ToolStripMenuItem afficherToolStripMenuItem;
        private ToolStripMenuItem utilisateursToolStripMenuItem;
        private ToolStripMenuItem afficherToolStripMenuItem1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}