using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormCrudClient : Form
    {
        private string mode;

        public FormCrudClient()
        {
            InitializeComponent();
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCrudClient_Load(object sender, EventArgs e)
        {
            chargeClient();
        }

        private void chargeClient()
        {
            listBoxClient.Items.Clear();
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                strSQLClient = "SELECT * FROM client";
                drSQLClient = Connection.openConnection(strSQLClient);

                while (drSQLClient.Read())
                {
                    listBoxClient.Items.Add(drSQLClient["nom"].ToString());
                };
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



            EnableClient(false);
        }

        private void EnableClient(bool b)
        {
            textBoxIntervClient.Enabled = b;
            textBoxSiteClient.Enabled = b;
            textBoxLoginClient.Enabled = b;
            textBoxPassClient.Enabled = b;
            textBoxTelClient.Enabled = b;
            textBoxMailClient.Enabled = b;
            listBoxClient.Enabled = !b;
            buttonAjouterClient.Enabled = !b;
            buttonValider.Enabled = b;
            buttonModifierClient.Enabled = !b;
            buttonSupprimerClient.Enabled = !b;
            buttonAnnuler.Enabled = b;
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNomCLient = listBoxClient.SelectedItem.ToString();


            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            strSQLClient = "SELECT * FROM client where nom = '" + strNomCLient + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            drSQLClient.Read();

            textBoxIntervClient.Text = drSQLClient["id_intervention"].ToString();
            textBoxSiteClient.Text = drSQLClient["site"].ToString();
            textBoxLoginClient.Text = drSQLClient["nom"].ToString();
            textBoxPassClient.Text = drSQLClient["prenom"].ToString();
            textBoxMailClient.Text = drSQLClient["mail"].ToString();
            textBoxTelClient.Text = drSQLClient["telephone"].ToString();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            EffaceInformationsClient();

            EnableClient(true);

            textBoxIntervClient.Focus();
            mode = "Ajouter";
        }

        private void EffaceInformationsClient()
        {
            textBoxIntervClient.Text = "";
            textBoxSiteClient.Text = "";
            textBoxLoginClient.Text = "";
            textBoxPassClient.Text = "";
            textBoxTelClient.Text = "";
            textBoxMailClient.Text = "";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = textBoxIntervClient.Text;
            string stradr = textBoxSiteClient.Text;
            string strlgn = textBoxLoginClient.Text;
            string strpwd = textBoxPassClient.Text;
            string strtel = textBoxTelClient.Text;
            string strmail = textBoxMailClient.Text;

            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de client vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ajout
            if (mode == "Ajouter")
            {
                strSQL = string.Format("INSERT INTO client(id_intervention, site, nom, prenom, mail, telephone) " +
                    "VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", 
                    sternom, stradr, strlgn, strpwd, strmail, strtel);
            }
            else if (mode == "Modifier")
            {
                // id du site
                int idclient;
                string sql2 = "select * from client  where nom = '" + listBoxClient.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idclient = Convert.ToInt32(drSQLInterv["id_client"]);
                drSQLInterv.Close();

                // modification des informations
                strSQL = string.Format("UPDATE client SET id_intervention = {0}, site = {1}, nom = '{2}', " +
                    "prenom = '{3}', mail = '{4}', telephone = '{5}' where id_client = {6}",
                    sternom, stradr, strlgn, strpwd, strmail, strtel, idclient);
            }
            else
            {
                throw new Exception("Mode invalide");
            }

            Connection.executeQuery(strSQL);
            Connection.closeConnection();
            chargeClient();
            EffaceInformationsClient();
        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            if (listBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxClient.Focus();
                return;
            }

            string sternom = textBoxLoginClient.Text;
            string strSQLClient = "";

            strSQLClient = "delete from client where nom = '" + sternom + "'";
            Connection.openConnection(strSQLClient);

            chargeClient();

            EffaceInformationsClient();
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            if (listBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxClient.Focus();
                return;
            }

            EnableClient(true);

            textBoxIntervClient.Focus();
            mode = "Modifier";
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            EffaceInformationsClient();
            EnableClient(false);
            mode = "";
        }
    }
}
