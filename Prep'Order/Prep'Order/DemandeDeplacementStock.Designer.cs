namespace Prep_Order
{
    partial class DemandeDeplacementStock
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
            label1 = new Label();
            cb1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lv1
            // 
            lv1.Columns.AddRange(new ColumnHeader[] { CodeEmplacement, Zone, Produit, columnHeader4 });
            lv1.Location = new Point(125, 21);
            lv1.Name = "lv1";
            lv1.Size = new Size(576, 251);
            lv1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 401);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Caristes choisi :";
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(166, 398);
            cb1.Name = "cb1";
            cb1.Size = new Size(151, 28);
            cb1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(602, 398);
            button1.Name = "button1";
            button1.Size = new Size(180, 29);
            button1.TabIndex = 4;
            button1.Text = "Faire la demande";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DemandeDeplacementStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 471);
            Controls.Add(button1);
            Controls.Add(cb1);
            Controls.Add(label1);
            Controls.Add(lv1);
            Name = "DemandeDeplacementStock";
            Text = "DemandeDeplacementStock";
            Load += DemandeDeplacementStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv1;
        private ColumnHeader CodeEmplacement;
        private ColumnHeader Zone;
        private ColumnHeader Produit;
        private ColumnHeader columnHeader4;
        private Label label1;
        private ComboBox cb1;
        private Button button1;
    }
}