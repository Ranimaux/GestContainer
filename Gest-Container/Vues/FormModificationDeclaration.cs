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
    public partial class FormModificationDeclaration : Form
    {
        private int _codeDeclaration;
        private bool _traite;

        public FormModificationDeclaration(int codeDeclaration, string commentaireDeclaration, DateTime dateDeclaration, bool urgence, bool traite)
        {
            
            InitializeComponent();

            this._codeDeclaration = codeDeclaration;
            textBoxCommentaireDeclaration.Text = commentaireDeclaration;
            dateTimePickerDateDeclaration.Value = dateDeclaration;
            checkBoxUrgence.Checked = urgence;
            this._traite = traite;
        }
        private void FormModificationDeclaration_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificationDeclaration_Click(object sender, EventArgs e)
        {

            string commentaireDeclaration = textBoxCommentaireDeclaration.Text;
            DateTime dateDeclaration = dateTimePickerDateDeclaration.Value;
            bool Urgence = checkBoxUrgence.Checked;
            int codeDeclaration = this._codeDeclaration;
            
            if(VerificationDuFormulaire() != false)
            {
                DataBase.ModifierUneDeclaration(codeDeclaration, commentaireDeclaration, Urgence);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonAnnulationDeclaration_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool VerificationDuFormulaire()
        {
            bool formChecked = true;

            if (string.IsNullOrWhiteSpace(textBoxCommentaireDeclaration.Text) && textBoxCommentaireDeclaration.Text.Length < 0 && textBoxCommentaireDeclaration.Text.Length > 100)
            {
                MessageBox.Show("Le champ commentaire ne doit vide ou dépasser 100 Caractère!", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommentaireDeclaration.Focus();
                formChecked = false;
            }

            if ((DateTime.Now - dateTimePickerDateDeclaration.Value).TotalDays > 7)
            {
                MessageBox.Show("La déclaration ne peut être modifiée car elle remonte à plus de 7 jours.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formChecked = false;
            }

            if (this._traite == true)
            {
                MessageBox.Show("La déclaration a était déjà traité, elle ne peut être modifiée.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                formChecked = false;
            }

            return formChecked;
        }
    }
}
