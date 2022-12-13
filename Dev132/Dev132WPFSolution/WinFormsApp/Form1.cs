using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color initalColor;

        private void Form1_Load(object sender, EventArgs e)
        {
            initalColor = BackColor;
        }

        //Gestionnaire d'évènement lorsque l'événement click se déclenche 
        //le code qui se trouve dans cet méthode (Getionnaire d'evenements s'execute)
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AfficherBtn_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text + "\t" + txtPrenom.Text;
            MessageBox.Show(nom,"La boîte de dialogue d'affichage de nom", MessageBoxButtons.OK);
            File.WriteAllText(@"C:\temp\mon nom.txt",nom);
        }

        private void AfficherBtn_MouseEnter(object sender, EventArgs e)
        {
            //Unboxing
            //Button currentBtn = (Button)sender; //Lève une exception si l'opération de conversion echoue
            Button currentBtn = sender  as Button; //Il y a pas d'excption mais currentBtn = null
            if (currentBtn.Name == "AnnulerBtn")
                AnnulerBtn.BackColor = Color.Red;
            else if (currentBtn.Name == "AfficherBtn")
                AfficherBtn.BackColor = Color.Red;
        }

        private void AfficherBtn_MouseLeave(object sender, EventArgs e)
        {
            Button currentBtn = sender as Button; //Il y a pas d'excption mais currentBtn = null
            if (currentBtn.Name == "AnnulerBtn")
                AnnulerBtn.BackColor = Color.Blue;
            else if (currentBtn.Name == "AfficherBtn")
                AfficherBtn.BackColor = Color.Blue;
        }

        private void txtNom_MouseEnter(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.Yellow;
        }

        private void txtNom_MouseLeave(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.White;
        }

        private void txtPrenom_MouseEnter(object sender, EventArgs e)
        {
            txtPrenom.BackColor = Color.Yellow;
        }

        private void txtPrenom_MouseLeave(object sender, EventArgs e)
        {
            txtPrenom.BackColor = Color.White;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            char pressed = e.KeyChar;
           if(pressed=='R')
            {
               BackColor = Color.Red;
            }
           else if(pressed=='G')
            {
                BackColor = Color.Green;
            }
           else
            {
                BackColor = initalColor;
            }
        }
    }
}
