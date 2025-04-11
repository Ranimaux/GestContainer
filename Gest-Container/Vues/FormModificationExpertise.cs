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

namespace GestContainer.Vues
{
    public partial class FormModificationExpertise : Form
    {
        private int _numExpertise;
        private string _status;

        public FormModificationExpertise(int numExpertise, DateTime dateConstat, string commentaireConstatation, string contactResponsable,string status)
        {
            InitializeComponent();
            this._numExpertise = numExpertise;
            dateTimeDateConstat.Value = dateConstat;
            textBoxcommentaireConstatation.Text = commentaireConstatation;
            textBoxContactResponsable.Text = contactResponsable;
            this._status = status;
        }

        private void FormModificationExpertise_Load(object sender, EventArgs e)
        {
            RefreshCollectionDeclaration();

            dataGridViewListDeclaration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListDeclaration.MultiSelect = false;
            dataGridViewListDeclaration.ReadOnly = true;
            dataGridViewListDeclaration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            // Vérification que le champ commentaire n'est pas vide ou dépasse 255 caractères.
            if (string.IsNullOrWhiteSpace(textBoxcommentaireConstatation.Text) && textBoxcommentaireConstatation.Text.Length > 255)
            {
                MessageBox.Show("Le champ commentaire ne doit vide ou dépasser 255 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxcommentaireConstatation.Focus();
                formChecked = false;
            }
            // Vérification que le champ commentaire n'est pas vide ou dépasse 255 caractères.
            if (string.IsNullOrWhiteSpace(textBoxContactResponsable.Text) && textBoxContactResponsable.Text.Length > 255)
            {
                MessageBox.Show("Le champ contact ne doit être vide ou dépasser 255 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContactResponsable.Focus();
                formChecked = false;
            }

            // Vérification que la demande expertise n'a pas été traitée.
            if (this._status == "traité")
            {
                MessageBox.Show("La demande expertise a était déjà traité, elle ne peut être modifiée.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formChecked = false;
            }
            return formChecked;
        }

        private void buttonValModif_Click(object sender, EventArgs e)
        {
            if (dataGridViewListDeclaration.SelectedRows.Count > 0)
            {
                var row = dataGridViewListDeclaration.SelectedRows[0];
                int codeDeclaration = (int)row.Cells["codeDeclaration"].Value;

                if (VerificationDuFormulaire() != false)
                {
                    try
                    {
                        int numExpertise = this._numExpertise;
                        DateTime dateConstat = dateTimeDateConstat.Value;
                        string commentaireConstat = textBoxcommentaireConstatation.Text;
                        string contactResp = textBoxContactResponsable.Text;
                        DataBase.ModifierDemandeExpertise(numExpertise, dateConstat, commentaireConstat, contactResp, codeDeclaration);
                        MessageBox.Show("La demande expertise a été envoyé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est sevenue lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une ligne complète dans liste dans de déclaration", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelModif_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
