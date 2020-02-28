using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormIntervention : Form
    {
        public FormIntervention()
        {
            InitializeComponent();
        }

        private void FormIntervention_Load(object sender, EventArgs e)
        {
            Connection.getConnectionString();
            SqlDataReader drSQLInterv, drSQLTech, drSQLMat = null;
            string strSQLInterv, strSQLTech, strSQLMat = "";

            try
            {
                strSQLInterv = "SELECT * FROM intervention";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                strSQLTech = "SELECT * FROM technicien";
                drSQLTech = Connection.openConnection(strSQLTech);

                strSQLMat = "SELECT * FROM materiel";
                drSQLMat = Connection.openConnection(strSQLMat);

                comboBoxInterv.Items.Clear();
                comboBoxTech.Items.Clear();
                comboBoxMat.Items.Clear();

                while (drSQLInterv.Read())
                {
                    comboBoxInterv.Items.Add(drSQLInterv["materiel_concerne"].ToString() + " | " +
                        drSQLInterv["commentaire"].ToString() + " | " +
                        drSQLInterv["date_intervention"].ToString());
                    comboBoxDate.Items.Add(drSQLInterv["date_intervention"].ToString());
                    comboBoxId.Items.Add(drSQLInterv["id_intervention"].ToString());
                    listBoxComment.Items.Add(drSQLInterv["commentaire"].ToString());
                }

                while (drSQLTech.Read())
                {
                    comboBoxTech.Items.Add(drSQLTech["nom"].ToString());
                }

                while (drSQLMat.Read())
                {
                    comboBoxMat.Items.Add(drSQLMat["nom"].ToString() + " | " +
                        drSQLMat["type"].ToString());
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

        private void buttonCancel_Click(object sender, EventArgs e)
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
