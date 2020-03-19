// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormRapport qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormRapport : Form
    {
        public FormRapport()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // si on quite cette form avec le bouton annuler alors la form actuelle se ferme
            // puis on charge la FormSite en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
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

        private void FormRapport_Load(object sender, EventArgs e)
        {
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            SqlDataReader drSQLSite, drSQLInterv, drSQLMat = null;
            string strSQLSite, strSQLInterv, strSQLMat = "";

            try
            {
                // on essaye d'éxecuter un bout de code
                // on récupère tout les interventions, site et matériels de la database
                strSQLSite = "SELECT * FROM site";
                drSQLSite = Connection.openConnection(strSQLSite);

                strSQLInterv = "SELECT * FROM intervention";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                strSQLMat = "SELECT * FROM materiel";
                drSQLMat = Connection.openConnection(strSQLMat);

                // on vide tout nos éléments visuels (textbox et listbox) avant de les remplir juste au cas où
                textBoxSite.Clear();
                textBoxDate.Clear();
                textBoxInt.Clear();
                textBoxProDate.Clear();
                listBoxMat.ClearSelected();

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listbox
                while (drSQLSite.Read())
                {
                    textBoxSite.Text = drSQLSite["nom"].ToString();
                }

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listbox
                while (drSQLInterv.Read())
                {
                    textBoxDate.Text = drSQLInterv["date_intervention"].ToString();
                    textBoxInt.Text = drSQLInterv["id_intervention"].ToString();
                }

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listbox
                while (drSQLMat.Read())
                {
                    textBoxProDate.Text = drSQLMat["date_intervention_faite"].ToString();
                    listBoxMat.Items.Add(drSQLMat["nom"].ToString());
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
    }
}
