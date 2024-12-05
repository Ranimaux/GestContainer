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
    // Classe FormConsultationDeclaration qui hérite de la classe Form.
    // Ce formulaire permet de consulter la liste des déclarations et de les modifier.
    public partial class FormConsultationDeclaration : Form
    {
        /// <summary>
        /// Constructeur par défaut du formulaire FormConsultationDeclaration.
        /// Initialise les composants de l'interface utilisateur.
        /// </summary>
        public FormConsultationDeclaration()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Événement déclenché lors du chargement du formulaire.
        /// Initialise le DataGridView avec les données des déclarations.
        /// </summary>
        private void FormConsultationDeclaration_Load(object sender, EventArgs e)
        {
            // Réinitialise la source de données du DataGridView.
            dataGridViewListDeclaration.DataSource = null;

            // Lie la collection de déclarations à afficher au DataGridView.
            dataGridViewListDeclaration.DataSource = Donnees.CollectionDeclaration;
        }

        /// <summary>
        /// Méthode associée au clic sur le bouton de modification.
        /// Permet de modifier une déclaration sélectionnée dans le DataGridView.
        /// </summary>
        private void buttonModification_Click(object sender, EventArgs e)
        {
            // Vérifie qu'au moins une ligne est sélectionnée dans le DataGridView.

            if (dataGridViewListDeclaration.SelectedRows.Count > 0)
            {            
                // Récupère la première ligne sélectionnée.
                var row = dataGridViewListDeclaration.SelectedRows[0];

                // Extraction des données de la déclaration depuis la ligne sélectionnée.
                int codeDeclaration = (int)row.Cells["codeDeclaration"].Value;
                string commentaireDeclaration = row.Cells["commentaireDeclaration"].Value.ToString();
                DateTime dateDeclaration = (DateTime)row.Cells["dateDeclaration"].Value;
                bool urgence = (bool)row.Cells["urgence"].Value;
                bool traite = (bool)row.Cells["traite"].Value;

                // Création et affichage d'une instance du formulaire de modification avec les données de la déclaration.

                using (FormModificationDeclaration modificationDeclaration = new FormModificationDeclaration(codeDeclaration, commentaireDeclaration, dateDeclaration, urgence, traite))
                {
                    // Si la modification a été validée, rafraîchir la collection de déclarations.

                    if (modificationDeclaration.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCollectionDeclaration();
                    }
                }
                
            }
            else
            {
                // Affiche un message d'avertissement si toute la ligne n'est sélectionnée.

                MessageBox.Show("Vous devez sélectionner une ligne complète", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Rafraîchit la collection des déclarations et met à jour le DataGridView.
        /// </summary>
        private void RefreshCollectionDeclaration()
        {
            // Recharge les déclarations depuis la base de données.

            Donnees.CollectionDeclaration = DataBase.ConsultationDesDeclarations();        
            
            // Met à jour la source de données du DataGridView avec la nouvelle collection.

            dataGridViewListDeclaration.DataSource = null;
            dataGridViewListDeclaration.DataSource = Donnees.CollectionDeclaration;
        }
    }
}
