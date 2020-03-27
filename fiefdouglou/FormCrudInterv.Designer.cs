namespace fiefdouglou
{
    partial class FormCrudInterv
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
            this.listBoxInterv = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMatId = new System.Windows.Forms.ComboBox();
            this.comboBoxTechId = new System.Windows.Forms.ComboBox();
            this.comboBoxClientId = new System.Windows.Forms.ComboBox();
            this.comboBoxSitetId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoginClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMailClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.fiefdouglouDataSet = new fiefdouglou.fiefdouglouDataSet();
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteTableAdapter = new fiefdouglou.fiefdouglouDataSetTableAdapters.siteTableAdapter();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiefdouglouDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxInterv
            // 
            this.listBoxInterv.FormattingEnabled = true;
            this.listBoxInterv.ItemHeight = 16;
            this.listBoxInterv.Location = new System.Drawing.Point(15, 53);
            this.listBoxInterv.Name = "listBoxInterv";
            this.listBoxInterv.Size = new System.Drawing.Size(179, 308);
            this.listBoxInterv.TabIndex = 0;
            this.listBoxInterv.SelectedIndexChanged += new System.EventHandler(this.listBoxClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Clients :";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(545, 338);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 41);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Fermer";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.comboBoxMatId);
            this.groupBox1.Controls.Add(this.comboBoxTechId);
            this.groupBox1.Controls.Add(this.comboBoxClientId);
            this.groupBox1.Controls.Add(this.comboBoxSitetId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxLoginClient);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMailClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(216, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 340);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // comboBoxMatId
            // 
            this.comboBoxMatId.FormattingEnabled = true;
            this.comboBoxMatId.Location = new System.Drawing.Point(91, 115);
            this.comboBoxMatId.Name = "comboBoxMatId";
            this.comboBoxMatId.Size = new System.Drawing.Size(201, 24);
            this.comboBoxMatId.TabIndex = 107;
            // 
            // comboBoxTechId
            // 
            this.comboBoxTechId.FormattingEnabled = true;
            this.comboBoxTechId.Location = new System.Drawing.Point(91, 159);
            this.comboBoxTechId.Name = "comboBoxTechId";
            this.comboBoxTechId.Size = new System.Drawing.Size(201, 24);
            this.comboBoxTechId.TabIndex = 106;
            // 
            // comboBoxClientId
            // 
            this.comboBoxClientId.FormattingEnabled = true;
            this.comboBoxClientId.Location = new System.Drawing.Point(91, 79);
            this.comboBoxClientId.Name = "comboBoxClientId";
            this.comboBoxClientId.Size = new System.Drawing.Size(201, 24);
            this.comboBoxClientId.TabIndex = 105;
            // 
            // comboBoxSitetId
            // 
            this.comboBoxSitetId.FormattingEnabled = true;
            this.comboBoxSitetId.Location = new System.Drawing.Point(91, 45);
            this.comboBoxSitetId.Name = "comboBoxSitetId";
            this.comboBoxSitetId.Size = new System.Drawing.Size(201, 24);
            this.comboBoxSitetId.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 103;
            this.label8.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Site";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Date";
            // 
            // textBoxLoginClient
            // 
            this.textBoxLoginClient.Location = new System.Drawing.Point(91, 202);
            this.textBoxLoginClient.Name = "textBoxLoginClient";
            this.textBoxLoginClient.Size = new System.Drawing.Size(201, 22);
            this.textBoxLoginClient.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 99;
            this.label7.Text = "Commentaire";
            // 
            // textBoxMailClient
            // 
            this.textBoxMailClient.Location = new System.Drawing.Point(91, 281);
            this.textBoxMailClient.Name = "textBoxMailClient";
            this.textBoxMailClient.Size = new System.Drawing.Size(201, 22);
            this.textBoxMailClient.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Valide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Matériel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Technicien";
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterClient.Location = new System.Drawing.Point(545, 62);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(138, 41);
            this.buttonAjouterClient.TabIndex = 1;
            this.buttonAjouterClient.Text = "Ajouter";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(545, 279);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(138, 41);
            this.buttonValider.TabIndex = 5;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerClient.Location = new System.Drawing.Point(545, 168);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(138, 41);
            this.buttonSupprimerClient.TabIndex = 3;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = true;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierClient.Location = new System.Drawing.Point(545, 115);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(138, 41);
            this.buttonModifierClient.TabIndex = 2;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = true;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(545, 222);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(138, 41);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // fiefdouglouDataSet
            // 
            this.fiefdouglouDataSet.DataSetName = "fiefdouglouDataSet";
            this.fiefdouglouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "site";
            this.siteBindingSource.DataSource = this.fiefdouglouDataSet;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(91, 244);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(201, 22);
            this.dateTimePickerDate.TabIndex = 100;
            this.dateTimePickerDate.Value = new System.DateTime(2020, 3, 25, 12, 40, 41, 0);
            // 
            // FormCrudInterv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(695, 391);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonModifierClient);
            this.Controls.Add(this.buttonSupprimerClient);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAjouterClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxInterv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrudInterv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crud Interv";
            this.Load += new System.EventHandler(this.FormCrudClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiefdouglouDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInterv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMailClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoginClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMatId;
        private System.Windows.Forms.ComboBox comboBoxTechId;
        private System.Windows.Forms.ComboBox comboBoxClientId;
        private System.Windows.Forms.ComboBox comboBoxSitetId;
        private fiefdouglouDataSet fiefdouglouDataSet;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private fiefdouglouDataSetTableAdapters.siteTableAdapter siteTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
    }
}