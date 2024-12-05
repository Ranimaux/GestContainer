using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestContainer.Resources;
using GestContainer.Modele;
using GestContainer.Vues;

namespace GestContainer.Vues
{
    // Classe FormModificationDeclaration qui hérite de la classe Form. 
    // Ce formulaire est utilisé pour modifier une déclaration existante.
    // Il contient des champs privés pour gérer les informations spécifiques d'une déclaration.
    public partial class FormModificationDeclaration : Form
    {
        // Champ privé pour stocker le code unique de la déclaration.
        private int _codeDeclaration;
        // Champ privé pour indiquer si la déclaration a déjà été traitée.
        private bool _traite;

        /// <summary>
        /// Constructeur de la classe FormModificationDeclaration.
        /// Initialise le formulaire avec les données d'une déclaration existante.
        /// </summary>
        /// <param name="codeDeclaration">Code unique de la déclaration.</param>
        /// <param name="commentaireDeclaration">Commentaire associé à la déclaration.</param>
        /// <param name="dateDeclaration">Date de la déclaration.</param>
        /// <param name="urgence">Indique si la déclaration est urgente.</param>
        /// <param name="traite">Indique si la déclaration a déjà été traitée.</param>

        public FormModificationDeclaration(int codeDeclaration, string commentaireDeclaration, DateTime dateDeclaration, bool urgence, bool traite)
        {
            
            InitializeComponent();
            // Initialisation des champs privés et des contrôles du formulaire avec les valeurs passées en paramètre.
            this._codeDeclaration = codeDeclaration;
            textBoxCommentaireDeclaration.Text = commentaireDeclaration;
            dateTimePickerDateDeclaration.Value = dateDeclaration;
            checkBoxUrgence.Checked = urgence;
            this._traite = traite;
        }
        private void FormModificationDeclaration_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Méthode associée au clic sur le bouton de modification.
        /// Effectue les vérifications nécessaires, puis met à jour la déclaration dans la base de données.
        /// </summary>
        
        private void buttonModificationDeclaration_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs des contrôles du formulaire.
            string commentaireDeclaration = textBoxCommentaireDeclaration.Text;
            DateTime dateDeclaration = dateTimePickerDateDeclaration.Value;
            bool Urgence = checkBoxUrgence.Checked;
            int codeDeclaration = this._codeDeclaration;

            // Vérification des données du formulaire avant modification.
            if (VerificationDuFormulaire() != false)
            {
                // Appel à la méthode pour modifier la déclaration dans la base de données.
                DataBase.ModifierUneDeclaration(codeDeclaration, commentaireDeclaration, Urgence);

                // Affichage d'un message de succès à l'utilisateur.
                DialogResult = DialogResult.OK;
                MessageBox.Show("La déclaration a été modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Fermeture du formulaire après modification.
                Close();
            }
        }

        /// <summary>
        /// Méthode associée au clic sur le bouton d'annulation.
        /// Ferme le formulaire sans enregistrer de modifications.
        /// </summary>
        private void buttonAnnulationDeclaration_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Vérifie si les données du formulaire sont valides avant de procéder à la modification.
        /// </summary>
        /// <returns>True si les données sont valides, sinon False.</returns>
        private bool VerificationDuFormulaire()
        {
            bool formChecked = true;

            // Vérification que le champ commentaire n'est pas vide, dépasse 100 caractères ou est vide.
            if (string.IsNullOrWhiteSpace(textBoxCommentaireDeclaration.Text) && textBoxCommentaireDeclaration.Text.Length < 0 && textBoxCommentaireDeclaration.Text.Length > 100)
            {
                MessageBox.Show("Le champ commentaire ne doit vide ou dépasser 100 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommentaireDeclaration.Focus();
                formChecked = false;
            }

            // Vérification que la date de la déclaration ne dépasse pas 7 jours par rapport à la date actuelle.
            if ((DateTime.Now - dateTimePickerDateDeclaration.Value).TotalDays > 7)
            {
                MessageBox.Show("La déclaration ne peut être modifiée car elle remonte à plus de 7 jours.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formChecked = false;
            }

            // Vérification que la déclaration n'a pas déjà été traitée.
            if (this._traite == true)
            {
                MessageBox.Show("La déclaration a était déjà traité, elle ne peut être modifiée.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formChecked = false;
            }

            return formChecked;
        }
    }
}
