using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonjour
{
    public partial class Age : Form
    {
        public string Identite;
        public Age()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Age_Shown(object sender, EventArgs e)
        {
            lblTitre.Text = Identite + lblTitre.Text;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string annee = txtDateNaissance.Text.Substring(6, 4);
            int nbAnnees = DateTime.Now.Year - Int16.Parse(annee);
            MessageBox.Show(Identite + " vous avez : " + nbAnnees.ToString() + " ans");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
