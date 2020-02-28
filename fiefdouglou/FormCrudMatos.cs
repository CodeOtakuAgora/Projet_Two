using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormCrudMatos : Form
    {
        private string mode;

        public FormCrudMatos()
        {
            InitializeComponent();
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCrudMatos_Load(object sender, EventArgs e)
        {
            chargeClient();
        }

        private void chargeClient()
        {
            listBoxMatos.Items.Clear();
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                strSQLClient = "SELECT * FROM materiel";
                drSQLClient = Connection.openConnection(strSQLClient);

                while (drSQLClient.Read())
                {
                    listBoxMatos.Items.Add(drSQLClient["nom"].ToString());
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
            textBoxClientMatos.Enabled = b;
            textBoxSiteMatos.Enabled = b;
            textBoxNomMatos.Enabled = b;
            textBoxDescMatos.Enabled = b;
            textBoxTypeMatos.Enabled = b;
            textBoxIntervMatos.Enabled = b;
            textBoxDelaisMatos.Enabled = b;
            textBoxMtbfMatos.Enabled = b;
            listBoxMatos.Enabled = !b;
            buttonAjouterClient.Enabled = !b;
            buttonValider.Enabled = b;
            buttonModifierClient.Enabled = !b;
            buttonSupprimerClient.Enabled = !b;
            buttonAnnuler.Enabled = b;
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNomCLient = listBoxMatos.SelectedItem.ToString();


            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            strSQLClient = "SELECT * FROM materiel where nom = '" + strNomCLient + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            drSQLClient.Read();

            textBoxClientMatos.Text = drSQLClient["id_client"].ToString();
            textBoxSiteMatos.Text = drSQLClient["id_site"].ToString();
            textBoxNomMatos.Text = drSQLClient["nom"].ToString();
            textBoxDescMatos.Text = drSQLClient["description"].ToString();
            textBoxTypeMatos.Text = drSQLClient["type"].ToString();
            textBoxIntervMatos.Text = drSQLClient["date_intervention_faite"].ToString();
            textBoxDelaisMatos.Text = drSQLClient["date_intervention_pas_faite"].ToString();
            textBoxMtbfMatos.Text = drSQLClient["mtbf"].ToString();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            EffaceInformationsClient();

            EnableClient(true);

            textBoxClientMatos.Focus();
            mode = "Ajouter";
        }

        private void EffaceInformationsClient()
        {
            textBoxClientMatos.Text = "";
            textBoxSiteMatos.Text = "";
            textBoxNomMatos.Text = "";
            textBoxDescMatos.Text = "";
            textBoxIntervMatos.Text = "";
            textBoxTypeMatos.Text = "";
            textBoxDelaisMatos.Text = "";
            textBoxMtbfMatos.Text = "";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = textBoxClientMatos.Text;
            string stradr = textBoxSiteMatos.Text;
            string strlgn = textBoxNomMatos.Text;
            string strpwd = textBoxDescMatos.Text;
            string strtel = textBoxIntervMatos.Text;
            string strmail = textBoxTypeMatos.Text;
            string strdls = textBoxDelaisMatos.Text;
            string strmtbf = textBoxMtbfMatos.Text;

            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de client vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ajout
            if (mode == "Ajouter")
            {
                strSQL = string.Format("INSERT INTO materiel (id_client, id_site, nom, description, type, " +
                    "date_intervention_faite, date_intervention_pas_faite, mtbf) " +
                    "VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})",
                    sternom, stradr, strlgn, strpwd, strmail, strtel, strdls, strmtbf);
            }
            else if (mode == "Modifier")
            {
                // id du site
                int idmat;
                string sql2 = "select * from materiel  where nom = '" + listBoxMatos.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idmat = Convert.ToInt32(drSQLInterv["id_mat"]);
                drSQLInterv.Close();

                // modification des informations
                strSQL = string.Format("UPDATE materiel SET id_client = {0}, id_site = {1}, nom = '{2}', " +
                    "description = '{3}', type = '{4}', date_intervention_faite = '{5}', " +
                    "date_intervention_pas_faite = '{6}', mtbf = {7} where id_mat = {8}",
                    sternom, stradr, strlgn, strpwd, strmail, strtel, strdls, strmtbf, idmat);
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
            if (listBoxMatos.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxMatos.Focus();
                return;
            }

            string sternom = textBoxNomMatos.Text;
            string strSQLClient = "";

            strSQLClient = "delete from materiel where nom = '" + sternom + "'";
            Connection.openConnection(strSQLClient);

            chargeClient();

            EffaceInformationsClient();
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            if (listBoxMatos.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxMatos.Focus();
                return;
            }

            EnableClient(true);

            textBoxClientMatos.Focus();
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
