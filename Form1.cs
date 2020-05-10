using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagMoy
{

    public partial class frmSaisieCal : Form
    {
        public frmSaisieCal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void Ajout(Stagiaire TStagiaire)
            {
                List<string> TStagiaire = new List<string>();
                TStagiaire.Add(txtNumInsc);
                TStagiaire.Add(txtNom);
                TStagiaire.Add(txtPrenom);
                TStagiaire.Add(txtNote1);
                TStagiaire.Add(txtNote2);
                TStagiaire.Add(txtMoy);
                MessageBox.Show("Réussi");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMoy_TextChanged(object sender, EventArgs e)
        {
            this.txtMoy = Stagiaire.CALCUL.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
