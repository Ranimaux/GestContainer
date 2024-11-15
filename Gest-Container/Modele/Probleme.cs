using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestContainer.Modele
{
    class Probleme
    {
        private int _codeProbleme;
        private string _libelleProbleme;

        public int codeProbleme
        {
            get { return _codeProbleme; }
        }

        public string libelleProbleme
        {
            get { return _libelleProbleme; }
        }

        public Probleme()
        {

        }
    }
}
