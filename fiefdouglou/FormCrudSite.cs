using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fiefdouglou
{
    public partial class FormCrudSite : Form
    {
        private string mode;

        public FormCrudSite()
        {
            InitializeComponent();
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCrudSite_Load(object sender, EventArgs e)
        {
            chargeSite();
        }

        private void chargeSite()
        {
            listBoxSite.Items.Clear();
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                strSQLClient = "SELECT * FROM site";
                drSQLClient = Connection.openConnection(strSQLClient);

                while (drSQLClient.Read())
                {
                    listBoxSite.Items.Add(drSQLClient["nom"].ToString());
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
            textBoxNomSite.Enabled = b;
            textBoxAdresseSite.Enabled = b;
            textBoxPostalSite.Enabled = b;
            textBoxVilleSite.Enabled = b;
            textBoxIdInterv.Enabled = b;
            listBoxSite.Enabled = !b;
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
            
            strSQLClient = "SELECT * FROM site where nom = '" + listBoxSite.SelectedItem.ToString() + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            drSQLClient.Read();

            textBoxNomSite.Text = drSQLClient["nom"].ToString();
            textBoxAdresseSite.Text = drSQLClient["adresse"].ToString();
            textBoxPostalSite.Text = drSQLClient["code_postal"].ToString();
            textBoxVilleSite.Text = drSQLClient["ville"].ToString();
            textBoxIdInterv.Text = drSQLClient["id_intervention"].ToString();

            Connection.closeConnection();
        }

        private void buttonSupprimerSite_Click(object sender, EventArgs e)
        {
            if (listBoxSite.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un site !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxSite.Focus();
                return;
            }

            string sternom = textBoxNomSite.Text;

            string strSQLClient = "";
            
            strSQLClient = "delete from site where nom = '" + sternom + "'";
            Connection.executeQuery(strSQLClient);

            chargeSite();
            EffaceInformationsSite();
        }
        // on vide tout les éléments
        private void EffaceInformationsSite()
        {
            textBoxNomSite.Text = "";
            textBoxAdresseSite.Text = "";
            textBoxPostalSite.Text = "";
            textBoxVilleSite.Text = "";
            textBoxIdInterv.Text = "";
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

            textBoxNomSite.Focus();
            mode = "Ajouter";
        }

        private void buttonModifierSite_Click(object sender, EventArgs e)
        {
            if (listBoxSite.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxSite.Focus();
                return;
            }

            EnableSite(true);

            textBoxNomSite.Focus();
            mode = "Modifier";
        }

        private void buttonValiderSite_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = textBoxNomSite.Text;
            string stradr = textBoxAdresseSite.Text;
            string strpst = textBoxPostalSite.Text;
            string strvle = textBoxVilleSite.Text;
            string strinterv = textBoxIdInterv.Text;

            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de Site vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ajout
            if (mode == "Ajouter")
            {
                strSQL = string.Format("INSERT INTO site(id_intervention, nom, adresse, code_postal, ville) VALUES({0}, '{1}', '{2}', '{3}', '{4}')", strinterv, sternom, stradr, strpst, strvle);
            }
            else if (mode == "Modifier")
            {
                // id du site
                int idsite;
                string sql2 = "select * from site  where nom = '" + listBoxSite.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idsite = Convert.ToInt32(drSQLInterv["id_site"]);
                drSQLInterv.Close();

                // modification des informations
                strSQL = string.Format("UPDATE site SET id_intervention = {0}, nom = '{1}', adresse = '{2}', code_postal = '{3}', ville = '{4}' where id_site = {5}", strinterv, sternom, stradr, strpst, strvle, idsite);
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
