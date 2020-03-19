// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormLogin qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();

            /*
            * petit code qui permet de générer un mot de passe hashé à rentré dans la databse à partir
            * d'une chaine de charactère rnetré et d'une clé de hashage définit 
            * en gros disos que GenerateSalt permet de nous générer la clé de hashage et ensuite on associe
            * cette valeur retourné ainsi que la valeur definit dans la méthode hashPassword qui s'occupe alors de hashé 
            * le password en vérifiant si le hash est bien securisé et nous renvoie une exception si ce n'est pas le cas
            
            string salt = BCrypt.GenerateSalt();
            MessageBox.Show(salt);
            string pass = "toto";
            string res = BCrypt.HashPassword(pass, salt);
            MessageBox.Show(res);
            */
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            // on verifie si les textbox sont vides
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();

            try
            {
                // on essaye d'éxecuter un bout de code
                // on vérifie sur le login qui a été rentré existe dans la database
                // cela nous reourne 0 si aucun utilisateur a été trouvé sinon 1 si nous avons en trouvons un
                string countUser = string.Format("SELECT COUNT(*) FROM login WHERE login = '{0}'", textBoxLogin.Text.Trim());
                int res = Connection.executeCountQuery(countUser);

                if (res == 0)
                {
                    MessageBox.Show("couple login / password invalide", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (res == 1)
                {
                    // on récupère l'utilisateur qui correspond avec le login qui a été rentré
                    string strSQLPassword = "SELECT * FROM login WHERE login = '" + textBoxLogin.Text.Trim() + "'";
                    string inputPassword = "";
                    // on récupère le password hashé de la database de l'utilsiateur selectionné 
                    SqlDataReader drSQLPassword = Connection.openConnection(strSQLPassword);
                    while (drSQLPassword.Read())
                    {
                        inputPassword = drSQLPassword["password"].ToString();
                    }
                    // on check si le password qui a été saisie correspond au hash de la database
                    bool matches = BCrypt.CheckPassword(textBoxPassword.Text.Trim(), inputPassword);
                    if (matches == true)
                    {
                        // on affiche un message de succès et on cache la formLogin
                        // puis on charge la formHome en vérifiant si elle est pas déjà ouverte 
                        // afin d'éviter d'ouvrir un doublon
                        MessageBox.Show("connection Solved", "Log de Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Connection connection = new Connection();
                        bool isFormOpen = connection.isAlreadyOpen(typeof(FormHome));
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

             // si une requete sql qui n'a pas fonctionné dans le bout de code qu'on essaye d'éxécuté 
            // alors on attrape l'exception et on affiche l'erreur
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message, "Érreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // si il y a une quelqonque erreur dans le bout de code qu'on essaye d'éxécuté alors attrape l'exception
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Érreur Générale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // une fois que les bout de code a fini son éxécution on ferme toute nos connections à la database
            finally
            {
                Connection.closeConnection();
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            // si l'utilisateur souhaite quitter le programme on lui proose de se deconecter et on ferme le programme
            DialogResult dr = MessageBox.Show("Voulez vous vraiment vos déconnecter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // si on ferme la fenetre de connection, alors on arrete le programme
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
