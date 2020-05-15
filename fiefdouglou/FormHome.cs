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

        private void SiteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // on charge la FormCrudInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            ButtonAddInterv_Click(sender, e);
        }

        private void EpiredMmaterial()
        {
            // on récupère les identifiants de connection à la database
            Connection.GetConnectionString();

            // on définit un compteur afin que lorsque que l'on va surligner une intervention (rouge, vert)
            // pour fficher de manière graphique si elle est validé ou pas, on a alors beosin d'un compteur qui commence à 0
            // pour que le surlignage ne ce fasse que un élemnt précis de notre listView
            int i = 0;
            // on récupère notre procédure stockée qui permet de récupérer tout les matériel périmés dont la date de 
            // leur prochaines intervention - mtbf (exprimé en nombre de jour) est inférieur à la date actuelle
            SqlDataReader md = Connection.ExecuteProcedure("MatosPerimer");

            // on boucle sur les valeurs dans la database et on les remplit une par une dans la listview
            // en précisant uniquement les colonnes de la database que l'on souhaite afficher dans la listview
            // on remplit la listview et ensuite on définit une largueur pour chaque colonne de notre listview ainsi qu'une
            // couleur de fond pour chaque élément de notre listView
            while (md.Read())
            {
                listBoxMat.Items.Add(" Le matériel " + md["nom"].ToString() + " / n° " + md["id_mat"].ToString() + " / date : "
                    + md["date_intervention_faite"].ToString().Substring(0, 10));
                listBoxMat.BackColor = Color.Red;
                // on incrémente notre compteur
                i++;
            }
        }

        private void FormHome_Load(object sender, System.EventArgs e)
        {
            // on charge la FormLogin en premier lieu pour sécuriser le logiciel et 
            // afin d'empecher que n'importe qui puisse utiliser le logiciel
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            // on récupère les identifiants de connection à la database
            Connection.GetConnectionString();

            try
            {
                // on récupère la date actuelle et on la convertie dans le format adéquat avec 
                // l'anné, le mois et le jour car sinon notre requete sql ne sera pas éxécuté
                DateTime dateNow = DateTime.Now;
                string toto = dateNow.ToString("yyyyMMdd");

                // on va vérifier si il éxiste dans notre database un matériel défectueux c'est à dire un matériel
                // dont sa date de péremption - son mtbf (exprimer en jour) est égale à la date actuelle
                // celà nous permettra d'enclencher une intervention sans qu'il y ait eu une demande externe
                // afin de garder pour nos clients un parc informatique de leur site fonctionnel et à jour

                // pour que cette vérification se fasse tout les jours le logiciel devra être lancé tout les jours pour vérifier
                // qu'aucun ne tombe en panne subitemment, on pourra alors optimiser tout celà avec un fichier .bat
                // qui se lance tout les jour à une heure précise afin d'éxécuter le logiciel automatiquement
                string test = string.Format("SELECT COUNT(*) FROM Materiel WHERE DATEADD(DAY, -mtbf, date_intervention_faite) " +
                    " <= '{0}'", toto.ToString());
                int res = Connection.ExecuteCountQuery(test);
                // si le résultat retourné par le requete est 0 donc il n'a rien trouvé 
                // alors aucun matétriel défectueux n'a été trouvé
                if (res == 0)
                {
                    MessageBox.Show("Aucun matériel périmés n'a été détecté", "INFOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // si le résultat retourné par le requete est 1 donc il a trouvé un résultat 
                // alors celà veut dire qu'un matériel défectueux à été trouvé et donc une intervention se doit d'etre réalisé
                // de toute urgence sur ce matériel
                else if (res == 1)
                {
                    MessageBox.Show("Un matériel périmé à été détecté \n une intervention doit alors être effectué de toute urgence", "IMPORTANT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // on récupère tout les matériels qui sont périmés
                EpiredMmaterial();

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
                Connection.CloseConnection();
            }
        }

        private void GestionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // on charge la FormCrud en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrud));
            if (!isFormOpen)
            {
                var formgm = new FormCrud()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formgm.Show();
            }
        }

        private void ButtonAddInterv_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudInterv));
            if (!isFormOpen)
            {
                var formInterv = new FormCrudInterv()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formInterv.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // on charge la FormListInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormListInterv));
            if (!isFormOpen)
            {
                var formInterv = new FormListInterv()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formInterv.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // on charge la FormListMat en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormListMat));
            if (!isFormOpen)
            {
                var formMat = new FormListMat()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formMat.Show();
            }
        }

        private void ClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // on charge la FormListInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Button2_Click(sender, e);
        }

        private void MatérielToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // on charge la FormListMat en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Button4_Click(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // on charge la FormUpdateInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormUpdateInterv));
            if (!isFormOpen)
            {
                var formMat = new FormUpdateInterv()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                formMat.Show();
            }
        }

        private void ConsulterLesOpérationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on charge la FormUpdateInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Button3_Click(sender, e);
        }
    }
}
