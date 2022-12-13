namespace WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.AfficherBtn = new System.Windows.Forms.Button();
            this.AnnulerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(159, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(231, 20);
            this.txtNom.TabIndex = 2;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNom.MouseEnter += new System.EventHandler(this.txtNom_MouseEnter);
            this.txtNom.MouseLeave += new System.EventHandler(this.txtNom_MouseLeave);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(159, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(231, 20);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.MouseEnter += new System.EventHandler(this.txtPrenom_MouseEnter);
            this.txtPrenom.MouseLeave += new System.EventHandler(this.txtPrenom_MouseLeave);
            // 
            // AfficherBtn
            // 
            this.AfficherBtn.BackColor = System.Drawing.Color.Blue;
            this.AfficherBtn.ForeColor = System.Drawing.Color.White;
            this.AfficherBtn.Location = new System.Drawing.Point(315, 114);
            this.AfficherBtn.Name = "AfficherBtn";
            this.AfficherBtn.Size = new System.Drawing.Size(75, 23);
            this.AfficherBtn.TabIndex = 4;
            this.AfficherBtn.Text = "Afficher";
            this.AfficherBtn.UseVisualStyleBackColor = false;
            this.AfficherBtn.Click += new System.EventHandler(this.AfficherBtn_Click);
            this.AfficherBtn.MouseEnter += new System.EventHandler(this.AfficherBtn_MouseEnter);
            this.AfficherBtn.MouseLeave += new System.EventHandler(this.AfficherBtn_MouseLeave);
            // 
            // AnnulerBtn
            // 
            this.AnnulerBtn.BackColor = System.Drawing.Color.Blue;
            this.AnnulerBtn.ForeColor = System.Drawing.Color.White;
            this.AnnulerBtn.Location = new System.Drawing.Point(219, 114);
            this.AnnulerBtn.Name = "AnnulerBtn";
            this.AnnulerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnnulerBtn.TabIndex = 5;
            this.AnnulerBtn.Text = "Annuler";
            this.AnnulerBtn.UseVisualStyleBackColor = false;
            this.AnnulerBtn.Click += new System.EventHandler(this.AnnulerBtn_Click);
            this.AnnulerBtn.MouseEnter += new System.EventHandler(this.AfficherBtn_MouseEnter);
            this.AnnulerBtn.MouseLeave += new System.EventHandler(this.AfficherBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 156);
            this.Controls.Add(this.AnnulerBtn);
            this.Controls.Add(this.AfficherBtn);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button AfficherBtn;
        private System.Windows.Forms.Button AnnulerBtn;
    }
}

