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
            this.consulterLesOpérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddInterv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBoxMat = new System.Windows.Forms.ListBox();
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
            this.crudToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteToolStripMenuItem,
            this.clientToolStripMenuItem1,
            this.matérielToolStripMenuItem1,
            this.consulterLesOpérationsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.siteToolStripMenuItem.Text = "Ajouter Intervention...";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(252, 26);
            this.clientToolStripMenuItem1.Text = "Consulter interventions...";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // matérielToolStripMenuItem1
            // 
            this.matérielToolStripMenuItem1.Name = "matérielToolStripMenuItem1";
            this.matérielToolStripMenuItem1.Size = new System.Drawing.Size(252, 26);
            this.matérielToolStripMenuItem1.Text = "Consulter les matériels";
            this.matérielToolStripMenuItem1.Click += new System.EventHandler(this.matérielToolStripMenuItem1_Click);
            // 
            // consulterLesOpérationsToolStripMenuItem
            // 
            this.consulterLesOpérationsToolStripMenuItem.Name = "consulterLesOpérationsToolStripMenuItem";
            this.consulterLesOpérationsToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.consulterLesOpérationsToolStripMenuItem.Text = "Consulter les opérations";
            this.consulterLesOpérationsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesOpérationsToolStripMenuItem_Click);
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
            // buttonAddInterv
            // 
            this.buttonAddInterv.Location = new System.Drawing.Point(372, 138);
            this.buttonAddInterv.Name = "buttonAddInterv";
            this.buttonAddInterv.Size = new System.Drawing.Size(137, 59);
            this.buttonAddInterv.TabIndex = 2;
            this.buttonAddInterv.Text = "Ajouter une Intervention";
            this.buttonAddInterv.UseVisualStyleBackColor = true;
            this.buttonAddInterv.Click += new System.EventHandler(this.buttonAddInterv_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Consulter les Interventions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "Consulter les opérations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 59);
            this.button4.TabIndex = 5;
            this.button4.Text = "Consulter les matériels";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBoxMat
            // 
            this.listBoxMat.FormattingEnabled = true;
            this.listBoxMat.ItemHeight = 16;
            this.listBoxMat.Location = new System.Drawing.Point(25, 54);
            this.listBoxMat.Name = "listBoxMat";
            this.listBoxMat.Size = new System.Drawing.Size(298, 372);
            this.listBoxMat.TabIndex = 6;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.listBoxMat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddInterv);
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
        private System.Windows.Forms.ToolStripMenuItem crudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddInterv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBoxMat;
        private System.Windows.Forms.ToolStripMenuItem consulterLesOpérationsToolStripMenuItem;
    }
}

