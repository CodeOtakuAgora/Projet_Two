using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void siteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormSite));
            if (isFormOpen == false)
            {
                FormSite formSite = new FormSite();
                formSite.StartPosition = FormStartPosition.CenterScreen;
                formSite.Show();
            }
        }

        private void interventionToolStripMenuItem1_Click(object sender, System.EventArgs e)
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

        private void clientToolStripMenuItem1_Click(object sender, System.EventArgs e)
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

        private void FormHome_Load(object sender, System.EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            Connection.getConnectionString();
            SqlDataReader drSQLInterv = null;
            string strSQLInterv = "";
            DateTime dateNow = DateTime.Now;
            string toto = dateNow.ToString("yyyy-MM-dd").Substring(0, 10);

            try
            {
                strSQLInterv = "SELECT * FROM intervention WHERE date_intervention > " + toto.ToString() + " ORDER BY date_intervention DESC";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                listBoxInterv.Items.Clear();

                while (drSQLInterv.Read())
                {
                    listBoxInterv.Items.Add(drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString());
                    listBoxInterv.BackColor = Color.Gray;
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

        private void gestionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCrud formgm = new FormCrud();
            formgm.Show();
        }
    }
}
