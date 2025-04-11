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
    public partial class FormAjouterDemandeExpertise : Form
    {
        public FormAjouterDemandeExpertise()
        {
            InitializeComponent();
        }

        private void FormAjouterDemandeExpertise_Load(object sender, EventArgs e)
        {
            RefreshCollectionDeclaration();

            dataGridViewListDeclaration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListDeclaration.MultiSelect = false;
            dataGridViewListDeclaration.ReadOnly = true;
            dataGridViewListDeclaration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonDemandeExpertise_Click(object sender, EventArgs e)
        {

            
            
            string commentaireConstatation = textBoxCommentaireConstatation.Text;
            string contactResponsable = textBoxContactResponsable.Text;
            DateTime dateConstat = dateTimeDateConstat.Value;

            if (dataGridViewListDeclaration.SelectedRows.Count > 0)
            {
                var row = dataGridViewListDeclaration.SelectedRows[0];
                int codeDeclaration = (int)row.Cells["codeDeclaration"].Value;

                if (VerificationDuFormulaire() != false)
                {
                    try
                    {
                        DataBase.AjouterUneDemandeExpertise(dateConstat, commentaireConstatation, contactResponsable, codeDeclaration);
                        MessageBox.Show("La demande expertise a été envoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReinitialiserFormulaire();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est sevenue lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une ligne complète dans liste dans de déclaration", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void RefreshCollectionDeclaration()
        {
            // Recharge les déclarations depuis la base de données.

            Donnees.CollectionDeclaration = DataBase.ConsultationDesDeclarations();

            // Met à jour la source de données du DataGridView avec la nouvelle collection.

            dataGridViewListDeclaration.DataSource = null;
            dataGridViewListDeclaration.DataSource = Donnees.CollectionDeclaration;
        }

        private bool VerificationDuFormulaire()
        {
            bool formChecked = true;

            if (string.IsNullOrWhiteSpace(textBoxCommentaireConstatation.Text) && textBoxCommentaireConstatation.Text.Length > 255)
            {
                MessageBox.Show("Le champ commentaire constatation ne doit vide ou dépasser 255 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommentaireConstatation.Focus();
                formChecked = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxContactResponsable.Text) && textBoxContactResponsable.Text.Length > 255)
            {
                MessageBox.Show("Le champ contact responsable ne doit vide ou dépasser 255 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommentaireConstatation.Focus();
                formChecked = false;
            }

            return formChecked;
        }

        // La méthode void ReinitialiserFormulaire()
        // remet a zéro les différents champs du formulaire.

        private void ReinitialiserFormulaire()
        {
            textBoxCommentaireConstatation.Clear();
            textBoxContactResponsable.Clear();
            dateTimeDateConstat.ResetText();
        }
    }
}
