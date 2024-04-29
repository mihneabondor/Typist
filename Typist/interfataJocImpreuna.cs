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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Typist
{

    public partial class interfataJocImpreuna : Form
    {
        int timp, timpMaxim, nrCuvinte, nrGreseli, nrCuvinteMaxim, hostId, guestId;
        string text, userText = "";

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.WriteLine(WebsocketService.incomingText);
            if (WebsocketService.incomingText.Contains('\n'))
            {
                //timer2.Stop();
                //sync
                string[] detailsText = WebsocketService.incomingText.Split('\n');

                foreach (string details in detailsText)
                {
                    string[] detail = details.Split(' ');
                    Database.createDetail(Convert.ToInt32(detail[1]), Convert.ToInt32(detail[2]), Convert.ToInt32(detail[3]), Convert.ToInt32(detail[4]));
                }

                this.Visible = false;
                veziRezultate veziRezultate = new veziRezultate(false, "impreuna");
                //veziRezultate.ShowDialog();
            }
            //{
                DataTable dt = Database.getDetails(hostId);

                string text = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                    text += dt.Rows[i]["IdJoc"].ToString().Trim() + ' ' + dt.Rows[i]["NrCuvinte"].ToString().Trim() + ' ' + dt.Rows[i]["NrGreseli"].ToString().Trim() + ' ' + dt.Rows[i]["Secunda"].ToString().Trim() + ' ' + dt.Rows[i]["IdJucator"].ToString().Trim() + '\n';

                WebsocketService.outgoingText = text;
                WebsocketService.sendMessage();
                WebsocketService.sendFromServer(text);
            //}
        }

        bool gata = false;

        public interfataJocImpreuna()
        {
            InitializeComponent();
        }

        public interfataJocImpreuna(int timp, string text, int hostId, int guestId)
        {
            InitializeComponent();

            this.timp = timp;
            this.timpMaxim = timp;
            this.text = text.Trim();
            this.nrCuvinteMaxim = this.text.Split(' ').Length;
            this.hostId = hostId;
            this.guestId = guestId;

            timerLabel.Text = timp.ToString();
            hostTextbox.Text = text;
            guestTextbox.Text = text;

            WebsocketService.outgoingText = text;
            WebsocketService.sendMessage();
        }
        private void closing(object sender, FormClosingEventArgs e) {
            WebsocketService.disconnect();
            WebsocketService.stopServer();

            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void hostTextbox_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();

            int slct = hostTextbox.SelectionStart;
            if (slct != 0 && hostTextbox.Text[slct - 1] == hostTextbox.Text[slct])
            {
                text = text.Remove(0, 1);
                hostTextbox.Text = text;
            }

            int index = hostTextbox.Text.IndexOf(text);

            if (hostTextbox.Text.Contains(text))
            {
                if (index != 0)
                    userText = hostTextbox.Text.Substring(0, index);
            }
            else
            {
                hostTextbox.Clear();
                hostTextbox.Text = userText + text;
                index = hostTextbox.Text.IndexOf(text);
            }

            hostTextbox.Select(0, index);
            hostTextbox.SelectionColor = Color.Orange;
            hostTextbox.DeselectAll();
            hostTextbox.Select(index, hostTextbox.Text.Length);
            hostTextbox.SelectionColor = Color.White;
            hostTextbox.DeselectAll();

            nrCuvinte = nrCuvinteMaxim - text.Split(' ').Length + 1;
            nrGreseli = userText.Length;

            userText = "";

            if (text.Length == 0)
            {
                MessageBox.Show("gata");
                gata = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!WebsocketService.incomingText.Contains('\n'))
            {
                guestTextbox.Text = WebsocketService.incomingText;
                WebsocketService.outgoingText = hostTextbox.Text;
                WebsocketService.sendMessage();
            }

            if (!gata)
                Database.createDetail(nrCuvinte, nrGreseli, timpMaxim - timp, hostId);

            timp--;

            if (timp >= 0)
            {
                timerLabel.Text = timp.ToString();
                if (timp == 0)
                {
                    hostTextbox.ReadOnly = true;
                    MessageBox.Show("timpul a expirat");
                }
            }

            if (gata || timp <= 0)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
    }
}
