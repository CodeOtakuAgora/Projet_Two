// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormSos qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormSos : Form
    {
        public FormSos()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
        }

        private void back_Click(object sender, System.EventArgs e)
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

        private void confirm_Click(object sender, System.EventArgs e)
        {
            // si on click sur le bouton good on est alors rediriger vers la form des rapports
            // puis on charge la FormRapport en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
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
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            string strSQLInterv;

            try
            {
                // on essaye d'éxecuter un bout de code
                // si l'utilisateur confirme à trvaers la boite de dialogue qu'il souhaite bien
                // ajouter une intervention
                DialogResult dr = MessageBox.Show("Voulez vous vraiment ajouter une intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    // on éxécute l'insert de donnée de l'intervention dans la database
                    strSQLInterv = string.Format("INSERT INTO intervention(id_technicien, materiel_concerne, commentaire, date_intervention, valide) VALUES ({0}, '{1}', '{2}', '{3}', 0)", textBoxTech.Text, textBoxMat.Text, richTextBoxCom.Text, dateTimePickerInterv.Value);
                    Connection.executeQuery(strSQLInterv);
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

        private void FormSos_Load(object sender, EventArgs e)
        {
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            string strSQLSite = "";
            SqlDataReader drsqlSite = null;

            try
            {
                // on essaye d'éxecuter un bout de code
                // on récupère tout les site de la database
                strSQLSite = "SELECT * FROM site";
                drsqlSite = Connection.openConnection(strSQLSite);

                // on vide notre comboBox avant de la remplir juste au cas où
                comboBox1.Items.Clear();

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la comboBox
                while (drsqlSite.Read())
                {
                    comboBox1.Items.Add(drsqlSite["nom"].ToString());
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
