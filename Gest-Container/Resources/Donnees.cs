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
        // Classe contenant des propriétés statiques pour gérer les collections d'objets (containers, déclarations, inspections et problèmes).
        // Ces collections servent de cache pour éviter des requêtes répétées à la base de données.
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

        /// <summary>
        /// Propriété pour accéder ou mettre à jour la collection des déclarations (cache local des données de la table DECLARATION).
        /// </summary>
        public static List<Declaration> CollectionDeclaration
        {
            get {
                // Si la collection des déclarations n'a pas encore été chargée.

                if (_collectionDeclaration == null)
                {
                    List<Declaration> desDeclaration = new List<Declaration>();

                    try
                    {
                        // Ouvre une connexion à la base de données.

                        DataBase.OpenConnection();

                        // Prépare une commande pour sélectionner toutes les déclarations dans la table DECLARATION.

                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM DECLARATION", DataBase.GetConnection());
                        cmd.CommandType = CommandType.Text;

                        // Exécute la commande et lit les résultats.

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
                            // Ajoute l'objet Declaration à la liste locale.
                            desDeclaration.Add(uneDeclaration);
                        }
                        // Stocke les déclarations récupérées dans la collection statique.
                        _collectionDeclaration = desDeclaration;
                    }
                    catch (MySqlException ex)
                    {
                        // Affiche un message d'erreur si une exception MySQL est levée.
                        MessageBox.Show("Erreur lors de la récupération de la table Declaration : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Ferme la connexion à la base de données.
                        DataBase.CloseConnection();
                    }
                    
                }
                // Retourne la collection des déclarations.
                return Donnees._collectionDeclaration;
            }
            // Permet de mettre à jour la collection des déclarations.
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

        /// <summary>
        /// Propriété pour accéder ou mettre à jour la collection des problèmes (cache local des données de la table PROBLEME).
        /// </summary>
        public static List<Probleme> CollectionProbleme
        {
            get
            {
                if(_collectionInspection == null)
                {
                    List<Probleme> desProblemes = new List<Probleme>();

                    try
                    {
                        // Ouvre une connexion à la base de données.
                        DataBase.OpenConnection();               
                        // Prépare une commande pour sélectionner tous les problèmes dans la table PROBLEME.
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM PROBLEME", DataBase.GetConnection());
                        cmd.CommandType = CommandType.Text;
                        // Exécute la commande et lit les résultats.
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // Crée un objet Probleme à partir des données lues.
                            Probleme unProbleme = new Probleme
                            {
                                codeProbleme = reader[0].ToString(),
                                libelleProbleme = reader[1].ToString()
                            };
                            // Ajoute l'objet Probleme à la liste locale.
                            desProblemes.Add(unProbleme);
                        }
                        // Stocke les problèmes récupérés dans la collection statique.
                        _collectionProbleme = desProblemes;
                    } catch(MySqlException ex)
                    {
                        // Affiche un message d'erreur si une exception MySQL est levée.
                        MessageBox.Show("Erreur lors de la récupération de la table Probleme : " + ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Ferme la connexion à la base de données.
                        DataBase.CloseConnection();
                    }
                }
                return Donnees._collectionProbleme;
            }
            // Permet de mettre à jour la collection des problèmes.
            set { Donnees._collectionProbleme = value; }
        }
    }
}
