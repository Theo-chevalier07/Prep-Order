namespace Prep_Order
{
    partial class responsable_reparateur
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
            lv_objet = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
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
            afficherToolStripMenuItem.Size = new Size(144, 26);
            afficherToolStripMenuItem.Text = "Afficher";
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
            // lv_objet
            // 
            lv_objet.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4 });
            lv_objet.Location = new Point(200, 94);
            lv_objet.Name = "lv_objet";
            lv_objet.Size = new Size(380, 207);
            lv_objet.TabIndex = 3;
            lv_objet.UseCompatibleStateImageBehavior = false;
            lv_objet.View = View.Details;
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
            // columnHeader4
            // 
            columnHeader4.Text = "Zone";
            columnHeader4.Width = 150;
            // 
            // responsable_reparateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv_objet);
            Controls.Add(menuStrip1);
            Name = "responsable_reparateur";
            Text = "responsable_reparateur";
            Load += responsable_reparateur_Load;
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
        private ListView lv_objet;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
    }
}