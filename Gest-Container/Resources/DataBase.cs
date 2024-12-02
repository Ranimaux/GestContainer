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

    public class DataBase
    {
        private static MySqlConnection connection;
        private static string myConnectionString = "server=srv-mydon.sio.local;"
            + "uid=kben;pwd=25/10/2003;database=mydb_kben; convert zero datetime=True";
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

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(myConnectionString);
            }
            return connection;
        }

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

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

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
                    Declaration uneDeclaration = new Declaration
                    {
                        codeDeclaration = Convert.ToInt32(reader[0].ToString()),
                        commentaireDeclaration = reader[1].ToString(),
                        dateDeclaration = reader.GetDateTime(2),
                        urgence = Convert.ToBoolean(reader[3]),
                        traite = Convert.ToBoolean(reader[4]),
                        codeProbleme = reader[6].ToString()
                    };

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
