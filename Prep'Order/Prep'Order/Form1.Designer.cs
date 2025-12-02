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
            button1 = new Button();
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
            // button1
            // 
            button1.Location = new Point(331, 297);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}
