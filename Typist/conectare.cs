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
    public partial class conectare : Form
    {
        public conectare()
        {
            InitializeComponent();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
