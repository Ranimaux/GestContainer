using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContainer.Modele
{
    class Inspection
    {
        private int _numInspection;
        private DateTime _date;
        private string _commentairePostInspection;
        private string _avis;

        public int numInspection
        {
            get { return _numInspection; }
        }

        public DateTime date
        {
            get { return _date; }
        }

        public string commentairePostInspection
        {
            get { return _commentairePostInspection; }
        }

        public string avis
        {
            get { return _avis; }
        }

        public Inspection()
        {

        }
    }
}
