namespace StagMoy
{
    partial class frmSaisieCal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDonnees = new System.Windows.Forms.GroupBox();
            this.txtMoy = new System.Windows.Forms.TextBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.txtNumInsc = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblMoy = new System.Windows.Forms.Label();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumInsc = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpDonnees.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDonnees
            // 
            this.grpDonnees.Controls.Add(this.txtMoy);
            this.grpDonnees.Controls.Add(this.txtNote2);
            this.grpDonnees.Controls.Add(this.txtNote1);
            this.grpDonnees.Controls.Add(this.txtNumInsc);
            this.grpDonnees.Controls.Add(this.txtNom);
            this.grpDonnees.Controls.Add(this.txtPrenom);
            this.grpDonnees.Controls.Add(this.lblMoy);
            this.grpDonnees.Controls.Add(this.lblNote2);
            this.grpDonnees.Controls.Add(this.lblNote1);
            this.grpDonnees.Controls.Add(this.lblPrenom);
            this.grpDonnees.Controls.Add(this.lblNom);
            this.grpDonnees.Controls.Add(this.lblNumInsc);
            this.grpDonnees.Location = new System.Drawing.Point(51, 89);
            this.grpDonnees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDonnees.Name = "grpDonnees";
            this.grpDonnees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDonnees.Size = new System.Drawing.Size(365, 415);
            this.grpDonnees.TabIndex = 0;
            this.grpDonnees.TabStop = false;
            this.grpDonnees.Text = "Données";
            this.grpDonnees.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMoy
            // 
            this.txtMoy.Location = new System.Drawing.Point(212, 353);
            this.txtMoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoy.Name = "txtMoy";
            this.txtMoy.Size = new System.Drawing.Size(132, 22);
            this.txtMoy.TabIndex = 11;
            this.txtMoy.TextChanged += new System.EventHandler(this.txtMoy_TextChanged);
            // 
            // txtNote2
            // 
            this.txtNote2.Location = new System.Drawing.Point(212, 294);
            this.txtNote2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(132, 22);
            this.txtNote2.TabIndex = 10;
            // 
            // txtNote1
            // 
            this.txtNote1.Location = new System.Drawing.Point(212, 239);
            this.txtNote1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(132, 22);
            this.txtNote1.TabIndex = 9;
            // 
            // txtNumInsc
            // 
            this.txtNumInsc.Location = new System.Drawing.Point(212, 52);
            this.txtNumInsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumInsc.Name = "txtNumInsc";
            this.txtNumInsc.Size = new System.Drawing.Size(132, 22);
            this.txtNumInsc.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(212, 113);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(212, 176);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(132, 22);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblMoy
            // 
            this.lblMoy.AutoSize = true;
            this.lblMoy.Location = new System.Drawing.Point(31, 357);
            this.lblMoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoy.Name = "lblMoy";
            this.lblMoy.Size = new System.Drawing.Size(64, 16);
            this.lblMoy.TabIndex = 5;
            this.lblMoy.Text = "Moyenne";
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.Location = new System.Drawing.Point(31, 298);
            this.lblNote2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(47, 16);
            this.lblNote2.TabIndex = 4;
            this.lblNote2.Text = "Note 2";
            this.lblNote2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.Location = new System.Drawing.Point(31, 242);
            this.lblNote1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(47, 16);
            this.lblNote1.TabIndex = 3;
            this.lblNote1.Text = "Note 1";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(31, 180);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            this.lblPrenom.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(31, 117);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNumInsc
            // 
            this.lblNumInsc.AutoSize = true;
            this.lblNumInsc.Location = new System.Drawing.Point(31, 55);
            this.lblNumInsc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumInsc.Name = "lblNumInsc";
            this.lblNumInsc.Size = new System.Drawing.Size(119, 16);
            this.lblNumInsc.TabIndex = 0;
            this.lblNumInsc.Text = "Numéro inscription";
            this.lblNumInsc.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.btnQuitter);
            this.grpOperations.Controls.Add(this.btnAfficher);
            this.grpOperations.Controls.Add(this.btnAjouter);
            this.grpOperations.Location = new System.Drawing.Point(755, 106);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOperations.Size = new System.Drawing.Size(267, 380);
            this.grpOperations.TabIndex = 1;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Opérations";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(81, 300);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(81, 182);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(100, 28);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(81, 63);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSaisieCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpDonnees);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSaisieCal";
            this.Text = "Saisie & Calcul Moyenne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDonnees.ResumeLayout(false);
            this.grpDonnees.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDonnees;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumInsc;
        private System.Windows.Forms.Label lblMoy;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtMoy;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.TextBox txtNumInsc;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAjouter;
    }
}

