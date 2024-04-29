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
        int id = -1, idPrieten = -1, idHost = -1;

        public veziRezultate()
        {
            InitializeComponent();
        }

        public veziRezultate(bool rezultatePrieten, string modJoc, int idPrieten = -1)
        {
            InitializeComponent();
            this.rezultatePrieten = rezultatePrieten;
            veziRezultatePrieten.Visible = !Database.singlePlayerGame();
            numeLabel.Visible = !Database.singlePlayerGame();

            if (idPrieten != -1)
                this.idHost = idPrieten;
        }
        public veziRezultate(bool rezultatePrieten, string modJoc, int hostId, int guestId)
        {
            InitializeComponent();
            this.rezultatePrieten = rezultatePrieten;
            veziRezultatePrieten.Visible = !Database.singlePlayerGame();
            numeLabel.Visible = !Database.singlePlayerGame();
            numeLabel.Text = Database.getUser(hostId);

            this.idHost = hostId;
            this.idPrieten = guestId;
        }

        public veziRezultate(int id)
        {
            this.id = id;
            InitializeComponent();
            veziRezultatePrieten.Visible = !Database.singlePlayerGame(id);
            numeLabel.Visible = !Database.singlePlayerGame(id);

            this.idHost = Database.getPlayerIds(id).Item1;
            this.idPrieten = Database.getPlayerIds(id).Item2;
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;

            if (!rezultatePrieten && id == -1)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void inchideButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (!rezultatePrieten && id == -1)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void veziRezultatePrieten_Click(object sender, EventArgs e)
        {
            veziRezultate f = new veziRezultate(true, "impreuna", idPrieten);
            f.ShowDialog();
        }

        private void veziRezultate_Load(object sender, EventArgs e)
        {
            DataTable dt = Database.getWordDataForChart(id, idHost);
            for (int i = 0; i < dt.Rows.Count; i++) chart1.Series["Cuvinte"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrCuvinte"]));

            dt = Database.getMistakeDataForChart(id, idHost);
            for (int i = 0; i < dt.Rows.Count; i++) 
                if(Convert.ToInt32(dt.Rows[i]["NrGreseli"]) != 0)
                    chart1.Series["Greseli"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrGreseli"]));
            
            CPMLabel.Text = Database.getWPM(id, idHost).ToString();
            accurayLabel.Text = Database.getAccuracy(id, idHost).ToString() + '%';
            gameModeLabel.Text = Database.getGameOptionsString(id);
            corecteLabel.Text = Database.getMaxWords(id, idHost).ToString();
            greseliLabel.Text = Database.getMaxMistakes(id, idHost).ToString();
            timeLabel.Text = Database.getMaxTime(id, idHost).ToString() + "s (din " + Database.getTime(id).ToString() + "s)"; 
        }
    }
}
