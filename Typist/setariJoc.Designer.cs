
namespace Typist
{
    partial class setariJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setariJoc));
            this.label1 = new System.Windows.Forms.Label();
            this.numarCuvinteSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numarCuvinteLabel = new System.Windows.Forms.Label();
            this.durataLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.durataSlider = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numereCheckBox = new System.Windows.Forms.CheckBox();
            this.punctuatieCheckBox = new System.Windows.Forms.CheckBox();
            this.cuvinteCheckBox = new System.Windows.Forms.CheckBox();
            this.numeUtilizator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.inapoiButton = new System.Windows.Forms.Button();
            this.userStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numarCuvinteSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durataSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configureaza jocul";
            // 
            // numarCuvinteSlider
            // 
            this.numarCuvinteSlider.Location = new System.Drawing.Point(422, 137);
            this.numarCuvinteSlider.Maximum = 20;
            this.numarCuvinteSlider.Minimum = 5;
            this.numarCuvinteSlider.Name = "numarCuvinteSlider";
            this.numarCuvinteSlider.Size = new System.Drawing.Size(172, 45);
            this.numarCuvinteSlider.TabIndex = 2;
            this.numarCuvinteSlider.Value = 10;
            this.numarCuvinteSlider.Scroll += new System.EventHandler(this.numarCuvinteSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(419, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numar de cuvinte";
            // 
            // numarCuvinteLabel
            // 
            this.numarCuvinteLabel.AutoSize = true;
            this.numarCuvinteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numarCuvinteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numarCuvinteLabel.Location = new System.Drawing.Point(419, 166);
            this.numarCuvinteLabel.Name = "numarCuvinteLabel";
            this.numarCuvinteLabel.Size = new System.Drawing.Size(66, 16);
            this.numarCuvinteLabel.TabIndex = 6;
            this.numarCuvinteLabel.Text = "10 cuvinte";
            // 
            // durataLabel
            // 
            this.durataLabel.AutoSize = true;
            this.durataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.durataLabel.Location = new System.Drawing.Point(419, 302);
            this.durataLabel.Name = "durataLabel";
            this.durataLabel.Size = new System.Drawing.Size(76, 16);
            this.durataLabel.TabIndex = 9;
            this.durataLabel.Text = "10 secunde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(419, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durata";
            // 
            // durataSlider
            // 
            this.durataSlider.Location = new System.Drawing.Point(422, 273);
            this.durataSlider.Maximum = 30;
            this.durataSlider.Minimum = 10;
            this.durataSlider.Name = "durataSlider";
            this.durataSlider.Size = new System.Drawing.Size(172, 45);
            this.durataSlider.TabIndex = 7;
            this.durataSlider.Value = 10;
            this.durataSlider.Scroll += new System.EventHandler(this.durataSlider_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numereCheckBox);
            this.groupBox1.Controls.Add(this.punctuatieCheckBox);
            this.groupBox1.Controls.Add(this.cuvinteCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(213, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Include";
            // 
            // numereCheckBox
            // 
            this.numereCheckBox.AutoSize = true;
            this.numereCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numereCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numereCheckBox.Location = new System.Drawing.Point(6, 73);
            this.numereCheckBox.Name = "numereCheckBox";
            this.numereCheckBox.Size = new System.Drawing.Size(74, 20);
            this.numereCheckBox.TabIndex = 2;
            this.numereCheckBox.Text = "Numere";
            this.numereCheckBox.UseVisualStyleBackColor = true;
            // 
            // punctuatieCheckBox
            // 
            this.punctuatieCheckBox.AutoSize = true;
            this.punctuatieCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctuatieCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.punctuatieCheckBox.Location = new System.Drawing.Point(6, 47);
            this.punctuatieCheckBox.Name = "punctuatieCheckBox";
            this.punctuatieCheckBox.Size = new System.Drawing.Size(145, 20);
            this.punctuatieCheckBox.TabIndex = 1;
            this.punctuatieCheckBox.Text = "Semne de punctatie";
            this.punctuatieCheckBox.UseVisualStyleBackColor = true;
            // 
            // cuvinteCheckBox
            // 
            this.cuvinteCheckBox.AutoSize = true;
            this.cuvinteCheckBox.Checked = true;
            this.cuvinteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cuvinteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuvinteCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuvinteCheckBox.Location = new System.Drawing.Point(6, 21);
            this.cuvinteCheckBox.Name = "cuvinteCheckBox";
            this.cuvinteCheckBox.Size = new System.Drawing.Size(70, 20);
            this.cuvinteCheckBox.TabIndex = 0;
            this.cuvinteCheckBox.Text = "Cuvinte";
            this.cuvinteCheckBox.UseVisualStyleBackColor = true;
            // 
            // numeUtilizator
            // 
            this.numeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeUtilizator.Location = new System.Drawing.Point(213, 137);
            this.numeUtilizator.Name = "numeUtilizator";
            this.numeUtilizator.Size = new System.Drawing.Size(114, 22);
            this.numeUtilizator.TabIndex = 11;
            this.numeUtilizator.Text = "Scrie...";
            this.numeUtilizator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numeUtilizatorTextboxSelected);
            this.numeUtilizator.Leave += new System.EventHandler(this.usernameTextboxLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(210, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nume jucator";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Gold;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(689, 404);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(99, 34);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // inapoiButton
            // 
            this.inapoiButton.BackColor = System.Drawing.Color.Gold;
            this.inapoiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoiButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inapoiButton.Location = new System.Drawing.Point(12, 404);
            this.inapoiButton.Name = "inapoiButton";
            this.inapoiButton.Size = new System.Drawing.Size(99, 34);
            this.inapoiButton.TabIndex = 14;
            this.inapoiButton.Text = "Inapoi";
            this.inapoiButton.UseVisualStyleBackColor = false;
            this.inapoiButton.Click += new System.EventHandler(this.inapoiButton_Click);
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = true;
            this.userStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userStatusLabel.Location = new System.Drawing.Point(210, 166);
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(133, 16);
            this.userStatusLabel.TabIndex = 15;
            this.userStatusLabel.Text = "Status cont: inexistent";
            // 
            // setariJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userStatusLabel);
            this.Controls.Add(this.inapoiButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeUtilizator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.durataLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durataSlider);
            this.Controls.Add(this.numarCuvinteLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numarCuvinteSlider);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setariJoc";
            this.Text = "Configureaza jocul";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            ((System.ComponentModel.ISupportInitialize)(this.numarCuvinteSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durataSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar numarCuvinteSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numarCuvinteLabel;
        private System.Windows.Forms.Label durataLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar durataSlider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox numereCheckBox;
        private System.Windows.Forms.CheckBox punctuatieCheckBox;
        private System.Windows.Forms.CheckBox cuvinteCheckBox;
        private System.Windows.Forms.TextBox numeUtilizator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button inapoiButton;
        private System.Windows.Forms.Label userStatusLabel;
    }
}