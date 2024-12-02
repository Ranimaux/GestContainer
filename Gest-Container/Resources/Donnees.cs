using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContainer.Modele;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using GestContainer.Resources;

namespace GestContainer.Resources
{
    class Donnees
    {
        private static List<Container> _collectionContainer;
        private static List<Declaration> _collectionDeclaration;
        private static List<Inspection> _collectionInspection;
        private static List<Probleme> _collectionProbleme;

        public static List<Container> CollectionContainer
        {
            get
            {
                if(_collectionContainer == null)
                {
                    
                }
                return Donnees._collectionContainer;
            }
            set { Donnees._collectionContainer = value; }
        }

        public static List<Declaration> CollectionDeclaration
        {
            get {

                if (_collectionDeclaration == null)
                {
                    List<Declaration> desDeclaration = new List<Declaration>();

                    try
                    {
                        DataBase.OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM DECLARATION", DataBase.GetConnection());
                        cmd.CommandType = CommandType.Text;
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

                            desDeclaration.Add(uneDeclaration);
                        }
                        _collectionDeclaration = desDeclaration;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération de la table Declaration : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DataBase.CloseConnection();
                    }
                    
                }
                return Donnees._collectionDeclaration;
            }
            set { Donnees._collectionDeclaration = value; }
        }


        public static List<Inspection> CollectionInspection
        {
            get
            {
                if(_collectionInspection == null)
                {

                }
                return Donnees._collectionInspection;
            }
            set { Donnees._collectionInspection = value; }
        }  

        public static List<Probleme> CollectionProbleme
        {
            get
            {
                if(_collectionInspection == null)
                {
                    List<Probleme> desProblemes = new List<Probleme>();

                    try
                    {
                        DataBase.OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM PROBLEME", DataBase.GetConnection());
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Probleme unProbleme = new Probleme
                            {
                                codeProbleme = reader[0].ToString(),
                                libelleProbleme = reader[1].ToString()
                            };
                            
                            desProblemes.Add(unProbleme);
                        }
                        _collectionProbleme = desProblemes;
                    } catch(MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération de la table Probleme : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DataBase.CloseConnection();
                    }
                }
                return Donnees._collectionProbleme;
            }
            set { Donnees._collectionProbleme = value; }
        }
    }
}
