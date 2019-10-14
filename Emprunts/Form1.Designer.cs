namespace Emprunts
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listRemboursement = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRemboursement = new System.Windows.Forms.Label();
            this.scrollRemboursement = new System.Windows.Forms.HScrollBar();
            this.interetBoite = new System.Windows.Forms.GroupBox();
            this.btnNeuf = new System.Windows.Forms.RadioButton();
            this.btnHuit = new System.Windows.Forms.RadioButton();
            this.btnSept = new System.Windows.Forms.RadioButton();
            this.nbrPaiement = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sommeFinale = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmprunt = new System.Windows.Forms.TextBox();
            this.erreurEmprunt = new System.Windows.Forms.ErrorProvider(this.components);
            this.erreurPeriode = new System.Windows.Forms.ErrorProvider(this.components);
            this.interetBoite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEmprunt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurPeriode)).BeginInit();
            this.SuspendLayout();
            // 
            // listRemboursement
            // 
            this.listRemboursement.Enabled = false;
            this.listRemboursement.FormattingEnabled = true;
            this.listRemboursement.Location = new System.Drawing.Point(44, 301);
            this.listRemboursement.Name = "listRemboursement";
            this.listRemboursement.Size = new System.Drawing.Size(284, 95);
            this.listRemboursement.TabIndex = 0;
            this.listRemboursement.Tag = "";
            this.listRemboursement.SelectedIndexChanged += new System.EventHandler(this.listRemboursement_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capital emprunté";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Durée en mois du remboursement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Périodicité de remboursement";
            // 
            // labelRemboursement
            // 
            this.labelRemboursement.AutoSize = true;
            this.labelRemboursement.Enabled = false;
            this.labelRemboursement.Location = new System.Drawing.Point(174, 173);
            this.labelRemboursement.Name = "labelRemboursement";
            this.labelRemboursement.Size = new System.Drawing.Size(13, 13);
            this.labelRemboursement.TabIndex = 5;
            this.labelRemboursement.Text = "0";
            // 
            // scrollRemboursement
            // 
            this.scrollRemboursement.Enabled = false;
            this.scrollRemboursement.LargeChange = 1;
            this.scrollRemboursement.Location = new System.Drawing.Point(218, 173);
            this.scrollRemboursement.Maximum = 160;
            this.scrollRemboursement.Name = "scrollRemboursement";
            this.scrollRemboursement.Size = new System.Drawing.Size(229, 17);
            this.scrollRemboursement.TabIndex = 6;
            this.scrollRemboursement.ValueChanged += new System.EventHandler(this.scrollRemboursement_ValueChanged);
            // 
            // interetBoite
            // 
            this.interetBoite.Controls.Add(this.btnNeuf);
            this.interetBoite.Controls.Add(this.btnHuit);
            this.interetBoite.Controls.Add(this.btnSept);
            this.interetBoite.Location = new System.Drawing.Point(491, 111);
            this.interetBoite.Name = "interetBoite";
            this.interetBoite.Size = new System.Drawing.Size(86, 161);
            this.interetBoite.TabIndex = 7;
            this.interetBoite.TabStop = false;
            this.interetBoite.Text = "Taux d\'intérêt";
            // 
            // btnNeuf
            // 
            this.btnNeuf.AutoSize = true;
            this.btnNeuf.Location = new System.Drawing.Point(23, 121);
            this.btnNeuf.Name = "btnNeuf";
            this.btnNeuf.Size = new System.Drawing.Size(42, 17);
            this.btnNeuf.TabIndex = 2;
            this.btnNeuf.TabStop = true;
            this.btnNeuf.Tag = "0.09";
            this.btnNeuf.Text = "9 %";
            this.btnNeuf.UseVisualStyleBackColor = true;
            this.btnNeuf.CheckedChanged += new System.EventHandler(this.btn_Change);
            // 
            // btnHuit
            // 
            this.btnHuit.AutoSize = true;
            this.btnHuit.Location = new System.Drawing.Point(23, 80);
            this.btnHuit.Name = "btnHuit";
            this.btnHuit.Size = new System.Drawing.Size(42, 17);
            this.btnHuit.TabIndex = 1;
            this.btnHuit.TabStop = true;
            this.btnHuit.Tag = "0.08";
            this.btnHuit.Text = "8 %";
            this.btnHuit.UseVisualStyleBackColor = true;
            this.btnHuit.CheckedChanged += new System.EventHandler(this.btn_Change);
            // 
            // btnSept
            // 
            this.btnSept.AutoSize = true;
            this.btnSept.Location = new System.Drawing.Point(23, 38);
            this.btnSept.Name = "btnSept";
            this.btnSept.Size = new System.Drawing.Size(42, 17);
            this.btnSept.TabIndex = 0;
            this.btnSept.TabStop = true;
            this.btnSept.Tag = "0.07";
            this.btnSept.Text = "7 %";
            this.btnSept.UseVisualStyleBackColor = true;
            this.btnSept.CheckedChanged += new System.EventHandler(this.btn_Change);
            // 
            // nbrPaiement
            // 
            this.nbrPaiement.AutoSize = true;
            this.nbrPaiement.ForeColor = System.Drawing.Color.Red;
            this.nbrPaiement.Location = new System.Drawing.Point(491, 301);
            this.nbrPaiement.Name = "nbrPaiement";
            this.nbrPaiement.Size = new System.Drawing.Size(13, 13);
            this.nbrPaiement.TabIndex = 8;
            this.nbrPaiement.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Remboursements";
            // 
            // sommeFinale
            // 
            this.sommeFinale.AutoSize = true;
            this.sommeFinale.ForeColor = System.Drawing.Color.Red;
            this.sommeFinale.Location = new System.Drawing.Point(630, 356);
            this.sommeFinale.Name = "sommeFinale";
            this.sommeFinale.Size = new System.Drawing.Size(13, 13);
            this.sommeFinale.TabIndex = 10;
            this.sommeFinale.Text = "0";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(684, 114);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(684, 173);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 52);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Recupérer un exemple d\'emprunt";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(187, 50);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(166, 20);
            this.textName.TabIndex = 13;
            // 
            // textEmprunt
            // 
            this.textEmprunt.Location = new System.Drawing.Point(187, 103);
            this.textEmprunt.MaxLength = 10;
            this.textEmprunt.Name = "textEmprunt";
            this.textEmprunt.Size = new System.Drawing.Size(166, 20);
            this.textEmprunt.TabIndex = 14;
            this.textEmprunt.TextChanged += new System.EventHandler(this.textEmprunt_TextChanged);
            this.textEmprunt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmprunt_KeyPress);
            // 
            // erreurEmprunt
            // 
            this.erreurEmprunt.ContainerControl = this;
            // 
            // erreurPeriode
            // 
            this.erreurPeriode.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEmprunt);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.sommeFinale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nbrPaiement);
            this.Controls.Add(this.interetBoite);
            this.Controls.Add(this.scrollRemboursement);
            this.Controls.Add(this.labelRemboursement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listRemboursement);
            this.Name = "Form1";
            this.Text = "Emprunt";
            this.interetBoite.ResumeLayout(false);
            this.interetBoite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEmprunt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erreurPeriode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRemboursement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRemboursement;
        private System.Windows.Forms.HScrollBar scrollRemboursement;
        private System.Windows.Forms.GroupBox interetBoite;
        private System.Windows.Forms.RadioButton btnNeuf;
        private System.Windows.Forms.RadioButton btnHuit;
        private System.Windows.Forms.RadioButton btnSept;
        private System.Windows.Forms.Label nbrPaiement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sommeFinale;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmprunt;
        private System.Windows.Forms.ErrorProvider erreurEmprunt;
        private System.Windows.Forms.ErrorProvider erreurPeriode;
    }
}

