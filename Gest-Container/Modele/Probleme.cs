using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestContainer.Modele
{
    public class Probleme
    {
        private string _codeProbleme;
        private string _libelleProbleme;

        public string codeProbleme
        {
            get; set;
        }

        public string libelleProbleme
        {
            get; set;
        }

        public Probleme()
        {

        }
    }
}
