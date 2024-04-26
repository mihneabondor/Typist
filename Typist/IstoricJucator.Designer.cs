namespace Typist
{
    partial class IstoricJucator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstoricJucator));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.gamesList = new System.Windows.Forms.ListBox();
            this.stergeRevinoButton = new System.Windows.Forms.Button();
            this.stergeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Gold;
            this.usernameLabel.Location = new System.Drawing.Point(13, 26);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(211, 25);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Istoricul lui Mihnea";
            // 
            // gamesList
            // 
            this.gamesList.BackColor = System.Drawing.Color.DimGray;
            this.gamesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 16;
            this.gamesList.Location = new System.Drawing.Point(18, 54);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(444, 388);
            this.gamesList.TabIndex = 2;
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            // 
            // stergeRevinoButton
            // 
            this.stergeRevinoButton.BackColor = System.Drawing.Color.Gold;
            this.stergeRevinoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeRevinoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stergeRevinoButton.Location = new System.Drawing.Point(657, 404);
            this.stergeRevinoButton.Name = "stergeRevinoButton";
            this.stergeRevinoButton.Size = new System.Drawing.Size(99, 34);
            this.stergeRevinoButton.TabIndex = 16;
            this.stergeRevinoButton.Text = "Sterge";
            this.stergeRevinoButton.UseVisualStyleBackColor = false;
            this.stergeRevinoButton.Click += new System.EventHandler(this.stergeRevinoButton_Click);
            // 
            // stergeLabel
            // 
            this.stergeLabel.AutoSize = true;
            this.stergeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeLabel.ForeColor = System.Drawing.Color.Gold;
            this.stergeLabel.Location = new System.Drawing.Point(468, 54);
            this.stergeLabel.Name = "stergeLabel";
            this.stergeLabel.Size = new System.Drawing.Size(282, 32);
            this.stergeLabel.TabIndex = 17;
            this.stergeLabel.Text = "Selecteaza un obiect din lista pentru a-l sterge.\r\nCand este gata, apasa pe buton" +
    "ul Revino";
            this.stergeLabel.Visible = false;
            // 
            // IstoricJucator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.stergeLabel);
            this.Controls.Add(this.stergeRevinoButton);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.usernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IstoricJucator";
            this.Text = "Istoric";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.Load += new System.EventHandler(this.IstoricJucator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Button stergeRevinoButton;
        private System.Windows.Forms.Label stergeLabel;
    }
}