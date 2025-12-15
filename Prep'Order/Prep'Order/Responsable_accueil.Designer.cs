namespace Prep_Order
{
    partial class Responsable_accueil
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
            utilisateursToolStripMenuItem = new ToolStripMenuItem();
            afficherToolStripMenuItem = new ToolStripMenuItem();
            afficherToolStripMenuItem1 = new ToolStripMenuItem();
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
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandeToolStripMenuItem
            // 
            commandeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afficherToolStripMenuItem });
            commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            commandeToolStripMenuItem.Size = new Size(100, 24);
            commandeToolStripMenuItem.Text = "Commande";
            // 
            // utilisateursToolStripMenuItem
            // 
            utilisateursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { afficherToolStripMenuItem1 });
            utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            utilisateursToolStripMenuItem.Size = new Size(96, 24);
            utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // afficherToolStripMenuItem
            // 
            afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            afficherToolStripMenuItem.Size = new Size(224, 26);
            afficherToolStripMenuItem.Text = "Afficher";
            afficherToolStripMenuItem.Click += afficherToolStripMenuItem_Click;
            // 
            // afficherToolStripMenuItem1
            // 
            afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            afficherToolStripMenuItem1.Size = new Size(224, 26);
            afficherToolStripMenuItem1.Text = "Afficher";
            // 
            // Responsable_accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Responsable_accueil";
            Text = "Responsable_accueil";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandeToolStripMenuItem;
        private ToolStripMenuItem utilisateursToolStripMenuItem;
        private ToolStripMenuItem afficherToolStripMenuItem;
        private ToolStripMenuItem afficherToolStripMenuItem1;
    }
}