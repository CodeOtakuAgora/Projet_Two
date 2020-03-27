namespace fiefdouglou
{
    partial class FormCrud
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
            this.buttonMatos = new System.Windows.Forms.Button();
            this.buttonTech = new System.Windows.Forms.Button();
            this.buttonInterv = new System.Windows.Forms.Button();
            this.groupBoxCrud = new System.Windows.Forms.GroupBox();
            this.groupBoxCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermer.Location = new System.Drawing.Point(996, 533);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(135, 43);
            this.buttonFermer.TabIndex = 8;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(419, 42);
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
            this.buttonSite.Location = new System.Drawing.Point(142, 42);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(160, 59);
            this.buttonSite.TabIndex = 1;
            this.buttonSite.Text = "Site ...";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.buttonSite_Click);
            // 
            // buttonMatos
            // 
            this.buttonMatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatos.Location = new System.Drawing.Point(142, 149);
            this.buttonMatos.Name = "buttonMatos";
            this.buttonMatos.Size = new System.Drawing.Size(160, 59);
            this.buttonMatos.TabIndex = 2;
            this.buttonMatos.Text = "Matos ...";
            this.buttonMatos.UseVisualStyleBackColor = true;
            this.buttonMatos.Click += new System.EventHandler(this.buttonMatos_Click);
            // 
            // buttonTech
            // 
            this.buttonTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTech.Location = new System.Drawing.Point(419, 149);
            this.buttonTech.Name = "buttonTech";
            this.buttonTech.Size = new System.Drawing.Size(160, 59);
            this.buttonTech.TabIndex = 3;
            this.buttonTech.Text = "Tech ...";
            this.buttonTech.UseVisualStyleBackColor = true;
            this.buttonTech.Click += new System.EventHandler(this.buttonTech_Click);
            // 
            // buttonInterv
            // 
            this.buttonInterv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterv.Location = new System.Drawing.Point(280, 261);
            this.buttonInterv.Name = "buttonInterv";
            this.buttonInterv.Size = new System.Drawing.Size(160, 59);
            this.buttonInterv.TabIndex = 4;
            this.buttonInterv.Text = "Interv ...";
            this.buttonInterv.UseVisualStyleBackColor = true;
            this.buttonInterv.Click += new System.EventHandler(this.buttonInterv_Click);
            // 
            // groupBoxCrud
            // 
            this.groupBoxCrud.Controls.Add(this.buttonClient);
            this.groupBoxCrud.Controls.Add(this.buttonInterv);
            this.groupBoxCrud.Controls.Add(this.buttonSite);
            this.groupBoxCrud.Controls.Add(this.buttonTech);
            this.groupBoxCrud.Controls.Add(this.buttonMatos);
            this.groupBoxCrud.Location = new System.Drawing.Point(239, 116);
            this.groupBoxCrud.Name = "groupBoxCrud";
            this.groupBoxCrud.Size = new System.Drawing.Size(694, 366);
            this.groupBoxCrud.TabIndex = 9;
            this.groupBoxCrud.TabStop = false;
            this.groupBoxCrud.Text = "Listes des Crud";
            // 
            // FormCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 692);
            this.Controls.Add(this.groupBoxCrud);
            this.Controls.Add(this.buttonFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud Gestion Matos";
            this.groupBoxCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.Button buttonMatos;
        private System.Windows.Forms.Button buttonTech;
        private System.Windows.Forms.Button buttonInterv;
        private System.Windows.Forms.GroupBox groupBoxCrud;
    }
}

