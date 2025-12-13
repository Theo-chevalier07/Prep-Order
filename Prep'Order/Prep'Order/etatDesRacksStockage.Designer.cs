namespace Prep_Order
{
    partial class etatDesRacksStockage
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
            lv1 = new ListView();
            CodeEmplacement = new ColumnHeader();
            Zone = new ColumnHeader();
            Produit = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // lv1
            // 
            lv1.Columns.AddRange(new ColumnHeader[] { CodeEmplacement, Zone, Produit, columnHeader4 });
            lv1.Location = new Point(90, 73);
            lv1.Name = "lv1";
            lv1.Size = new Size(576, 251);
            lv1.TabIndex = 0;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.View = View.Details;
            // 
            // CodeEmplacement
            // 
            CodeEmplacement.Text = "CodeEmplacement";
            CodeEmplacement.Width = 100;
            // 
            // Zone
            // 
            Zone.Text = "Zone";
            Zone.Width = 100;
            // 
            // Produit
            // 
            Produit.Text = "Produit";
            Produit.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Quantite";
            columnHeader4.Width = 100;
            // 
            // etatDesRacksStockage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lv1);
            Name = "etatDesRacksStockage";
            Text = "etatDesRacksStockage";
            Load += etatDesRacksStockage_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lv1;
        private ColumnHeader CodeEmplacement;
        private ColumnHeader Zone;
        private ColumnHeader Produit;
        private ColumnHeader columnHeader4;
    }
}