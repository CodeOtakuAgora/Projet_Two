// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormListInterv qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormUpdateInterv : Form
    {
        public FormUpdateInterv()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.GetConnectionString();
        }

        private void FormUpdateInterv_Load(object sender, System.EventArgs e)
        {
            // on commence par vider notre listView juste au cas où
            listViewInterv.Items.Clear();

            int i = 0;
            string site = "";
            DateTime dt = DateTime.Now;
            try
            {
                /* 
                * notre but là c'est de récupérer tout le matériel qui est propre au site et un client
                * qui a été précédemment définit dans nos comboBox en faisant une jointure interne entre la table
                * matériel, site et client 
                * m => table matériel
                * s => table site

                * en gros l'idée ce de récupérer pas mal d'infos de la table matériel ensuit de récupérer le contenu de la table
                * site et pour chaque matériel trouvé regarder si il appartient au site définit

                */
                string strSQL = "SELECT i.id_intervention as id_matos, i.materiel_concerne as nom_matos, i.commentaire " +
                    " as com_matos, i.date_intervention as date_com, i.valide as val_com" +
                    " FROM intervention i ORDER BY valide";
                SqlDataReader drSQL = Connection.OpenConnection(strSQL);

                // une fois notre éxécuté on va boucler dessus afin de remplir notre listViwe 
                // de tout ce que nous a retourné notre requete
                while (drSQL.Read())
                {
                    if (drSQL["val_com"].ToString() == "False")
                        site = "Intervention non réalisées";
                    if (drSQL["val_com"].ToString() == "True")
                        site = "Intervention terminée";
                    if (drSQL["date_com"].ToString() == dt.ToString())
                        site = "Intervention en cours";

                    // on définit notre listView et on la remplit en lui ajoutant tout ce dont on a besoin d'afficher
                    listViewInterv.Items.Add(drSQL["id_matos"].ToString() + " | " + drSQL["nom_matos"].ToString()
                        + " | " + drSQL["com_matos"].ToString() + " | " + drSQL["date_com"].ToString() + " | " +
                        drSQL["val_com"].ToString() + " | " + site);

                    // on définit une variable i qu'on va incrémenter afin de cibler à chaque chaque élments de notre listView afin de 
                    // lui mettre pour chauqe éléments une couleur de fond ;)
                    listViewInterv.Columns[i].Width = 1000;

                    if (drSQL["val_com"].ToString() == "False")
                        listViewInterv.Items[i].BackColor = Color.Red;
                    if (drSQL["val_com"].ToString() == "True")
                        listViewInterv.Items[i].BackColor = Color.Green;
                    if (drSQL["date_com"].ToString() == dt.ToString())
                        listViewInterv.Items[i].BackColor = Color.Yellow;

                    i++;
                }
            }
            // si une requete sql qui n'a pas fonctionné dans le bout de code qu'on essaye d'éxécuté 
            // alors on attrape l'exception et on affiche l'erreur
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // si il y a une quelqonque erreur dans le bout de code qu'on essaye d'éxécuté alors attrape l'exception
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Érreur Générale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // une fois que le bout de code a fini son éxécution on ferme toute nos connections à la database
            finally
            {
                Connection.CloseConnection();
            }
        }

        private void ButtonOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Connection.GetConnectionString();
            string strSQLInterv;
            bool validate = false;

            try
            {
                string text = listViewInterv.SelectedItems[0].Text;
                if (text == null)
                {
                    MessageBox.Show("Veuillez selectionner une interventions", "Log d'Érreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (text.Contains("False"))
                {
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment valider cette intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        strSQLInterv = string.Format("UPDATE intervention SET valide = 1 WHERE id_intervention = {0}", text[0]);
                        Connection.ExecuteQuery(strSQLInterv);
                        validate = true;
                    }
                }
                else if (text.Contains("True"))
                {
                    MessageBox.Show("Cette intervention à déjà été validée", "Log d'Infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // une fois que le bout de code a fini son éxécution on ferme toute nos connections à la database
            finally
            {
                Connection.CloseConnection();
                if (validate)
                {
                    this.Close();
                    // on charge la FormUpdateInterv en vérifiant si elle est pas déjà ouverte 
                    // afin d'éviter d'ouvrir un doublon
                    Connection connection = new Connection();
                    bool isFormOpen = connection.IsAlreadyOpen(typeof(FormUpdateInterv));
                    if (!isFormOpen)
                    {
                        var formInterv = new FormUpdateInterv()
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        };
                        formInterv.Show();
                    }
                }
            }
        }
    }
}
