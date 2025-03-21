using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Security.Authentication;
using System.DirectoryServices;

namespace GestContainer.Vues
{
    public partial class FormFenetreAuthentification : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Initialisation du formulaire d'authentification
        /// </summary>
        public FormFenetreAuthentification()
        {
            InitializeComponent();
        }

        // La méthode événement ButtonAuthentification s'enclenche quand l'utilisateur appuye sur le button et effectue :
        // Un essai avec une variable string qui prend l'adresse du serveur LDAP
        // Création d'un objet de type DirectoryEntry LDAP qui prend en paramètre du constructeur l'adresse du serveur LDAP, TextBoxIdentifiant et TextBoxPassWord
        // lance la fenetre principale
        // ferme la fenetre d'authentification
        //
        // Si une erreur pendant l'essai, le récupère et signal à l'utilisateur avec un messagebox.show
        // rend vide les deux champs des TextBox.

        private void ButtonAuthentification_Click(object sender, EventArgs e)
        {
            try
            {
                string adresseAuthentification = "LDAP://" + "sio.local/" + "OU=OU-SLAM,"
                +"OU=OU-Etudiants,DC=sio,DC=local";


                DirectoryEntry Ldap = new DirectoryEntry
                    (
                    adresseAuthentification,
                    TextBoxIdentifiant.Text,
                    TextBoxPassWord.Text
                    );
                DirectoryEntry de = Ldap.NativeObject as DirectoryEntry;
                Thread t = new Thread(() => Application.Run(new FormFenetrePrincipale()));
                t.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'authentification : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxIdentifiant.Text = "";
                TextBoxPassWord.Text = "";
            }
            //string hostLDAP = "10.8.65.67"; // adresse du serveur LDAP
            //int portLDAP = 389; // 389 = LDAP Port ou 639 LDAPShell Port
            //string baseDN = "dc=LDAPServer,dc=local";
            //string loginLDAP = TextBoxIdentifiant.Text;
            //string passwordLDAP = TextBoxPassWord.Text;
            //string searchFilter = $"(cn={loginLDAP})";
            //string searchBase = "ou=Tholdi," + baseDN;
            //string userDN = null;


            //try
            //{
            //    using (LdapConnection connection = new LdapConnection(new LdapDirectoryIdentifier(hostLDAP, portLDAP)))
            //    {
            //        connection.Credential = new NetworkCredential(loginLDAP, passwordLDAP);
            //    }
            //    //LdapConnection connection = new LdapConnection(new LdapDirectoryIdentifier(hostLDAP, portLDAP));

            //    //userDN = $"cn={loginLDAP},ou=Developer,ou=Tholdi,{baseDN}";

            //    //connection.Credential = new NetworkCredential(userDN, passwordLDAP);
            //    //connection.AuthType = AuthType.Basic;
            //    //connection.SessionOptions.ProtocolVersion = 3;


            //    //connection.Bind();
            //    MessageBox.Show("Authentification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    Thread t = new Thread(() => Application.Run(new FormFenetrePrincipale()));
            //    t.Start();
            //    this.Close();

            //}
            //catch (LdapException ex)
            //{
            //    Console.WriteLine($"LDAP Exception: {ex.Message}");jhh
            //    Console.WriteLine($"Error Code: {ex.ErrorCode}");
            //    Console.WriteLine($"Server Message: {ex.ServerErrorMessage}");
            //}
            //catch (AuthenticationException authEx)
            //{

            //    MessageBox.Show($"Erreur d'authentification : {authEx.Message}", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show($"Erreur générale : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            finally
            {

                TextBoxIdentifiant.Text = string.Empty;
                TextBoxPassWord.Text = string.Empty;
            }
        }
        
        // La méthode événement CheckBoxPassword vérifie l'état de son changement
        // S'il n'est pas coché alors des poitilé affiche a la place du texte claire dans le textBoxPassWord

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassWord.UseSystemPasswordChar = !CheckBoxPassword.Checked;
        }

        // Lors du chargement de l'ouverture de la page, active le systemPasswordChar au TextBoxPassWord

        private void FormFenetreAuthentification_Load(object sender, EventArgs e)
        {
            TextBoxPassWord.UseSystemPasswordChar = true;
        }
    }
}
