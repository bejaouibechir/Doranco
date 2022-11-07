using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonProjetWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Champs privées
        string _prenom;
        string _nomdefamille;

        //Un gestionnaire d'événement
        private void button1_Click(object sender, EventArgs e)
        {
            _prenom = txtPrenom.Text;
            _nomdefamille = txtNomFamille.Text;
            lblResultat.Text = $"Nom: {_nomdefamille} Prénom:{_prenom}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNom_mousEnter(object sender, EventArgs e)
        {
            txtPrenom.BackColor = Color.Yellow;
        }

        private void txtNom_mousLeave(object sender, EventArgs e)
        {
            txtPrenom.BackColor = Color.White;
        }

        private void txtPrenom_keydown(object sender, KeyEventArgs e)
        {
           if(e.KeyData == Keys.H)
            {
                //Executer un code
                txtPrenom.BackColor = Color.Red;
            }
        }

        private void form_loaded(object sender, EventArgs e)
        {

        }

        private void form_paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Brushes.Red);
            PointF[] ptsArray =
              {
                    new PointF(20.0F, 20.0F),
                    new PointF (20.0F, 20.0F),
                    new PointF (200.0F, 200.0F),
                    new PointF (20.0F, 20.0F)
              };

            e.Graphics.DrawLines(redPen, ptsArray);

        }
    }
}
