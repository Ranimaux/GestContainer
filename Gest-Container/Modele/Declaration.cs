using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContainer.Modele
{
    class Declaration
    {
        private int _codeDeclaration;
        private string _commentaireDeclaration;
        private DateTime _date;
        private bool _urgence;
        private bool _traite;

        public int codeDeclaration
        {
            get { return _codeDeclaration; }
        }

        public string commentaireDeclaration
        {
            get { return _commentaireDeclaration; }
        }

        public DateTime date
        {
            get { return _date; }
        }

        public bool urgence
        {
            get { return _urgence; }
        }

        public bool traite
        {
            get { return _traite; }
        }
        public Declaration()
        {

        }
    }
}
