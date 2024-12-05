using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestContainer.Vues
{
    public partial class FormAjouterProbleme : Form
    {
        /// <summary>
        /// Initialisation des champs string codeProbleme et libelleProbleme pour le formulaire formulaire
        /// </summary>
        public string codeProbleme { get; private set; }
        public string libelleProbleme { get; private set; }
        public FormAjouterProbleme()
        {
            InitializeComponent();
        }

        // La méthode événement buttonAjouterProbleme :
        // prend le champ de texte saisi par l'utilisateur de textBoxLibelle
        // vérifie que le champ caractère libelleProbleme n'est pas null ou vide
        // Si vrai, alors initie le codeProbleme en prenant les première lettre en majucule
        // et vérifie si ça dépasse 4 caractère alors il concatène à 4 maximal de caractère
        // puis ouvre une boite de dialogue en back pour comfirmer que le traitement a était effectué et ferme le formulaire.
        // si libelleProbleme est null ou vide alors un message indique à l'utilisateur que le champ ne doit être vide.

        private void ButtonAjouterProbleme_Click(object sender, EventArgs e)
        {
            libelleProbleme = textBoxLibelleProbleme.Text;

            if (!string.IsNullOrWhiteSpace(libelleProbleme))
            {
                codeProbleme = string.Concat(libelleProbleme
                    .Split(' ', '-', '_')
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Select(s => s[0]))
                    .ToUpper();

                if (codeProbleme.Length > 4)
                {
                    codeProbleme = codeProbleme.Substring(0, 4);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Le libelle de probleme ne doit être vide.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // La méthode événement buttonAnnulerProbleme effectue une boite de dialogue en back pour indiquer que c'est annulé
        // Et ferme le formulaire

        private void buttonAnnulerProbleme_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
