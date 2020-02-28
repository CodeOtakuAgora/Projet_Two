using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormCrud : Form
    {

        public FormCrud()
        {
            InitializeComponent();
            Connection.getConnectionString();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            DialogResult dlgres;
            dlgres = MessageBox.Show(
                "Voulez-vous vraiment quitter ?",
              "Confirmer", MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (dlgres == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormCrudClient leclient = new FormCrudClient();
            leclient.ShowDialog();
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            FormCrudSite lesite = new FormCrudSite();
            lesite.ShowDialog();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            listViewMateriel.Items.Clear();
            string strfilter = " where (1 = 1)";
            string clientchoisi = comboBoxClient.SelectedItem.ToString();
            string sitechoisi = comboBoxSite.SelectedItem.ToString();

            strfilter += " and (c.login = '" + clientchoisi + "' )";
            strfilter += " and (s.nom = '" + sitechoisi + "' )";

            SqlDataReader drSQLInterv = null;
            string strSQLInterv = "";
            int i = 0;

            try
            {
                strSQLInterv = "SELECT m.nom as matnom, m.description as matserie, " +
                    "m.date_intervention_faite as matdate, m.mtbf as matmtbf, " +
                    "c.login clientnom, s.nom as sitenom FROM materiel " +
                    "m inner join client c on m.id_client = c.id_client " +
                    "inner join site s on m.id_site = s.id_site " + strfilter;
                
                drSQLInterv = Connection.openConnection(strSQLInterv);

                while (drSQLInterv.Read())
                {
                    string nom = drSQLInterv["matnom"].ToString();
                    string NoSerie = drSQLInterv["matserie"].ToString();
                    string DateInstallation = drSQLInterv["matdate"].ToString();
                    string mtbf = drSQLInterv["matmtbf"].ToString();
                    string site = drSQLInterv["clientnom"].ToString();
                    string client = drSQLInterv["sitenom"].ToString();

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = nom;
                    lvi.SubItems.Add(NoSerie);
                    lvi.SubItems.Add(DateInstallation);
                    lvi.SubItems.Add(mtbf);
                    lvi.SubItems.Add(site);
                    lvi.SubItems.Add(client);

                    listViewMateriel.Items.Add(lvi);
                    listViewMateriel.Items[i].BackColor = Color.Gray;
                    i++;
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
        }

        private void FormCrudGM_Load(object sender, EventArgs e)
        {
            // Chargement combo client
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            strSQLClient = "SELECT * FROM client";
            drSQLClient = Connection.openConnection(strSQLClient);

            comboBoxClient.Items.Add("");
            while (drSQLClient.Read())
            {
                comboBoxClient.Items.Add(drSQLClient["login"].ToString());
            };
            Connection.closeConnection();

            // Chargement combo site
            SqlDataReader drSQLSite= null;
            string strSQLSite = "";

            strSQLSite = "SELECT * FROM site";
            drSQLSite = Connection.openConnection(strSQLSite);

            comboBoxSite.Items.Add("");
            while (drSQLSite.Read())
            {
                comboBoxSite.Items.Add(drSQLSite["nom"].ToString());
            };
            Connection.closeConnection();
        }

        private void buttonMatos_Click(object sender, EventArgs e)
        {
            FormCrudMatos lematos = new FormCrudMatos();
            lematos.ShowDialog();
        }
    }
}
