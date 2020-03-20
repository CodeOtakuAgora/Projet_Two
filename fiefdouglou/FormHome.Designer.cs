namespace fiefdouglou
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interventionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.crudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewInterv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTest = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listViewRetest = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitesToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.matérielToolStripMenuItem,
            this.interventionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 100);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.sitesToolStripMenuItem.Text = "Site...";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.clientToolStripMenuItem.Text = "Client...";
            // 
            // matérielToolStripMenuItem
            // 
            this.matérielToolStripMenuItem.Name = "matérielToolStripMenuItem";
            this.matérielToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.matérielToolStripMenuItem.Text = "Matériel...";
            // 
            // interventionToolStripMenuItem
            // 
            this.interventionToolStripMenuItem.Name = "interventionToolStripMenuItem";
            this.interventionToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.interventionToolStripMenuItem.Text = "Intervention...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.crudToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.clientToolStripMenuItem1.Text = "Client...";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
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
            this.interventionToolStripMenuItem1.Click += new System.EventHandler(this.interventionToolStripMenuItem1_Click);
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
            // crudToolStripMenuItem
            // 
            this.crudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.crudToolStripMenuItem.Name = "crudToolStripMenuItem";
            this.crudToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.crudToolStripMenuItem.Text = "Crud";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.gestionToolStripMenuItem.Text = "Gestion";
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(242, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 99;
            this.label1.Text = "Matériels Fonctionnel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewInterv
            // 
            this.listViewInterv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewInterv.HideSelection = false;
            this.listViewInterv.LabelWrap = false;
            this.listViewInterv.Location = new System.Drawing.Point(47, 220);
            this.listViewInterv.Name = "listViewInterv";
            this.listViewInterv.Size = new System.Drawing.Size(659, 67);
            this.listViewInterv.TabIndex = 3;
            this.listViewInterv.UseCompatibleStateImageBehavior = false;
            this.listViewInterv.View = System.Windows.Forms.View.List;
            // 
            // listViewTest
            // 
            this.listViewTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewTest.HideSelection = false;
            this.listViewTest.LabelWrap = false;
            this.listViewTest.Location = new System.Drawing.Point(47, 82);
            this.listViewTest.Name = "listViewTest";
            this.listViewTest.Size = new System.Drawing.Size(659, 75);
            this.listViewTest.TabIndex = 2;
            this.listViewTest.UseCompatibleStateImageBehavior = false;
            this.listViewTest.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(251, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 36);
            this.label2.TabIndex = 99;
            this.label2.Text = "Matériels Périmés";
            // 
            // listViewRetest
            // 
            this.listViewRetest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewRetest.HideSelection = false;
            this.listViewRetest.LabelWrap = false;
            this.listViewRetest.Location = new System.Drawing.Point(56, 356);
            this.listViewRetest.Name = "listViewRetest";
            this.listViewRetest.Size = new System.Drawing.Size(643, 77);
            this.listViewRetest.TabIndex = 4;
            this.listViewRetest.UseCompatibleStateImageBehavior = false;
            this.listViewRetest.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(242, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 36);
            this.label3.TabIndex = 99;
            this.label3.Text = "Prochaines Interventions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewRetest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewTest);
            this.Controls.Add(this.listViewInterv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interventionToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem crudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewInterv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewTest;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewRetest;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
    }
}

