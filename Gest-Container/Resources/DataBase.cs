using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContainer.Modele;
using GestContainer.Vues;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GestContainer.Resources
{
    // host : srv-mydon.sio.local
    // ipHost : 217.167.171.227
    // Classe statique DataBase pour gérer les interactions avec la base de données MySQL.
    // Contient des méthodes pour tester la connexion, ouvrir/fermer des connexions, et manipuler les données dans les tables.
    public class DataBase
    {
        // Déclaration de la connexion MySQL.

        private static MySqlConnection connection;

        // Chaîne de connexion contenant les informations de connexion à la base de données.
        
        private static string myConnectionString = "server=srv-mydon.sio.local;"
            + "uid=kben;pwd=25/10/2003;database=mydb_kben; convert zero datetime=True";

        /// <summary>
        /// Teste la connexion à la base de données en essayant de l'ouvrir.
        /// </summary>
        /// <returns>True si la connexion est réussie, False sinon.</returns>
        [STAThread]
        public static bool TestConnection()
        {


            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySql.Data.MySqlClient.MySqlConnection();
            connection.ConnectionString = myConnectionString;
            try
            {
                connection.Open();
                MessageBox.Show("Connexion à la base de données avec succès", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Une erreur à eu lieu, pendant la connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Retourne une instance unique de la connexion à la base de données.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(myConnectionString);
            }
            return connection;
        }

        /// <summary>
        /// Ouvre la connexion à la base de données si elle est fermée.
        /// </summary>
        public static MySqlConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = GetConnection();
            }
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        /// <summary>
        /// Ferme la connexion à la base de données si elle est ouverte.
        /// </summary>
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Récupère toutes les déclarations depuis la table DECLARATION.
        /// </summary>
        /// <returns>Une liste d'objets Declaration.</returns>
        public static List<Declaration> ConsultationDesDeclarations()
        {
            List<Declaration> desDeclarations = new List<Declaration>();

            try
            {
                MySqlConnection connection = OpenConnection(); 
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM DECLARATION",
                    CommandType = System.Data.CommandType.Text 
                };

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Crée un objet Declaration à partir des données lues.

                    Declaration uneDeclaration = new Declaration
                    {
                        codeDeclaration = Convert.ToInt32(reader[0].ToString()),
                        commentaireDeclaration = reader[1].ToString(),
                        dateDeclaration = reader.GetDateTime(2),
                        urgence = Convert.ToBoolean(reader[3]),
                        traite = Convert.ToBoolean(reader[4]),
                        codeProbleme = reader[6].ToString()
                    };
                    // Ajoute la déclaration à la liste.

                    desDeclarations.Add(uneDeclaration);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération de la table Declaration : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection(); 
            }

            return desDeclarations;
        }

        /// <summary>
        /// Ajoute une déclaration dans la table DECLARATION.
        /// </summary>
        
        public static void AjouterUneDeclaration(string libelle, bool urgence, string codeP)
        {
            try
            {
                
                    MySqlConnection connection = OpenConnection();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO DECLARATION(commentaireDeclaration, dateDeclaration, urgence, codeProbleme) VALUES(@commentaireDeclaration, @dateDeclaration, @urgence, @codeProbleme)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@commentaireDeclaration", libelle);
                    cmd.Parameters.AddWithValue("@dateDeclaration", DateTime.Now);
                    cmd.Parameters.AddWithValue("@urgence", urgence);
                    cmd.Parameters.AddWithValue("@codeProbleme", codeP);
                    cmd.ExecuteNonQuery();


                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur de traitement lors de l'envoi de Déclaration : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

        }

        /// <summary>
        /// Modifie une déclaration existante dans la table DECLARATION.
        /// </summary>

        public static void ModifierUneDeclaration(int codeDecla, string libelleDecla, bool urgence)
        {
            try
            {
                MySqlConnection connection = OpenConnection();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE DECLARATION SET commentaireDeclaration = @commentaireDeclaration, urgence = @urgence Where codeDeclaration = @codeDeclaration;";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@commentaireDeclaration", libelleDecla);
                cmd.Parameters.AddWithValue("@urgence", urgence);
                cmd.Parameters.AddWithValue("@codeDeclaration", codeDecla);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur de traitement lors de la modification d'une déclaration : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
        
        /// <summary>
        /// Ajoute un problème dans la table PROBLEME.
        /// </summary>
        public static void AjouterUnProbleme(string codeP, string libelleP)
        {
            try
            {
                MySqlConnection connection = OpenConnection();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO PROBLEME(codeProbleme, libelleProbleme) VALUES(@codeProbleme, @libelleProbleme)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codeProbleme", codeP);
                cmd.Parameters.AddWithValue("@libelleProbleme", libelleP);
                cmd.ExecuteNonQuery();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Une erreur de traitement lors de l'envoi du Probleme : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
