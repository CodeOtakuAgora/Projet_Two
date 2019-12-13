using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormSite));
            if (isFormOpen == false)
            {
                FormSite formSite = new FormSite();
                formSite.StartPosition = FormStartPosition.CenterScreen;
                formSite.Show();
            }
        }

        private void FormRapport_Load(object sender, EventArgs e)
        {
            Connection connect = new Connection();
            connect.getConnectionString();
            SqlDataReader drSQLSite, drSQLInterv, drSQLMat = null;
            string strSQLSite, strSQLInterv, strSQLMat = "";

            try
            {
                strSQLSite = "SELECT * FROM site";
                drSQLSite = connect.openConnection(strSQLSite);

                strSQLInterv = "SELECT * FROM intervention";
                drSQLInterv = connect.openConnection(strSQLInterv);

                strSQLMat = "SELECT * FROM materiel";
                drSQLMat = connect.openConnection(strSQLMat);

                textBoxSite.Clear();
                textBoxDate.Clear();
                textBoxInt.Clear();
                textBoxProDate.Clear();
                listBoxMat.ClearSelected();

                while (drSQLSite.Read())
                {
                    textBoxSite.Text = drSQLSite["nom"].ToString();
                }

                while (drSQLInterv.Read())
                {
                    textBoxDate.Text = drSQLInterv["date_intervention"].ToString();
                    textBoxInt.Text = drSQLInterv["id_intervention"].ToString();
                }

                while (drSQLMat.Read())
                {
                    textBoxProDate.Text = drSQLMat["date_intervention_faite"].ToString();
                    listBoxMat.Items.Add(drSQLMat["nom"].ToString());
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
    }
}
