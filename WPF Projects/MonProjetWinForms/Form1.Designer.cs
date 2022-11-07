namespace MonProjetWinForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.AffciherBtn = new System.Windows.Forms.Button();
            this.QuitterBtn = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtNomFamille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de famille";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.Location = new System.Drawing.Point(192, 25);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(215, 20);
            this.txtPrenom.TabIndex = 2;
            this.txtPrenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrenom_keydown);
            this.txtPrenom.MouseEnter += new System.EventHandler(this.txtNom_mousEnter);
            this.txtPrenom.MouseLeave += new System.EventHandler(this.txtNom_mousLeave);
            // 
            // AffciherBtn
            // 
            this.AffciherBtn.Location = new System.Drawing.Point(332, 101);
            this.AffciherBtn.Name = "AffciherBtn";
            this.AffciherBtn.Size = new System.Drawing.Size(75, 23);
            this.AffciherBtn.TabIndex = 4;
            this.AffciherBtn.Text = "Afficher";
            this.AffciherBtn.UseVisualStyleBackColor = true;
            this.AffciherBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitterBtn
            // 
            this.QuitterBtn.Location = new System.Drawing.Point(240, 101);
            this.QuitterBtn.Name = "QuitterBtn";
            this.QuitterBtn.Size = new System.Drawing.Size(75, 23);
            this.QuitterBtn.TabIndex = 5;
            this.QuitterBtn.Text = "Quitter";
            this.QuitterBtn.UseVisualStyleBackColor = true;
            this.QuitterBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.Blue;
            this.lblResultat.Location = new System.Drawing.Point(236, 145);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(51, 20);
            this.lblResultat.TabIndex = 6;
            this.lblResultat.Text = "label3";
            // 
            // txtNomFamille
            // 
            this.txtNomFamille.BackColor = System.Drawing.Color.White;
            this.txtNomFamille.Location = new System.Drawing.Point(192, 60);
            this.txtNomFamille.Name = "txtNomFamille";
            this.txtNomFamille.Size = new System.Drawing.Size(215, 20);
            this.txtNomFamille.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 174);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.QuitterBtn);
            this.Controls.Add(this.AffciherBtn);
            this.Controls.Add(this.txtNomFamille);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulaire ";
            this.Load += new System.EventHandler(this.form_loaded);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.form_paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button AffciherBtn;
        private System.Windows.Forms.Button QuitterBtn;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtNomFamille;
    }
}

