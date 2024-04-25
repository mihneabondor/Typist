namespace Typist
{
    partial class interfataJocSingur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfataJocSingur));
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.pauzaReincepeButton = new System.Windows.Forms.Button();
            this.renuntaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.Color.DimGray;
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox.Location = new System.Drawing.Point(59, 113);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(679, 213);
            this.textbox.TabIndex = 0;
            this.textbox.Text = "Hello world";
            this.textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textFieldClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Gold;
            this.timerLabel.Location = new System.Drawing.Point(53, 79);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(44, 31);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "30";
            // 
            // pauzaReincepeButton
            // 
            this.pauzaReincepeButton.BackColor = System.Drawing.Color.Gold;
            this.pauzaReincepeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauzaReincepeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pauzaReincepeButton.Location = new System.Drawing.Point(689, 404);
            this.pauzaReincepeButton.Name = "pauzaReincepeButton";
            this.pauzaReincepeButton.Size = new System.Drawing.Size(99, 34);
            this.pauzaReincepeButton.TabIndex = 14;
            this.pauzaReincepeButton.Text = "Pauza";
            this.pauzaReincepeButton.UseVisualStyleBackColor = false;
            this.pauzaReincepeButton.Click += new System.EventHandler(this.pauzaReincepeButton_Click);
            // 
            // renuntaButton
            // 
            this.renuntaButton.BackColor = System.Drawing.Color.Gold;
            this.renuntaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renuntaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.renuntaButton.Location = new System.Drawing.Point(12, 404);
            this.renuntaButton.Name = "renuntaButton";
            this.renuntaButton.Size = new System.Drawing.Size(99, 34);
            this.renuntaButton.TabIndex = 15;
            this.renuntaButton.Text = "Renunta";
            this.renuntaButton.UseVisualStyleBackColor = false;
            this.renuntaButton.Click += new System.EventHandler(this.renuntaButton_Click);
            // 
            // interfataJocSingur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renuntaButton);
            this.Controls.Add(this.pauzaReincepeButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "interfataJocSingur";
            this.Text = "Typist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button pauzaReincepeButton;
        private System.Windows.Forms.Button renuntaButton;
    }
}