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
        int id = -1, idPrieten = -1;

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
                this.id = idPrieten;
        }
        public veziRezultate(bool rezultatePrieten, string modJoc, int hostId, int guestId)
        {
            InitializeComponent();
            this.rezultatePrieten = rezultatePrieten;
            veziRezultatePrieten.Visible = !Database.singlePlayerGame();
            numeLabel.Visible = !Database.singlePlayerGame();
            numeLabel.Text = Database.getUser(hostId);

            this.id = hostId;
            this.idPrieten = guestId;
        }

        public veziRezultate(int id)
        {
            this.id = id;
            InitializeComponent();
            veziRezultatePrieten.Visible = !Database.singlePlayerGame(id);
            numeLabel.Visible = !Database.singlePlayerGame(id);
            //de luat celalt id
            idPrieten = Database.getFriendId(id);
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
            DataTable dt = Database.getWordDataForChart(id);
            for (int i = 0; i < dt.Rows.Count; i++) chart1.Series["Cuvinte"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrCuvinte"]));

            dt = Database.getMistakeDataForChart(id);
            for (int i = 0; i < dt.Rows.Count; i++) 
                if(Convert.ToInt32(dt.Rows[i]["NrGreseli"]) != 0)
                    chart1.Series["Greseli"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrGreseli"]));
            
            CPMLabel.Text = Database.getWPM(id).ToString();
            accurayLabel.Text = Database.getAccuracy(id).ToString() + '%';
            gameModeLabel.Text = Database.getGameOptionsString(id);
            corecteLabel.Text = Database.getMaxWords(id).ToString();
            greseliLabel.Text = Database.getMaxMistakes(id).ToString();
            timeLabel.Text = Database.getMaxTime(id).ToString() + "s (din " + Database.getTime().ToString() + "s)"; 
        }
    }
}
