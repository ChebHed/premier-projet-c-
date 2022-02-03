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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bonjour " + txtPrn.Text + " " + txtNom.Text);
            Age age = new Age();
            age.Identite = txtPrn.Text + " " + " " + txtNom.Text;
            age.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
