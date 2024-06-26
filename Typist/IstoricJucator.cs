﻿using System;
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
    public partial class IstoricJucator : Form
    {
        int id = -1;
        public IstoricJucator()
        {
            InitializeComponent();
        }

        public IstoricJucator(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void IstoricJucator_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = "Istoricul lui " + Database.getUser(id);

            DataTable dt = Database.getGames(id);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["ModJoc"].ToString().Trim() + ' ' + dt.Rows[i]["Timp"] + "s - " + dt.Rows[i]["Data"].ToString().Trim().Split(' ')[0].Trim() + " (id " + dt.Rows[i]["Id"].ToString().Trim() + ')';
                gamesList.Items.Add(text);
            }
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamesList.SelectedItem != null)
            {
                string id = gamesList.SelectedItem.ToString().Split('d')[1].Split(')')[0].Trim();
                if (stergeRevinoButton.Text.CompareTo("Sterge") == 0)
                {
                    veziRezultate veziRezultate = new veziRezultate(Convert.ToInt32(id));
                    veziRezultate.ShowDialog();
                }
                else
                {
                    Database.deleteGame(Convert.ToInt32(id));
                    gamesList.Items.Remove(gamesList.SelectedItem);
                }
            }
        }

        private void stergeRevinoButton_Click(object sender, EventArgs e)
        {
            if (stergeRevinoButton.Text.CompareTo("Sterge") == 0)
            {
                stergeRevinoButton.Text = "Revino";
                stergeLabel.Visible = true;
            } else
            {
                stergeRevinoButton.Text = "Sterge";
                stergeLabel.Visible = false;
            }
        }
    }
}
