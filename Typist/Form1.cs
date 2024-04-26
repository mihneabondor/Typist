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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectedNumeTextBox(object sender, MouseEventArgs e)
        {
            if (usernameTextbox.Text.CompareTo("Scrie...") == 0)
                usernameTextbox.Clear();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void singurButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            setariJoc f = new setariJoc();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!Database.checkUser(usernameTextbox.Text))
            {
                MessageBox.Show("Utilizator inexistent!");
            } else
            {
                this.Visible = false;
                IstoricJucator ist = new IstoricJucator(Database.getUser(usernameTextbox.Text));
                ist.ShowDialog();
            }
        }
    }
}
