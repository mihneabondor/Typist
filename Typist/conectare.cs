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

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerList.Text.CompareTo("Introdu numele de utilizator...") != 0 && playerList.Text.CompareTo("") != 0)
            {
                WebsocketService.connect(codeField.Text, playerList.Text);
            }
            else MessageBox.Show("Introdu un nume de utilizator valid!");
        }
    }
}
