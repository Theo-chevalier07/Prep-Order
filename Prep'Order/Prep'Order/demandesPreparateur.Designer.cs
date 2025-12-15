namespace Prep_Order
{
    partial class demandesPreparateur
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
            Produit = new ColumnHeader();
            Quantité = new ColumnHeader();
            Zone = new ColumnHeader();
            button1 = new Button();
            ID = new ColumnHeader();
            SuspendLayout();
            // 
            // lv1
            // 
            lv1.Columns.AddRange(new ColumnHeader[] { ID, Produit, Quantité, Zone });
            lv1.Location = new Point(90, 64);
            lv1.Name = "lv1";
            lv1.Size = new Size(404, 550);
            lv1.TabIndex = 0;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.View = View.Details;
            // 
            // Produit
            // 
            Produit.Text = "Produit";
            // 
            // Quantité
            // 
            Quantité.Text = "Quantité";
            // 
            // Zone
            // 
            Zone.Text = "Zone";
            // 
            // button1
            // 
            button1.Location = new Point(638, 518);
            button1.Name = "button1";
            button1.Size = new Size(152, 96);
            button1.TabIndex = 1;
            button1.Text = "confirmation du déplacement";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // demandesPreparateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 681);
            Controls.Add(button1);
            Controls.Add(lv1);
            Name = "demandesPreparateur";
            Text = "demandesPreparateur";
            Load += demandesPreparateur_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lv1;
        private ColumnHeader Produit;
        private ColumnHeader Quantité;
        private ColumnHeader Zone;
        private Button button1;
        private ColumnHeader ID;
    }
}