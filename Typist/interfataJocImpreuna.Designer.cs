namespace Typist
{
    partial class interfataJocImpreuna
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfataJocImpreuna));
            this.timerLabel = new System.Windows.Forms.Label();
            this.hostTextbox = new System.Windows.Forms.RichTextBox();
            this.guestTextbox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Gold;
            this.timerLabel.Location = new System.Drawing.Point(42, 29);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(44, 31);
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "30";
            // 
            // hostTextbox
            // 
            this.hostTextbox.BackColor = System.Drawing.Color.DimGray;
            this.hostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hostTextbox.Location = new System.Drawing.Point(48, 63);
            this.hostTextbox.Name = "hostTextbox";
            this.hostTextbox.Size = new System.Drawing.Size(679, 213);
            this.hostTextbox.TabIndex = 2;
            this.hostTextbox.Text = "Hello world";
            this.hostTextbox.TextChanged += new System.EventHandler(this.hostTextbox_TextChanged);
            // 
            // guestTextbox
            // 
            this.guestTextbox.BackColor = System.Drawing.Color.DimGray;
            this.guestTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestTextbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guestTextbox.Location = new System.Drawing.Point(48, 303);
            this.guestTextbox.Name = "guestTextbox";
            this.guestTextbox.ReadOnly = true;
            this.guestTextbox.Size = new System.Drawing.Size(679, 211);
            this.guestTextbox.TabIndex = 4;
            this.guestTextbox.Text = "Hello world";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // interfataJocImpreuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.guestTextbox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.hostTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "interfataJocImpreuna";
            this.Text = "Joc impreuna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.RichTextBox hostTextbox;
        private System.Windows.Forms.RichTextBox guestTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}