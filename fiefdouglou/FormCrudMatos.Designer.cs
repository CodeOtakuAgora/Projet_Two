namespace fiefdouglou
{
    partial class FormCrudMatos
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
            this.listBoxMatos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPicture = new System.Windows.Forms.TextBox();
            this.pictureBoxMat = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxToto = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSiteMatos = new System.Windows.Forms.ComboBox();
            this.comboBoxClientMatos = new System.Windows.Forms.ComboBox();
            this.DateTimePickerIntervMatos = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTypeMatos = new System.Windows.Forms.ComboBox();
            this.textBoxMtbfMatos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDescMatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomMatos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMatos
            // 
            this.listBoxMatos.FormattingEnabled = true;
            this.listBoxMatos.ItemHeight = 16;
            this.listBoxMatos.Location = new System.Drawing.Point(15, 53);
            this.listBoxMatos.Name = "listBoxMatos";
            this.listBoxMatos.Size = new System.Drawing.Size(179, 308);
            this.listBoxMatos.TabIndex = 0;
            this.listBoxMatos.SelectedIndexChanged += new System.EventHandler(this.ListBoxClient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Matos :";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(683, 340);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 41);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Fermer";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxPicture);
            this.groupBox1.Controls.Add(this.pictureBoxMat);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.textBoxToto);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxSiteMatos);
            this.groupBox1.Controls.Add(this.comboBoxClientMatos);
            this.groupBox1.Controls.Add(this.DateTimePickerIntervMatos);
            this.groupBox1.Controls.Add(this.comboBoxTypeMatos);
            this.groupBox1.Controls.Add(this.textBoxMtbfMatos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxDescMatos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxNomMatos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(212, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 390);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 104;
            this.label10.Text = "Images";
            // 
            // textBoxPicture
            // 
            this.textBoxPicture.Location = new System.Drawing.Point(86, 295);
            this.textBoxPicture.Name = "textBoxPicture";
            this.textBoxPicture.Size = new System.Drawing.Size(175, 22);
            this.textBoxPicture.TabIndex = 102;
            // 
            // pictureBoxMat
            // 
            this.pictureBoxMat.Location = new System.Drawing.Point(279, 72);
            this.pictureBoxMat.Name = "pictureBoxMat";
            this.pictureBoxMat.Size = new System.Drawing.Size(137, 176);
            this.pictureBoxMat.TabIndex = 101;
            this.pictureBoxMat.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(111, 328);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(107, 46);
            this.buttonBrowse.TabIndex = 100;
            this.buttonBrowse.Text = "Parcourir";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // textBoxToto
            // 
            this.textBoxToto.Location = new System.Drawing.Point(86, 295);
            this.textBoxToto.Name = "textBoxToto";
            this.textBoxToto.Size = new System.Drawing.Size(175, 22);
            this.textBoxToto.TabIndex = 102;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(279, 72);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 176);
            this.pictureBox.TabIndex = 101;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 100;
            this.button1.Text = "Parcourir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // comboBoxSiteMatos
            // 
            this.comboBoxSiteMatos.FormattingEnabled = true;
            this.comboBoxSiteMatos.Location = new System.Drawing.Point(86, 72);
            this.comboBoxSiteMatos.Name = "comboBoxSiteMatos";
            this.comboBoxSiteMatos.Size = new System.Drawing.Size(175, 24);
            this.comboBoxSiteMatos.TabIndex = 9;
            // 
            // comboBoxClientMatos
            // 
            this.comboBoxClientMatos.FormattingEnabled = true;
            this.comboBoxClientMatos.Location = new System.Drawing.Point(86, 31);
            this.comboBoxClientMatos.Name = "comboBoxClientMatos";
            this.comboBoxClientMatos.Size = new System.Drawing.Size(175, 24);
            this.comboBoxClientMatos.TabIndex = 8;
            // 
            // DateTimePickerIntervMatos
            // 
            this.DateTimePickerIntervMatos.Location = new System.Drawing.Point(86, 226);
            this.DateTimePickerIntervMatos.Name = "DateTimePickerIntervMatos";
            this.DateTimePickerIntervMatos.Size = new System.Drawing.Size(174, 22);
            this.DateTimePickerIntervMatos.TabIndex = 13;
            // 
            // comboBoxTypeMatos
            // 
            this.comboBoxTypeMatos.FormattingEnabled = true;
            this.comboBoxTypeMatos.Location = new System.Drawing.Point(85, 187);
            this.comboBoxTypeMatos.Name = "comboBoxTypeMatos";
            this.comboBoxTypeMatos.Size = new System.Drawing.Size(175, 24);
            this.comboBoxTypeMatos.TabIndex = 12;
            // 
            // textBoxMtbfMatos
            // 
            this.textBoxMtbfMatos.Location = new System.Drawing.Point(85, 260);
            this.textBoxMtbfMatos.Name = "textBoxMtbfMatos";
            this.textBoxMtbfMatos.Size = new System.Drawing.Size(175, 22);
            this.textBoxMtbfMatos.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "MTBF";
            // 
            // textBoxDescMatos
            // 
            this.textBoxDescMatos.Location = new System.Drawing.Point(86, 150);
            this.textBoxDescMatos.Name = "textBoxDescMatos";
            this.textBoxDescMatos.Size = new System.Drawing.Size(175, 22);
            this.textBoxDescMatos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Description";
            // 
            // textBoxNomMatos
            // 
            this.textBoxNomMatos.Location = new System.Drawing.Point(88, 108);
            this.textBoxNomMatos.Name = "textBoxNomMatos";
            this.textBoxNomMatos.Size = new System.Drawing.Size(175, 22);
            this.textBoxNomMatos.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 99;
            this.label7.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Interv ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Client";
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterClient.Location = new System.Drawing.Point(683, 64);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(138, 41);
            this.buttonAjouterClient.TabIndex = 1;
            this.buttonAjouterClient.Text = "Ajouter";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.ButtonAjouterClient_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(683, 281);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(138, 41);
            this.buttonValider.TabIndex = 5;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerClient.Location = new System.Drawing.Point(683, 170);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(138, 41);
            this.buttonSupprimerClient.TabIndex = 3;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = true;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.ButtonSupprimerClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierClient.Location = new System.Drawing.Point(683, 117);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(138, 41);
            this.buttonModifierClient.TabIndex = 2;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = true;
            this.buttonModifierClient.Click += new System.EventHandler(this.ButtonModifierClient_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(683, 224);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(138, 41);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // FormCrudMatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonModifierClient);
            this.Controls.Add(this.buttonSupprimerClient);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAjouterClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrudMatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crud Matos";
            this.Load += new System.EventHandler(this.FormCrudMatos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxDescMatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomMatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMtbfMatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTypeMatos;
        private System.Windows.Forms.DateTimePicker DateTimePickerIntervMatos;
        private System.Windows.Forms.ComboBox comboBoxSiteMatos;
        private System.Windows.Forms.ComboBox comboBoxClientMatos;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxMat;
        private System.Windows.Forms.TextBox textBoxPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxToto;
        private System.Windows.Forms.Label label10;
    }
}