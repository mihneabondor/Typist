using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist
{
    public partial class interfataJocSingur : Form
    {
        int timp;
        string text;
        public interfataJocSingur()
        {
            InitializeComponent();
        }

        public interfataJocSingur(int timp, string text)
        {
            InitializeComponent();

            this.timp = timp;
            this.text = text;

            timerLabel.Text = timp.ToString();
            textbox.Text = text;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timp--;
            if(timp >= 0)
            {
                timerLabel.Text = timp.ToString();
                if (timp == 0)
                {
                    textbox.ReadOnly = true;
                    MessageBox.Show("timpul a expirat");
                }
            }

            if (timp == -3) {
                timer1.Stop();

                this.Visible = false;
                veziRezultate veziRezultate = new veziRezultate(false, "impreuna");
                veziRezultate.ShowDialog();
            }
        }

        private void renuntaButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void pauzaReincepeButton_Click(object sender, EventArgs e)
        {
            if (pauzaReincepeButton.Text.CompareTo("Pauza") == 0)
            {
                timer1.Stop();
                textbox.ReadOnly = true;
                pauzaReincepeButton.Text = "Continua";
            } else
            {
                timer1.Start();
                textbox.ReadOnly = false;
                textbox.Focus();
                pauzaReincepeButton.Text = "Pauza";
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (timp % 5 == 0) timer1.Start();
        }
    }
}
