namespace Prep_Order
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            identifiant = new TextBox();
            mdp = new TextBox();
            btn_connexion = new Button();
            SuspendLayout();
            // 
            // identifiant
            // 
            identifiant.Location = new Point(319, 156);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(125, 27);
            identifiant.TabIndex = 0;
            identifiant.Text = "Identifiant";
            // 
            // mdp
            // 
            mdp.Location = new Point(319, 225);
            mdp.Name = "mdp";
            mdp.Size = new Size(125, 27);
            mdp.TabIndex = 1;
            mdp.Text = "Mot de passe";
            // 
            // btn_connexion
            // 
            btn_connexion.Location = new Point(331, 297);
            btn_connexion.Name = "btn_connexion";
            btn_connexion.Size = new Size(94, 29);
            btn_connexion.TabIndex = 2;
            btn_connexion.Text = "Connexion";
            btn_connexion.UseVisualStyleBackColor = true;
            btn_connexion.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_connexion);
            Controls.Add(mdp);
            Controls.Add(identifiant);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox identifiant;
        private TextBox mdp;
        private Button btn_connexion;
    }
}
