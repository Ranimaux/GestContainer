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
using GestContainer.Vues;

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

            string libelleDeclaration = textBoxCommentaire.Text;
            bool urgenceDeclaration = checkBoxUrgence.Checked;
            string codeProbleme = ComboBoxProbleme.SelectedValue.ToString();
            


            if (VerificationDuFormulaire() != false)
            {

                DataBase.AjouterUneDeclaration(libelleDeclaration, urgenceDeclaration, codeProbleme);
                MessageBox.Show("La déclaration a été envoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ReinitialiserFormulaire();
        }

        private void FormAjoutDeclaration_Load(object sender, EventArgs e)
        {
            ComboBoxProbleme.SelectedIndexChanged -= ComboBoxProbleme_SelectedIndexChanged;

            ComboBoxProbleme.DataSource = Donnees.CollectionProbleme;
            ComboBoxProbleme.DisplayMember = "libelleProbleme";
            ComboBoxProbleme.ValueMember = "codeProbleme";
            ComboBoxProbleme.SelectedIndex = -1;

            ComboBoxProbleme.SelectedIndexChanged += ComboBoxProbleme_SelectedIndexChanged;

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

        private void ReinitialiserFormulaire()
        {
            textBoxCommentaire.Clear();
            checkBoxUrgence.Checked = false;
            ComboBoxProbleme.SelectedIndex = -1;
        }

        private void ComboBoxProbleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ComboBoxProbleme.SelectedItem is Probleme probleme && probleme.libelleProbleme == "AUTRE")
            {

                DialogResult result = MessageBox.Show("Vous avez sélectionné 'AUTRE'. Souhaitez-vous ajouter un nouveau problème ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    using (FormAjouterProbleme ajoutProbleme = new FormAjouterProbleme())
                    {
                        if (ajoutProbleme.ShowDialog() == DialogResult.OK)
                        {
                            string nouveauLibelle = ajoutProbleme.libelleProbleme;
                            string nouveauCode = ajoutProbleme.codeProbleme;

                            
                            DataBase.AjouterUnProbleme(nouveauCode, nouveauLibelle);

                            
                            Donnees.CollectionProbleme = null; 
                            ComboBoxProbleme.DataSource = Donnees.CollectionProbleme;
                            ComboBoxProbleme.SelectedIndex = -1;

                            MessageBox.Show("Le problème a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if(ajoutProbleme.ShowDialog() == DialogResult.Cancel)
                        {
                            ComboBoxProbleme.SelectedIndex = -1;
                        }
                    }
                }
                else
                {
                    ComboBoxProbleme.SelectedIndex = -1;
                }

                    
                
            }
        }
    }
}
