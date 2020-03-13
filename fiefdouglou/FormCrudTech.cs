using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fiefdouglou
{
    public partial class FormCrudTech : Form
    {
        private string mode;

        public FormCrudTech()
        {
            InitializeComponent();
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCrudTech_Load(object sender, EventArgs e)
        {
            chargeSite();
        }

        private void chargeSite()
        {
            listBoxTech.Items.Clear();
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                strSQLClient = "SELECT * FROM technicien";
                drSQLClient = Connection.openConnection(strSQLClient);

                while (drSQLClient.Read())
                {
                    listBoxTech.Items.Add(drSQLClient["nom"].ToString());
                };
                Connection.closeConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Connection.closeConnection();
            }

            EnableSite(false);
        }
        // on rend clickable ou non nos éléments
        private void EnableSite(bool b)
        {
            textBoxNomTech.Enabled = b;
            textBoxIntervTech.Enabled = b;
            listBoxTech.Enabled = !b;
            buttonAjouterSite.Enabled = !b;
            buttonValiderSite.Enabled = b;
            buttonModifierSite.Enabled = !b;
            buttonSupprimerSite.Enabled = !b;
            buttonAnnulerSite.Enabled = b;
        }

        private void listBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            strSQLClient = "SELECT * FROM technicien where nom = '" + listBoxTech.SelectedItem.ToString() + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            drSQLClient.Read();

            textBoxNomTech.Text = drSQLClient["nom"].ToString();
            textBoxIntervTech.Text = drSQLClient["id_intervention"].ToString();

            Connection.closeConnection();
        }

        private void buttonSupprimerSite_Click(object sender, EventArgs e)
        {
            if (listBoxTech.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un site !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxTech.Focus();
                return;
            }

            string sternom = textBoxNomTech.Text;

            string strSQLClient = "";

            strSQLClient = "delete from technicien where nom = '" + sternom + "'";
            Connection.executeQuery(strSQLClient);

            chargeSite();
            EffaceInformationsSite();
        }
        // on vide tout les éléments
        private void EffaceInformationsSite()
        {
            textBoxNomTech.Text = "";
            textBoxIntervTech.Text = "";
        }

        private void buttonAnnulerSite_Click(object sender, EventArgs e)
        {
            EffaceInformationsSite();
            EnableSite(false);
            mode = "";
        }

        private void buttonAjouterSite_Click(object sender, EventArgs e)
        {
            EffaceInformationsSite();

            EnableSite(true);

            textBoxNomTech.Focus();
            mode = "Ajouter";
        }

        private void buttonModifierSite_Click(object sender, EventArgs e)
        {
            if (listBoxTech.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxTech.Focus();
                return;
            }

            EnableSite(true);

            textBoxNomTech.Focus();
            mode = "Modifier";
        }

        private void buttonValiderSite_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = textBoxNomTech.Text;
            string stradr = textBoxIntervTech.Text;

            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de Site vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ajout
            if (mode == "Ajouter")
            {
                strSQL = string.Format("INSERT INTO technicien(id_intervention, nom) VALUES({0}, '{1}')", stradr, sternom);
            }
            else if (mode == "Modifier")
            {
                // id du site
                int idsite;
                string sql2 = "select * from technicien  where nom = '" + listBoxTech.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idsite = Convert.ToInt32(drSQLInterv["id_technicien"]);
                drSQLInterv.Close();

                // modification des informations
                strSQL = string.Format("UPDATE technicien SET id_intervention = {0}, nom = '{1}' where id_technicien = {2}", stradr, sternom, idsite);
            }
            else
            {
                throw new Exception("Mode invalide");
            }
            Connection.executeQuery(strSQL);
            Connection.closeConnection();
            chargeSite();
            EffaceInformationsSite();
        }
    }
}
