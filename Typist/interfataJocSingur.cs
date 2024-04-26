using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist
{
    public partial class interfataJocSingur : Form
    {
        int timp, timpMaxim, nrCuvinte, nrGreseli, nrCuvinteMaxim;
        string text, userText = "";
        bool gata = false;

        public interfataJocSingur()
        {
            InitializeComponent();
        }

        public interfataJocSingur(int timp, string text)
        {
            InitializeComponent();

            this.timp = timp;
            this.timpMaxim = timp;
            this.text = text.Trim();
            this.nrCuvinteMaxim = this.text.Split(' ').Length;

            timerLabel.Text = timp.ToString();
            textbox.Text = text;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!gata)
                Database.createDetail(nrCuvinte, nrGreseli, timpMaxim - timp);

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

            if (gata || timp == 0) {
                Thread.Sleep(3000);
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

            int slct = textbox.SelectionStart;
            if (slct != 0 && textbox.Text[slct - 1] == textbox.Text[slct])
            {
                text = text.Remove(0, 1);
                textbox.Text = text;
            }

            int index = textbox.Text.IndexOf(text);

            if (textbox.Text.Contains(text))
            {
                if (index != 0)
                    userText = textbox.Text.Substring(0, index);
            }
            else
            {
                textbox.Clear();
                textbox.Text = userText + text;
                index = textbox.Text.IndexOf(text);
            }

            textbox.Select(0, index);
            textbox.SelectionColor = Color.Orange;
            textbox.DeselectAll();
            textbox.Select(index, textbox.Text.Length);
            textbox.SelectionColor = Color.White;
            textbox.DeselectAll();

            nrCuvinte = nrCuvinteMaxim - text.Split(' ').Length + 1;
            nrGreseli = userText.Length;

            userText = "";
            
            if(text.Length == 0){
                MessageBox.Show("gata");
                gata = true;
            }
        }
    }
}
