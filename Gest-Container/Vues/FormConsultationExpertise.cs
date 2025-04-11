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
    public partial class FormConsultationExpertise : Form
    {
        public FormConsultationExpertise()
        {
            InitializeComponent();
        }

        private void FormConsultationExpertise_Load(object sender, EventArgs e)
        {
            RefreshCollectionExpertise();

            dataGridViewListExpertise.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListExpertise.MultiSelect = false;
            dataGridViewListExpertise.ReadOnly = true;
            dataGridViewListExpertise.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshCollectionExpertise()
        {
            // Recharge les déclarations depuis la base de données.

            Donnees.CollectionExpertise = DataBase.ConsultationDesDemandeExpertise();

            // Met à jour la source de données du DataGridView avec la nouvelle collection.

            dataGridViewListExpertise.DataSource = null;
            dataGridViewListExpertise.DataSource = Donnees.CollectionExpertise;
        }

        private void buttonModification_Click(object sender, EventArgs e)
        {
            if (dataGridViewListExpertise.SelectedRows.Count > 0)
            {
                // Récupère la première ligne sélectionnée.
                var row = dataGridViewListExpertise.SelectedRows[0];

                // Extraction des données de la déclaration depuis la ligne sélectionnée.
                int numExpertise = (int)row.Cells["numExpertise"].Value;
                DateTime dateConstat = (DateTime)row.Cells["dateConstat"].Value;
                string commentaireConstatation = row.Cells["commentaireConstatation"].Value.ToString();
                string contactResponsable = row.Cells["contactResponsable"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();

                // Création et affichage d'une instance du formulaire de modification avec les données de la déclaration.

                using (FormModificationExpertise modificationExpertise = new FormModificationExpertise(numExpertise, dateConstat, commentaireConstatation, contactResponsable, status))
                {
                    // Si la modification a été validée, rafraîchir la collection de déclarations.

                    if (modificationExpertise.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCollectionExpertise();
                    }
                }

            }
            else
            {
                // Affiche un message d'avertissement si toute la ligne n'est sélectionnée.

                MessageBox.Show("Vous devez sélectionner une ligne complète", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
