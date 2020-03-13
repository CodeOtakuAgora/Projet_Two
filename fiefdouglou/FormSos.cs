using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormSos : Form
    {
        public FormSos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, System.EventArgs e)
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

        private void confirm_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormRapport));
            if (isFormOpen == false)
            {
                FormRapport formRapport = new FormRapport();
                formRapport.StartPosition = FormStartPosition.CenterScreen;
                formRapport.Show();
            }
        }

        private void buttonValider_Click(object sender, System.EventArgs e)
        {
            Connection.getConnectionString();
            string strSQLInterv;

            try
            {
                DialogResult dr = MessageBox.Show("Voulez vous vraiment ajouter une intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    strSQLInterv = string.Format("INSERT INTO intervention(id_technicien, materiel_concerne, commentaire, date_intervention, valide) VALUES ({0}, '{1}', '{2}', '{3}', 0)", textBoxTech.Text, textBoxMat.Text, richTextBoxCom.Text, dateTimePickerInterv.Value);
                    Connection.executeQuery(strSQLInterv);
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

        private void FormSos_Load(object sender, EventArgs e)
        {
            Connection.getConnectionString();
            string strSQLSite = "";
            SqlDataReader drsqlSite = null;

            try
            {
                strSQLSite = "SELECT * FROM site";
                drsqlSite = Connection.openConnection(strSQLSite);

                comboBox1.Items.Clear();

                while (drsqlSite.Read())
                {
                    comboBox1.Items.Add(drsqlSite["nom"].ToString());
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
