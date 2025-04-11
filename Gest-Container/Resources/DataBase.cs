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
           + "uid=jhuo;pwd=22/09/2003;database=mydb_jhuo; convert zero datetime=True";

        //private static string myConnectionString = "server=172.31.2.110;"
        //    + "uid=jhuo;pwd=@Xazerty1;database=db_contenaires; convert zero datetime=True";


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
                    cmd.Parameters.AddWithValue("@commentaireDeclaration", libelle);
                    cmd.Parameters.AddWithValue("@dateDeclaration", DateTime.Now);
                    cmd.Parameters.AddWithValue("@urgence", urgence);
                    cmd.Parameters.AddWithValue("@codeProbleme", codeP);
                    cmd.Prepare();
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
                cmd.Parameters.AddWithValue("@commentaireDeclaration", libelleDecla);
                cmd.Parameters.AddWithValue("@urgence", urgence);
                cmd.Parameters.AddWithValue("@codeDeclaration", codeDecla);
                cmd.Prepare();
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
        /// Récupère toutes les Problème depuis la table PROBLEME.
        /// </summary>
        /// <returns>Une liste d'objets Probleme.</returns>
        public static List<Probleme> ConsultationDesProbleme()
        {
            
            List<Probleme> desProblemes = new List<Probleme>();

            try
            {
                MySqlConnection connection = OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM PROBLEME";
                cmd.CommandType = System.Data.CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Crée une instance Probleme à partir des données lues.

                    Probleme unProbleme = new Probleme
                            {
                                codeProbleme = reader[0].ToString(),
                                libelleProbleme = reader[1].ToString()
                            };
                    // Ajoute le probleme à la liste.

                    desProblemes.Add(unProbleme);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération de la table Probleme : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection(); 
            }

            return desProblemes;
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
                cmd.Parameters.AddWithValue("@codeProbleme", codeP);
                cmd.Parameters.AddWithValue("@libelleProbleme", libelleP);
                cmd.Prepare();
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

        public static void AjouterUneDemandeExpertise(DateTime dateConstat, string commentaireConstat, string contactResp, int codeDeclaration)
        {
            try
            {
                MySqlConnection connection = OpenConnection();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO EXPERTISE(dateConstat, commentaireConstatation, contactResponsable, codeDeclaration) values(@dateConstat, @commentaireConstatation, "
                    + "@contactResponsable, @codeDeclaration)";
                cmd.Parameters.AddWithValue("@dateConstat", dateConstat);
                cmd.Parameters.AddWithValue("@commentaireConstatation", commentaireConstat);
                cmd.Parameters.AddWithValue("@contactResponsable", contactResp);
                cmd.Parameters.AddWithValue("@codeDeclaration", codeDeclaration);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

            } catch (MySqlException ex)
            {
                MessageBox.Show("Une erreur de traitement lors de l'envoi d'une demande expertise :" + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static List<Expertise> ConsultationDesDemandeExpertise()
        {

            List<Expertise> desDemandeExpertise = new List<Expertise>();

            try
            {
                MySqlConnection connection = OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM EXPERTISE";
                cmd.CommandType = System.Data.CommandType.Text;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Crée une instance Expertise à partir des données lues.

                    Expertise uneDemandeExpertise = new Expertise
                    {
                        numExpertise = Convert.ToInt32(reader[0].ToString()),
                        dateConstat = reader.GetDateTime(1),
                        commentaireConstatation = reader[2].ToString(),
                        contactResponsable = reader[3].ToString(),
                        status = reader[4].ToString(),
                        codeDeclaration = Convert.ToInt32(reader[5].ToString()),
                        dateCreation = reader.GetDateTime(6)
                    };
                    // Ajoute la demande expertise à la liste.

                    desDemandeExpertise.Add(uneDemandeExpertise);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération de la table Expertise : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return desDemandeExpertise;
        }
        public static void ModifierDemandeExpertise(int numExpertise, DateTime dateConstat, string commConstat, string contactResp, int codeDecla)
        {
            try
            {
                connection = OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE EXPERTISE set dateConstat = @dateConstat, commentaireConstatation = @commentaireConstatation, "
                    + "contactResponsable = @contactResponsable, codeDeclaration = @codeDeclaration WHERE numExpertise = @numExpertise";
                cmd.Parameters.AddWithValue("@dateConstat", dateConstat);
                cmd.Parameters.AddWithValue("@commentaireConstatation", commConstat);
                cmd.Parameters.AddWithValue("@contactResponsable", contactResp);
                cmd.Parameters.AddWithValue("@codeDeclaration", codeDecla);
                cmd.Parameters.AddWithValue("@numExpertise", numExpertise);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erreur lors de la modification de la table Expertise : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
