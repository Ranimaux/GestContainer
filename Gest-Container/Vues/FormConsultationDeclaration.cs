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
    public partial class FormConsultationDeclaration : Form
    {
        public FormConsultationDeclaration()
        {
            InitializeComponent();
        }

        private void FormConsultationDeclaration_Load(object sender, EventArgs e)
        {
            dataGridViewListDeclaration.DataSource = null;
            dataGridViewListDeclaration.DataSource = Donnees.CollectionDeclaration;
        }

        private void buttonModification_Click(object sender, EventArgs e)
        {
            
            if(dataGridViewListDeclaration.SelectedRows.Count > 0)
            {
                var row = dataGridViewListDeclaration.SelectedRows[0];
                int codeDeclaration = (int)row.Cells["codeDeclaration"].Value;
                string commentaireDeclaration = row.Cells["commentaireDeclaration"].Value.ToString();
                DateTime dateDeclaration = (DateTime)row.Cells["dateDeclaration"].Value;
                bool urgence = (bool)row.Cells["urgence"].Value;
                bool traite = (bool)row.Cells["traite"].Value;

                using (FormModificationDeclaration modificationDeclaration = new FormModificationDeclaration(codeDeclaration, commentaireDeclaration, dateDeclaration, urgence, traite))
                {
                    
                    if(modificationDeclaration.ShowDialog() == DialogResult.OK)
                    {
                        RefreshCollectionDeclaration();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une ligne complète", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void RefreshCollectionDeclaration()
        {
            Donnees.CollectionDeclaration = DataBase.ConsultationDesDeclarations();
            dataGridViewListDeclaration.DataSource = null;
            dataGridViewListDeclaration.DataSource = Donnees.CollectionDeclaration;
        }
    }
}
