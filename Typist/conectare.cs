using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typist
{
    public partial class conectare : Form
    {
        int timp = 0;
        string text = "";

        public conectare()
        {
            InitializeComponent();
            codeField.Focus();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Database.deleteGame();

            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerList.Text.CompareTo("Introdu numele de utilizator...") != 0 && playerList.Text.CompareTo("") != 0)
            {
                if(WebsocketService.connect(codeField.Text, playerList.Text))
                {
                    button2.Enabled = false;

                    playerList.ReadOnly = true;
                    playerList.MouseClick -= playerListClick;

                    seAsteaptaGazdaLabel.Visible = true;

                    Thread.Sleep(1000);
                    string[] text = WebsocketService.incomingText.Split(' ');
                    playerList.Text = playerList.Text.Trim() + '\n' + text[0];
                    modJocLabel.Text = text[1] + ' ' + text[2];
                    timpLabel.Text = text[2];
                    numarCuvinteLabel.Text = text[4];

                    for (int i = 5; i < text.Length; i++)
                        textField.Text += text[i] + ' ';

                    int timp = Convert.ToInt32(text[2].Remove(text[2].Length - 1));
                    this.timp = timp;

                    Database.syncGame(timp, textField.Text);
                    Database.addPlayerToGame(text[0]);

                    timer1.Start();
                }
            }
            else MessageBox.Show("Introdu un nume de utilizator valid!");
        }

        private void playerListClick(object sender, MouseEventArgs e)
        {
            playerList.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(WebsocketService.incomingText.CompareTo("gata") == 0)
            {
                timer1.Stop();
                this.Visible = false;
                interfataJocImpreuna interfataJocImpreuna = new interfataJocImpreuna(timp, textField.Text);
                interfataJocImpreuna.ShowDialog();
                
            }
        }
    }
}
