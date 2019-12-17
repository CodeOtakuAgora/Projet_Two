using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Connection connect = new Connection();
            connect.getConnectionString();

            try
            {
                string countUser = string.Format("SELECT COUNT(*) FROM client WHERE login = '{0}'", textBoxLogin.Text.Trim());
                int res = connect.executeCountQuery(countUser);

                if (res == 0)
                {
                    MessageBox.Show("couple login / password invalide", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (res == 1)
                {
                    string strSQLPassword = "SELECT * FROM client WHERE login = '" + textBoxLogin.Text.Trim() + "'";
                    string inputPassword = "";
                    SqlDataReader drSQLPassword = connect.openConnection(strSQLPassword);
                    while (drSQLPassword.Read())
                    {
                        inputPassword = drSQLPassword["password"].ToString();
                    }
                    bool matches = BCrypt.CheckPassword(textBoxPassword.Text.Trim(), inputPassword);

                    if (matches == true)
                    {
                        MessageBox.Show("connection Solved", "Log de Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Connection myConnect = new Connection();
                        bool isFormOpen = myConnect.isAlreadyOpen(typeof(FormHome));
                        if (isFormOpen == false)
                        {
                            FormHome formHome = new FormHome();
                            formHome.StartPosition = FormStartPosition.CenterScreen;
                            formHome.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("couple login / password invalide", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez vous vraiment vos déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
