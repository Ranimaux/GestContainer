using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestContainer.Modele;
using GestContainer.Resources;

namespace GestContainer.Vues
{
    public partial class FormAjoutDeclaration : Form
    {
        public FormAjoutDeclaration()
        {
            InitializeComponent();
        }

        private void ButtonAjoutDeclaration_Click(object sender, EventArgs e)
        {
            int codeDeclaration = int.Parse(textBoxNumeroDeclaration.Text);
            string libelleDeclaration = textBoxCommentaire.Text;
            bool urgenceDeclaration = checkBoxUrgence.Checked;

            if(VerificationDuFormulaire() != false)
            {
                DataBase.AjouterUneDeclaration(codeDeclaration, libelleDeclaration, urgenceDeclaration);
            }
        }

        private void textBoxNumeroDeclaration_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAjoutDeclaration_Load(object sender, EventArgs e)
        {
            int max = 0;
            foreach(Declaration item in Donnees.CollectionDeclaration)
            {
                if(item.codeDeclaration > max)
                {
                    max = item.codeDeclaration;
                }
                textBoxNumeroDeclaration.Text = Convert.ToString(max + 1);
            }
        }

        private bool VerificationDuFormulaire()
        {
            bool formChecked = true;

            if (textBoxCommentaire.Text.Length < 0 && textBoxCommentaire.Text.Length > 100)
            {
                MessageBox.Show("Le champ commentaire ne doit vide ou dépasser 100 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommentaire.Text = "";
                textBoxCommentaire.Focus();
                formChecked = false;
            }

            return formChecked;
        }
    }
}
