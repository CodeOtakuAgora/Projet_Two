namespace fiefdouglou
{
    partial class FormGM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonSite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.listViewMateriel = new System.Windows.Forms.ListView();
            this.columnHeaderNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMTBF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermer.Location = new System.Drawing.Point(972, 628);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(135, 43);
            this.buttonFermer.TabIndex = 7;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(45, 38);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(160, 59);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client ...";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonSite
            // 
            this.buttonSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSite.Location = new System.Drawing.Point(227, 38);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(160, 59);
            this.buttonSite.TabIndex = 1;
            this.buttonSite.Text = "Site ...";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.buttonSite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRechercher);
            this.groupBox1.Controls.Add(this.listViewMateriel);
            this.groupBox1.Location = new System.Drawing.Point(45, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(506, 35);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(207, 39);
            this.comboBoxSite.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 99;
            this.label2.Text = "Site :";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(135, 35);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(207, 39);
            this.comboBoxClient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 99;
            this.label1.Text = "Client :";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(867, 35);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(185, 48);
            this.buttonRechercher.TabIndex = 5;
            this.buttonRechercher.Text = "Chercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // listViewMateriel
            // 
            this.listViewMateriel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNom,
            this.columnHeaderSerie,
            this.columnHeaderDate,
            this.columnHeaderMTBF,
            this.columnHeaderSite,
            this.columnHeaderClient});
            this.listViewMateriel.HideSelection = false;
            this.listViewMateriel.Location = new System.Drawing.Point(30, 107);
            this.listViewMateriel.Name = "listViewMateriel";
            this.listViewMateriel.Size = new System.Drawing.Size(1022, 181);
            this.listViewMateriel.TabIndex = 6;
            this.listViewMateriel.UseCompatibleStateImageBehavior = false;
            this.listViewMateriel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Matériels";
            this.columnHeaderNom.Width = 139;
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
            // columnHeaderMTBF
            // 
            this.columnHeaderMTBF.Text = "MTBF";
            this.columnHeaderMTBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderSite
            // 
            this.columnHeaderSite.Text = "Clients";
            this.columnHeaderSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSite.Width = 150;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Sites";
            this.columnHeaderClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderClient.Width = 150;
            // 
            // FormGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSite);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Matos";
            this.Load += new System.EventHandler(this.FormGM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.ListView listViewMateriel;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderSerie;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderMTBF;
        private System.Windows.Forms.ColumnHeader columnHeaderSite;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label label1;
    }
}

