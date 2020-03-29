namespace fiefdouglou
{
    partial class FormListInterv
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
            this.listViewMat = new System.Windows.Forms.ListView();
            this.columnHeaderNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMat = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMat
            // 
            this.listViewMat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNom,
            this.columnHeaderSerie,
            this.columnHeaderDate,
            this.columnHeaderVal,
            this.columnHeaderClient,
            this.columnHeaderTech});
            this.listViewMat.HideSelection = false;
            this.listViewMat.Location = new System.Drawing.Point(12, 249);
            this.listViewMat.Name = "listViewMat";
            this.listViewMat.Size = new System.Drawing.Size(913, 167);
            this.listViewMat.TabIndex = 10;
            this.listViewMat.UseCompatibleStateImageBehavior = false;
            this.listViewMat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Matériels";
            this.columnHeaderNom.Width = 110;
            // 
            // columnHeaderSerie
            // 
            this.columnHeaderSerie.Text = "Commentaires";
            this.columnHeaderSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSerie.Width = 123;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Dates";
            this.columnHeaderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDate.Width = 137;
            // 
            // columnHeaderVal
            // 
            this.columnHeaderVal.Text = "Valide";
            this.columnHeaderVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Technicien";
            this.columnHeaderClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderClient.Width = 124;
            // 
            // columnHeaderTech
            // 
            this.columnHeaderTech.Text = "Paramêtres";
            this.columnHeaderTech.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(330, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liste des Interventions";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(787, 442);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 41);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "Fermer";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMat);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.comboBoxClient);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBoxSite);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(64, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres";
            // 
            // comboBoxMat
            // 
            this.comboBoxMat.FormattingEnabled = true;
            this.comboBoxMat.Location = new System.Drawing.Point(128, 90);
            this.comboBoxMat.Name = "comboBoxMat";
            this.comboBoxMat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMat.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(278, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "Matériel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(434, 90);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 40);
            this.button6.TabIndex = 8;
            this.button6.Text = "Type";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(434, 28);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClient.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(133, 28);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSite.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 55);
            this.button3.TabIndex = 11;
            this.button3.Text = "Anicennes Inteventions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 56);
            this.button4.TabIndex = 12;
            this.button4.Text = "Prochaines Interventions";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormListInterv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 495);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listViewMat);
            this.Controls.Add(this.label1);
            this.Name = "FormListInterv";
            this.Text = "FormListInterv";
            this.Load += new System.EventHandler(this.FormListInterv_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMat;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderSerie;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderVal;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderTech;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMat;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}