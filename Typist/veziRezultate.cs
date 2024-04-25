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

        public veziRezultate()
        {
            InitializeComponent();
        }

        public veziRezultate(bool rezultatePrieten, string modJoc)
        {
            InitializeComponent();
            this.rezultatePrieten = rezultatePrieten;
            veziRezultatePrieten.Visible = !Database.singlePlayerGame();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if(!rezultatePrieten)
            {
                this.Visible = false;
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void inchideButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (!rezultatePrieten)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void veziRezultatePrieten_Click(object sender, EventArgs e)
        {
            veziRezultate f = new veziRezultate(true, "impreuna");
            f.ShowDialog();
        }

        private void veziRezultate_Load(object sender, EventArgs e)
        {
            DataTable dt = Database.getWordDataForChart();
            for (int i = 0; i < dt.Rows.Count; i++) chart1.Series["Cuvinte"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrCuvinte"]));

            dt = Database.getMistakeDataForChart();
            for (int i = 0; i < dt.Rows.Count; i++) chart1.Series["Greseli"].Points.AddXY(Convert.ToInt32(dt.Rows[i]["Secunda"]), Convert.ToInt32(dt.Rows[i]["NrGreseli"]));
            
            CPMLabel.Text = Database.getWPM().ToString();
            accurayLabel.Text = Database.getAccuracy().ToString() + '%';
            gameModeLabel.Text = Database.getGameOptionsString();
            corecteLabel.Text = Database.getMaxWords().ToString();
            greseliLabel.Text = Database.getMaxMistakes().ToString();
            timeLabel.Text = Database.getMaxTime().ToString() + "s (din " + Database.getTime().ToString() + "s)"; 
        }
    }
}
