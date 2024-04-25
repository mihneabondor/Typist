using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist
{
    public partial class veziRezultate : Form
    {
        bool rezultatePrieten = false;
        public veziRezultate()
        {
            InitializeComponent();
        }

        public veziRezultate(bool rezultatePrieten, string modJoc)
        {
            InitializeComponent();
            this.rezultatePrieten = rezultatePrieten;

            if (modJoc.CompareTo("impreuna") != 0)
                veziRezultatePrieten.Visible = false;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if(!rezultatePrieten)
            {
                this.Visible = false;
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void inchideButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (!rezultatePrieten)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void veziRezultatePrieten_Click(object sender, EventArgs e)
        {
            veziRezultate f = new veziRezultate(true, "impreuna");
            f.ShowDialog();
        }
    }
}
