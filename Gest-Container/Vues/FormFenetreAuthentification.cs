using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices;

namespace GestContainer.Vues
{
    public partial class FormFenetreAuthentification : Form
    {
        public FormFenetreAuthentification()
        {
            InitializeComponent();
        }

        private void ButtonAuthentification_Click(object sender, EventArgs e)
        {
            try
            {

                string adresseAuthentification = "LDAP://" + "sio.local/" + "OU=OU-SLAM,"
                    + "OU=OU-Etudiants,DC=sio,DC=local";

                DirectoryEntry Ldap = new DirectoryEntry(adresseAuthentification, TextBoxIdentifiant.Text,
                    TextBoxPassWord.Text);
                DirectoryEntry de = Ldap.NativeObject as DirectoryEntry;
                Thread t = new Thread(() => Application.Run(new FormFenetrePrincipale()));
                t.Start();
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show("Erreur d'authentification : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxIdentifiant.Text = "";
                TextBoxPassWord.Text = "";
            }
        }
        

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassWord.UseSystemPasswordChar = !CheckBoxPassword.Checked;
        }

        private void FormFenetreAuthentification_Load(object sender, EventArgs e)
        {
            TextBoxPassWord.UseSystemPasswordChar = true;
        }
    }
}
