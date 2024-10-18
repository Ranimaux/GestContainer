using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContainer.Modele;

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
            get
            {
                if(_collectionDeclaration == null)
                {

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
