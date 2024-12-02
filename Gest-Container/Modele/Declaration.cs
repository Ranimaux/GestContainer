using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using GestContainer.Resources;
using GestContainer.Modele;
using GestContainer.Vues;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestContainer.Modele
{
    public class Declaration
    {
        public int codeDeclaration { get; set; }

        public string commentaireDeclaration { get; set; }

        public DateTime dateDeclaration { get; set; }

        public bool urgence { get; set; }

        public bool traite { get; set; }

        public int numContainer { get; set; }

        public string codeProbleme { get; set; }
        public Declaration()
        {
            
        }

        
    }
}
