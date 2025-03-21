﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestContainer.Vues
{

    // C'est la fenetre principal du programme qui initie les différent formulaire declaration
    public partial class FormFenetrePrincipale : Form
    {
        private Form _mdiChild;

        private Form MdiChild
        {
            get { return _mdiChild; }
            set
            {
                if(_mdiChild != null)
                {
                    _mdiChild.Dispose();
                }
                _mdiChild = value;
                _mdiChild.MdiParent = this;
                _mdiChild.MaximumSize = _mdiChild.Size;
                _mdiChild.MinimumSize = _mdiChild.Size;
                _mdiChild.Show();
            }
        }
        public FormFenetrePrincipale()
        {
            InitializeComponent();
        }

        private void ConsulterLesIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormConsultationDeclaration();
        }

        private void declarerUnAccidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormAjoutDeclaration();
        }

        private void FormFenetrePrincipale_Load(object sender, EventArgs e)
        {

        }
    }
}
