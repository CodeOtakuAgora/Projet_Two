using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace fiefdouglou
{
    public partial class FormSite : Form
    {
        public FormSite()
        {
            InitializeComponent();
        }

        private void ButtonIntervention_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormIntervention));
            if (isFormOpen == false)
            {
                FormIntervention formInterv = new FormIntervention();
                formInterv.StartPosition = FormStartPosition.CenterScreen;
                formInterv.Show();
            }
        }

        private void ButtonNewIntervention_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormSos));
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
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormHome));
            if (isFormOpen == false)
            {
                FormHome formHome = new FormHome();
                formHome.StartPosition = FormStartPosition.CenterScreen;
                formHome.Show();
            }
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            Connection.getConnectionString();
            SqlDataReader drSQLSite, drSQLInterv = null;
            string strSQLSite, strSQLInterv = "";
            int i = 0;

            try
            {
                strSQLSite = "SELECT * FROM site";
                drSQLSite = Connection.openConnection(strSQLSite);

                strSQLInterv = "SELECT * FROM intervention where id_intervention < 8";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                comboBoxSiteNom.Items.Clear();
                listViewInterv.Items.Clear();

                while (drSQLSite.Read())
                {
                    comboBoxSiteNom.Items.Add(drSQLSite["nom"].ToString());
                    textBoxAdresseSite.Text = drSQLSite["adresse"].ToString() + " / " + drSQLSite["code_postal"].ToString() + " / " + drSQLSite["ville"].ToString();
                }


                while (drSQLInterv.Read())
                {
                    listViewInterv.Items.Add(drSQLInterv["id_intervention"].ToString() + " / " + drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString() + " / " + drSQLInterv["valide"].ToString());
                    listViewInterv.Columns[i].Width = 1000;
                    if ((bool)drSQLInterv["valide"] == true)
                    {
                        listViewInterv.Items[i].BackColor = Color.Green;
                    }
                    else
                    {
                        listViewInterv.Items[i].BackColor = Color.Red;
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
                Connection.closeConnection();
            }

        }

        private void buttonValiderSite_Click(object sender, EventArgs e)
        {
            Connection.getConnectionString();
            string strSQLInterv, text;
            bool validate = false;

            try
            {                 
                text = listViewInterv.SelectedItems[0].Text;
                if (text.Contains("False"))
                {
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment valider cette intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        strSQLInterv = string.Format("UPDATE intervention SET valide = 1 WHERE id_intervention = {0}", text[0]);
                        Connection.executeQuery(strSQLInterv);
                        validate = true;
                    }
                }    
                else if (text.Contains("True"))
                {
                    MessageBox.Show("Cette intervention à déjà été validée", "Log d'Infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Veuillez selectionner une intervention", "Érreur d'Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Connection.closeConnection();
                if (validate == true)
                {
                    this.Close();
                    Connection connection = new Connection();
                    bool isFormOpen = connection.isAlreadyOpen(typeof(FormSite));
                    if (isFormOpen == false)
                    {
                        FormSite formSite = new FormSite();
                        formSite.StartPosition = FormStartPosition.CenterScreen;
                        formSite.Show();
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Connection.getConnectionString();
            string strSQLInterv, strSQLCountInterv;
            SqlDataReader drSQLInterv;
            int i = 0;
            int interv;
            try
            {
                strSQLInterv = string.Format("SELECT * FROM intervention WHERE materiel_concerne LIKE '%{0}%'", textBoxSearch.Text);
                drSQLInterv = Connection.openConnection(strSQLInterv);

                strSQLCountInterv = string.Format("SELECT COUNT(*) FROM intervention WHERE materiel_concerne LIKE '%{0}%'", textBoxSearch.Text);
                interv = Connection.executeCountQuery(strSQLCountInterv);

                
                listViewInterv.Items.Clear();


                while (drSQLInterv.Read())
                {
                    listViewInterv.Items.Add(drSQLInterv["id_intervention"].ToString() + " / " + drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString() + " / " + drSQLInterv["valide"].ToString());
                    listViewInterv.Columns[i].Width = 1000;

                    if ((bool)drSQLInterv["valide"] == true)
                    {
                        listViewInterv.Items[i].BackColor = Color.Green;
                    }
                    else
                    {
                        listViewInterv.Items[i].BackColor = Color.Red;
                    }
                    i++;
                }

                if (interv == 0)
                {
                    MessageBox.Show("Aucun Résultat", "Érreur de Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Connection.closeConnection();
            }
        }

    }
}