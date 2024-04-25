
namespace Typist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.singurButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet = new Typist.DataSet();
            this.jucatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jucatoriTableAdapter = new Typist.DataSetTableAdapters.JucatoriTableAdapter();
            this.tableAdapterManager = new Typist.DataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(322, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Typist";
            // 
            // singurButton
            // 
            this.singurButton.BackColor = System.Drawing.Color.Gold;
            this.singurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singurButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.singurButton.Location = new System.Drawing.Point(6, 32);
            this.singurButton.Name = "singurButton";
            this.singurButton.Size = new System.Drawing.Size(221, 40);
            this.singurButton.TabIndex = 1;
            this.singurButton.Text = "Singur";
            this.singurButton.UseVisualStyleBackColor = false;
            this.singurButton.Click += new System.EventHandler(this.singurButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.singurButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(100, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joc nou";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(6, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cu un prieten";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.usernameTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(445, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jocuri precedente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume jucator";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(6, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Istoric jucator";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.Gold;
            this.usernameTextbox.Location = new System.Drawing.Point(6, 46);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(221, 26);
            this.usernameTextbox.TabIndex = 5;
            this.usernameTextbox.Text = "Scrie...";
            this.usernameTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedNumeTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(590, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aplicatie creata de Bondor Mihnea";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jucatoriBindingSource
            // 
            this.jucatoriBindingSource.DataMember = "Jucatori";
            this.jucatoriBindingSource.DataSource = this.dataSet;
            // 
            // jucatoriTableAdapter
            // 
            this.jucatoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CuvinteTableAdapter = null;
            this.tableAdapterManager.DetaliiTableAdapter = null;
            this.tableAdapterManager.EvidentaTableAdapter = null;
            this.tableAdapterManager.IntersectieTableAdapter = null;
            this.tableAdapterManager.JocuriTableAdapter = null;
            this.tableAdapterManager.JucatoriTableAdapter = this.jucatoriTableAdapter;
            this.tableAdapterManager.UpdateOrder = Typist.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(821, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Typist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singurButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label2;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource jucatoriBindingSource;
        private DataSetTableAdapters.JucatoriTableAdapter jucatoriTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

