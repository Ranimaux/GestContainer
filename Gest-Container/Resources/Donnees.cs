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
                    DataBase connectionDataBase = new DataBase();

                    try
                    {
                        DataBase.OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM DECLARATION", DataBase.GetConnection());
                        cmd.CommandType = CommandType.Text;
                        MySqlDataReader reader = cmd.ExecuteReader();
                        Declaration uneDeclaration = new Declaration();
                        while (reader.Read())
                        {

                            uneDeclaration.codeDeclaration = Convert.ToInt32(reader[0].ToString());
                            uneDeclaration.commentaireDeclaration = reader[1].ToString();
                            uneDeclaration.dateDeclaration = reader.GetDateTime(2);
                            uneDeclaration.urgence = Convert.ToBoolean(reader[3]);
                            uneDeclaration.traite = Convert.ToBoolean(reader[4]);
                            
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

                }
                return Donnees._collectionProbleme;
            }
            set { Donnees._collectionProbleme = value; }
        }
    }
}
