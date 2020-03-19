// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormHome qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormHome : Form
    {
        public FormHome()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
        }

        private void siteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // on charge la FormSite en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
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
            // on charge la FormIntervention en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
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
             // on charge la FormSos en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
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
            // on charge la FormLogin
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            SqlDataReader drSQLInterv = null;
            string strSQLInterv = "";
            // on récupère la date actuelle et on la convertie dans le format adéquat avec 
            // l'anné puis un tirret puis le mois puis un tirret et le jour
            DateTime dateNow = DateTime.Now;
            string toto = dateNow.ToString("yyyy-MM-dd").Substring(0, 10);

            try
            {
                // on essaye d'éxecuter un bout de code
                // on récupère toutes les prochaines interventions dont la date est supérieur à la date actuelle
                strSQLInterv = "SELECT * FROM intervention WHERE date_intervention > " + toto.ToString() + " ORDER BY date_intervention DESC";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                // on vide notre listBox avant de la remplir juste au cas où
                listBoxInterv.Items.Clear();

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listbox
                while (drSQLInterv.Read())
                {
                    listBoxInterv.Items.Add(drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString());
                    listBoxInterv.BackColor = Color.Gray;
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

        private void gestionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // on charge la FormCrud en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrud));
            if (isFormOpen == false)
            {
                FormCrud formgm = new FormCrud();
                formgm.StartPosition = FormStartPosition.CenterScreen;
                formgm.Show();
            }
        }
    }
}
