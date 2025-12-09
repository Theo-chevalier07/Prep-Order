namespace Prep_Order
{
    partial class Caristes
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
            commandesToolStripMenuItem = new ToolStripMenuItem();
            demandesPréparateursToolStripMenuItem1 = new ToolStripMenuItem();
            etatDesRacksStockageToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demandesPréparateursToolStripMenuItem1, etatDesRacksStockageToolStripMenuItem1 });
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(106, 24);
            commandesToolStripMenuItem.Text = "Commandes";
            // 
            // demandesPréparateursToolStripMenuItem1
            // 
            demandesPréparateursToolStripMenuItem1.Name = "demandesPréparateursToolStripMenuItem1";
            demandesPréparateursToolStripMenuItem1.Size = new Size(251, 26);
            demandesPréparateursToolStripMenuItem1.Text = "Demandes préparateurs";
            demandesPréparateursToolStripMenuItem1.Click += demandesPréparateursToolStripMenuItem1_Click;
            // 
            // etatDesRacksStockageToolStripMenuItem1
            // 
            etatDesRacksStockageToolStripMenuItem1.Name = "etatDesRacksStockageToolStripMenuItem1";
            etatDesRacksStockageToolStripMenuItem1.Size = new Size(251, 26);
            etatDesRacksStockageToolStripMenuItem1.Text = "Etat des racks stockage";
            // 
            // Caristes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Caristes";
            Text = "Caristes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem demandesPréparateursToolStripMenuItem1;
        private ToolStripMenuItem etatDesRacksStockageToolStripMenuItem1;
    }
}