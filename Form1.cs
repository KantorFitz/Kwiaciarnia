using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwiaciarnia
{
    public partial class Form1 : Form
    {
        private Repository _repository;

        public Form1()
        {
            InitializeComponent();

            _repository = new Repository();
        }

    }
}
