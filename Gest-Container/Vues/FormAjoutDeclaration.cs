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
        // Boutton Paramètre qui fait le traitement du formulaire en récupérant le champ textBoxCommentaire, checkBoxUrgence et comboBoxProbleme.
        // fait une vérification que si les champs ne sont pas null ou vide.
        // envoi les élément saisi, coché et sélectionner par l'utilisateur dans la méthode AjouterUneDeclaration de la class DataBase.
        // envoi un messageBox au client une comfirmation de l'envoi si pas d'erreur pendant le traitement.
        // Puis dans tous les cas réinitialise le formulaire.
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

        // la méthode d'événement du chargement de la page effectue :
        // En premier lieu, il suspend l'événement au moment de changer l'index du comboBox.
        // Initialisation du comboBox avec les données de la CollectionProbleme.
        // l'affichage du DisplayMember (ce que l'utilisateur voit) par le champ "libelleProbleme" venant de la table Probleme de la base de donnée.
        // l'affichage hors champ des ValueMember (ce que l'utilisateur ne voit pas) par le champ "codeProbleme" venant de la tablae Probleme de la base de donnée.
        // le choix comboBox est mis vide (-1) pour laissez le choix libre à l'utilisateur.
        // fin de suspension de l'événement au moment de changer l'index du comboBox.

        private void FormAjoutDeclaration_Load(object sender, EventArgs e)
        {
            ComboBoxProbleme.SelectedIndexChanged -= ComboBoxProbleme_SelectedIndexChanged;

            ComboBoxProbleme.DataSource = Donnees.CollectionProbleme;
            ComboBoxProbleme.DisplayMember = "libelleProbleme";
            ComboBoxProbleme.ValueMember = "codeProbleme";
            ComboBoxProbleme.SelectedIndex = -1;

            ComboBoxProbleme.SelectedIndexChanged += ComboBoxProbleme_SelectedIndexChanged;

        }

        // la méthode bool VerificationDuFormulaire()
        // vérifie les champs saisi par l'utilisateur si sont pas null ou vide sinon il garde la variable bool true.

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

        // La méthode void ReinitialiserFormulaire()
        // remet a zéro les différents champs du formulaire.

        private void ReinitialiserFormulaire()
        {
            textBoxCommentaire.Clear();
            checkBoxUrgence.Checked = false;
            ComboBoxProbleme.SelectedIndex = -1;
        }

        // La méthode événement changement de l'index s'enclenche quand l'utilisateur sélectionne "AUTRE"
        // Lui demande s'il veut ajouter un nouveau Probleme sinon il revient en arrière et met à zéro le comboBox
        // S'il dit oui, alors ouvre un formulaire qui permet d'ajouter un Probleme dans la base de données.
        // les valeurs du formulaire FormAjouterProbleme sont mis dans deux variable string (nouveauLibelle et nouveauCode)
        // Avec ses deux variables, sont envoyé en paramètre dans la méthode AjouterUnProbleme de la classe DataBase pour l'ajouter dans la base de donnée.
        // Après réactualise le comboBox pour que l'utilisateur sélectionne le problème qui a saisi en lui précisant que son Probleme a été bien ajouter.
        

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
