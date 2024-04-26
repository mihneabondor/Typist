using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Typist
{
    public partial class invitaPrieten : Form
    {
        int timp = 0;
        string text = "";
        public invitaPrieten()
        {
            InitializeComponent();
        }

        public invitaPrieten(int timp, string text, string user)
        {
            InitializeComponent();

            this.timp = timp;
            this.text = text;

            modJocLabel.Text = "impreuna " + timp.ToString() + 's';
            timpLabel.Text = timp.ToString() + 's';
            numarCuvinteLabel.Text = (text.Split(' ').Length - 1).ToString();
            textField.Text = text;
            playerList.Text = user + '\n';

            WebsocketService.outgoingText = user + ' ' + modJocLabel.Text + ' ' + timpLabel.Text + ' ' + numarCuvinteLabel.Text + ' ' + text;
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
            
            Clipboard.SetText(codeField.Text);
        }

        private void incepeButton_Click(object sender, EventArgs e)
        {
            if (playerList.Text.Split('\n').Length == 1)
                MessageBox.Show("Nu poti juca singur in acest mod de joc!");
            else
            {
                // incepe jocul
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(WebsocketService.incomingText.Length > 0)
            {
                timer1.Stop();
                playerList.Text += WebsocketService.incomingText;
                Database.addPlayerToGame(WebsocketService.incomingText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            WebsocketService.host();
            codeField.Text = WebsocketService.cryptedAddress;
            timer1.Start();
        }
    }
}
