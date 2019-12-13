using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;


namespace fiefdouglou
{
    public partial class FormSite : Form
    {
        Connection connect = new Connection();

        public FormSite()
        {
            InitializeComponent();
        }

        private void ButtonIntervention_Click(object sender, EventArgs e)
        {
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormIntervention));
            if (isFormOpen == false)
            {
                FormIntervention formInterv = new FormIntervention();
                formInterv.StartPosition = FormStartPosition.CenterScreen;
                formInterv.Show();
            }
        }

        private void ButtonNewIntervention_Click(object sender, EventArgs e)
        {
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormSos));
            if (isFormOpen == false)
            {
                FormSos formSos = new FormSos();
                formSos.StartPosition = FormStartPosition.CenterScreen;
                formSos.Show();
            }
        }

        private void buttonRetourSite_Click(object sender, EventArgs e)
        {
            this.Close();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormHome));
            if (isFormOpen == false)
            {
                FormHome formHome = new FormHome();
                formHome.StartPosition = FormStartPosition.CenterScreen;
                formHome.Show();
            }
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            connect.getConnectionString();
            SqlDataReader drSQLSite, drSQLInterv = null;
            string strSQLSite, strSQLInterv = "";
            int i = 0;

            try
            {
                strSQLSite = "SELECT * FROM site";
                drSQLSite = connect.openConnection(strSQLSite);

                strSQLInterv = "SELECT * FROM intervention";
                drSQLInterv = connect.openConnection(strSQLInterv);

                comboBoxSiteNom.Items.Clear();

                while (drSQLSite.Read())
                {
                    comboBoxSiteNom.Items.Add(drSQLSite["nom"].ToString());
                    textBoxAdresseSite.Text = drSQLSite["adresse"].ToString() + " / " + drSQLSite["code_postal"].ToString() + " / " + drSQLSite["ville"].ToString();
                }


                while (drSQLInterv.Read())
                {
                    listViewStephane.Items.Add(drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString() + " / " + drSQLInterv["valide"].ToString());
                    listViewStephane.Columns[i].Width = 1000;
                    if ((bool)drSQLInterv["valide"] == true)
                    {
                        listViewStephane.Items[i].BackColor = Color.Green;
                    }
                    else
                    {
                        listViewStephane.Items[i].BackColor = Color.Red;
                    }
                    i++;
                }            
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message, "Érreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Érreur Générale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.closeConnection();
            }

        }

        private void buttonValiderSite_Click(object sender, EventArgs e)
        {
            connect.getConnectionString();
            string strSQLInterv;

            try
            {
                strSQLInterv = "UPDATE intervention SET valide = 1 WHERE id_intervention = 3";
                connect.executeQuery(strSQLInterv);
            }

            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message, "Érreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Érreur Générale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.closeConnection();
            }
        }
    }
}
