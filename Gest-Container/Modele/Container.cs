using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestContainer.Resources;
using MySql.Data.MySqlClient;

namespace GestContainer.Modele
{
    class Container
    {
        private int _numContainer;
        private DateTime _dateAchat;
        private string _typeContainer;
        private DateTime _dateDerniereInsp;

        private int numContainer
        {
            get { return _numContainer; }
        }

        private DateTime dateAchat
        {
            get { return _dateAchat; }
        }

        private string typeContainer
        {
            get { return _typeContainer; }
        }

        private DateTime dateDerniereInsp
        {
            get { return _dateDerniereInsp; }
        }

        public Container(int numContainer, string typeContainer, DateTime dateAchat, DateTime dateDerniereInsp)
        {
            _numContainer = numContainer;

            _typeContainer = typeContainer;

            _dateAchat = dateAchat;

            _dateDerniereInsp = dateAchat;
        }
        
        public Container()
        {

        }
    }
}
