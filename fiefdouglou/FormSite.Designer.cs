namespace fiefdouglou
{
    partial class FormSite
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
            this.fiefdouglouDataSet1 = new fiefdouglou.fiefdouglouDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.technicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.etatMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAdresseSite = new System.Windows.Forms.Label();
            this.labelNomSite = new System.Windows.Forms.Label();
            this.textBoxAdresseSite = new System.Windows.Forms.TextBox();
            this.comboBoxSiteNom = new System.Windows.Forms.ComboBox();
            this.ButtonIntervention = new System.Windows.Forms.Button();
            this.ButtonNewIntervention = new System.Windows.Forms.Button();
            this.buttonValiderSite = new System.Windows.Forms.Button();
            this.buttonRetourSite = new System.Windows.Forms.Button();
            this.listViewStephane = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fiefdouglouDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fiefdouglouDataSet1
            // 
            this.fiefdouglouDataSet1.DataSetName = "fiefdouglouDataSet";
            this.fiefdouglouDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteToolStripMenuItem,
            this.clientToolStripMenuItem1,
            this.matérielToolStripMenuItem1,
            this.interventionToolStripMenuItem1,
            this.technicienToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.siteToolStripMenuItem.Text = "Site...";
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.clientToolStripMenuItem1.Text = "Client...";
            // 
            // matérielToolStripMenuItem1
            // 
            this.matérielToolStripMenuItem1.Name = "matérielToolStripMenuItem1";
            this.matérielToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.matérielToolStripMenuItem1.Text = "Matériel";
            // 
            // interventionToolStripMenuItem1
            // 
            this.interventionToolStripMenuItem1.Name = "interventionToolStripMenuItem1";
            this.interventionToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.interventionToolStripMenuItem1.Text = "Intervention";
            // 
            // technicienToolStripMenuItem
            // 
            this.technicienToolStripMenuItem.Name = "technicienToolStripMenuItem";
            this.technicienToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.technicienToolStripMenuItem.Text = "Technicien";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interventionToolStripMenuItem2,
            this.etatMaterielToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // interventionToolStripMenuItem2
            // 
            this.interventionToolStripMenuItem2.Name = "interventionToolStripMenuItem2";
            this.interventionToolStripMenuItem2.Size = new System.Drawing.Size(186, 26);
            this.interventionToolStripMenuItem2.Text = "Intervention...";
            // 
            // etatMaterielToolStripMenuItem
            // 
            this.etatMaterielToolStripMenuItem.Name = "etatMaterielToolStripMenuItem";
            this.etatMaterielToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.etatMaterielToolStripMenuItem.Text = "Etat Materiel...";
            // 
            // labelAdresseSite
            // 
            this.labelAdresseSite.AutoSize = true;
            this.labelAdresseSite.Location = new System.Drawing.Point(413, 85);
            this.labelAdresseSite.Name = "labelAdresseSite";
            this.labelAdresseSite.Size = new System.Drawing.Size(60, 17);
            this.labelAdresseSite.TabIndex = 20;
            this.labelAdresseSite.Text = "Adresse";
            // 
            // labelNomSite
            // 
            this.labelNomSite.AutoSize = true;
            this.labelNomSite.Location = new System.Drawing.Point(34, 85);
            this.labelNomSite.Name = "labelNomSite";
            this.labelNomSite.Size = new System.Drawing.Size(83, 17);
            this.labelNomSite.TabIndex = 20;
            this.labelNomSite.Text = "Nom du site";
            // 
            // textBoxAdresseSite
            // 
            this.textBoxAdresseSite.Location = new System.Drawing.Point(512, 85);
            this.textBoxAdresseSite.Name = "textBoxAdresseSite";
            this.textBoxAdresseSite.Size = new System.Drawing.Size(194, 22);
            this.textBoxAdresseSite.TabIndex = 1;
            // 
            // comboBoxSiteNom
            // 
            this.comboBoxSiteNom.FormattingEnabled = true;
            this.comboBoxSiteNom.Location = new System.Drawing.Point(148, 83);
            this.comboBoxSiteNom.Name = "comboBoxSiteNom";
            this.comboBoxSiteNom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSiteNom.TabIndex = 0;
            // 
            // ButtonIntervention
            // 
            this.ButtonIntervention.Location = new System.Drawing.Point(56, 371);
            this.ButtonIntervention.Name = "ButtonIntervention";
            this.ButtonIntervention.Size = new System.Drawing.Size(95, 67);
            this.ButtonIntervention.TabIndex = 3;
            this.ButtonIntervention.Text = "intervention en cours";
            this.ButtonIntervention.UseVisualStyleBackColor = true;
            this.ButtonIntervention.Click += new System.EventHandler(this.ButtonIntervention_Click);
            // 
            // ButtonNewIntervention
            // 
            this.ButtonNewIntervention.Location = new System.Drawing.Point(263, 371);
            this.ButtonNewIntervention.Name = "ButtonNewIntervention";
            this.ButtonNewIntervention.Size = new System.Drawing.Size(95, 67);
            this.ButtonNewIntervention.TabIndex = 4;
            this.ButtonNewIntervention.Text = "ajouter nouvelle intervention";
            this.ButtonNewIntervention.UseVisualStyleBackColor = true;
            this.ButtonNewIntervention.Click += new System.EventHandler(this.ButtonNewIntervention_Click);
            // 
            // buttonValiderSite
            // 
            this.buttonValiderSite.Location = new System.Drawing.Point(490, 383);
            this.buttonValiderSite.Name = "buttonValiderSite";
            this.buttonValiderSite.Size = new System.Drawing.Size(95, 38);
            this.buttonValiderSite.TabIndex = 5;
            this.buttonValiderSite.Text = "Valider";
            this.buttonValiderSite.UseVisualStyleBackColor = true;
            this.buttonValiderSite.Click += new System.EventHandler(this.buttonValiderSite_Click);
            // 
            // buttonRetourSite
            // 
            this.buttonRetourSite.Location = new System.Drawing.Point(665, 383);
            this.buttonRetourSite.Name = "buttonRetourSite";
            this.buttonRetourSite.Size = new System.Drawing.Size(95, 38);
            this.buttonRetourSite.TabIndex = 6;
            this.buttonRetourSite.Text = "Retour";
            this.buttonRetourSite.UseVisualStyleBackColor = true;
            this.buttonRetourSite.Click += new System.EventHandler(this.buttonRetourSite_Click);
            // 
            // listViewStephane
            // 
            this.listViewStephane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewStephane.HideSelection = false;
            this.listViewStephane.LabelWrap = false;
            this.listViewStephane.Location = new System.Drawing.Point(138, 145);
            this.listViewStephane.Name = "listViewStephane";
            this.listViewStephane.Size = new System.Drawing.Size(568, 183);
            this.listViewStephane.TabIndex = 22;
            this.listViewStephane.UseCompatibleStateImageBehavior = false;
            this.listViewStephane.View = System.Windows.Forms.View.List;
            // 
            // FormSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewStephane);
            this.Controls.Add(this.buttonRetourSite);
            this.Controls.Add(this.buttonValiderSite);
            this.Controls.Add(this.ButtonNewIntervention);
            this.Controls.Add(this.ButtonIntervention);
            this.Controls.Add(this.comboBoxSiteNom);
            this.Controls.Add(this.textBoxAdresseSite);
            this.Controls.Add(this.labelNomSite);
            this.Controls.Add(this.labelAdresseSite);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormSite";
            this.Text = "Site";
            this.Load += new System.EventHandler(this.FormSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiefdouglouDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fiefdouglouDataSet fiefdouglouDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem technicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem etatMaterielToolStripMenuItem;
        private System.Windows.Forms.Label labelAdresseSite;
        private System.Windows.Forms.Label labelNomSite;
        private System.Windows.Forms.TextBox textBoxAdresseSite;
        private System.Windows.Forms.ComboBox comboBoxSiteNom;
        private System.Windows.Forms.Button ButtonIntervention;
        private System.Windows.Forms.Button ButtonNewIntervention;
        private System.Windows.Forms.Button buttonValiderSite;
        private System.Windows.Forms.Button buttonRetourSite;
        private System.Windows.Forms.ListView listViewStephane;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
