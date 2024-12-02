using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestContainer.Vues
{
    public partial class FormAjouterProbleme : Form
    {
        public string codeProbleme { get; private set; }
        public string libelleProbleme { get; private set; }
        public FormAjouterProbleme()
        {
            InitializeComponent();
        }

        private void ButtonAjouterProbleme_Click(object sender, EventArgs e)
        {
            libelleProbleme = textBoxLibelleProbleme.Text;

            if (!string.IsNullOrWhiteSpace(libelleProbleme))
            {
                codeProbleme = string.Concat(libelleProbleme
                    .Split(' ', '-', '_')
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Select(s => s[0]))
                    .ToUpper();

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Le libelle de probleme ne doit être vide.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAnnulerProbleme_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
