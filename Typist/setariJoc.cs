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
    public partial class setariJoc : Form
    {
        public setariJoc()
        {
            InitializeComponent();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void inapoiButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void numeUtilizatorTextboxSelected(object sender, MouseEventArgs e)
        {
            numeUtilizator.Clear();
        }

        private void numarCuvinteSlider_Scroll(object sender, EventArgs e)
        {
            numarCuvinteLabel.Text = numarCuvinteSlider.Value.ToString() + " cuvinte";
        }

        private void durataSlider_Scroll(object sender, EventArgs e)
        {
            durataLabel.Text = durataSlider.Value.ToString() + " secunde";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            interfataJocSingur f = new interfataJocSingur(durataSlider.Value, "hello");
            f.ShowDialog();
        }
    }
}
