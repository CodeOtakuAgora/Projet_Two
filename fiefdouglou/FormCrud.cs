// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormCrud qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormCrud : Form
    {

        public FormCrud()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            // on propose à l'utiisateur de quitter la FormCrud si il le souhaite
            DialogResult dlgres;
            dlgres = MessageBox.Show("Voulez-vous vraiment quitter ?","Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgres == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
             // on charge la FormCrudClient en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrudClient));
            if (isFormOpen == false)
            {
                FormCrudClient leclient = new FormCrudClient();
                leclient.StartPosition = FormStartPosition.CenterScreen;
                leclient.ShowDialog();
            }
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
             // on charge la FormCrudSite en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrudSite));
            if (isFormOpen == false)
            {
                FormCrudSite lesite = new FormCrudSite();
                lesite.StartPosition = FormStartPosition.CenterScreen;
                lesite.ShowDialog();
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            // on commence par vider notre listView juste au cas où
            listViewMateriel.Items.Clear();
            // on récupère ce qui à été définit dans nos comboBox
            string clientchoisi = comboBoxClient.SelectedItem.ToString();
            string sitechoisi = comboBoxSite.SelectedItem.ToString();

            //
            string strfilter = " where (1 = 1)";
            strfilter += " and (c.nom = '" + clientchoisi + "' )";
            strfilter += " and (s.nom = '" + sitechoisi + "' )";

            SqlDataReader drSQLInterv = null;
            string strSQLInterv = "";
            int i = 0;

            try
            {
                /* 
                * notre but là c'est de récupérer tout le matériel qui est propre au site et un client
                * qui a été précédemment définit dans nos comboBox en faisant une jointure interne entre la table
                * matériel, site et client 
                * m => table matériel
                * c => table client
                * s => table site

                * en gros l'idée ce de récupérer pas mal d'infos de la table matériel ensuit de récupérer le contenu de la table
                * site et client et pour chaque matériel trouvé regarder si il appartient un client et au site ddéfinit

                */
                strSQLInterv = "SELECT m.nom as nom_matos, m.description as desc_matos, " +
                    "m.date_intervention_faite as date_matos, m.mtbf as mtbf_matos, " +
                    "c.nom nom_du_client, s.nom as nom_du_site FROM materiel " +
                    "m inner join client c on m.id_client = c.id_client " +
                    "inner join site s on m.id_site = s.id_site " + strfilter;
                
                drSQLInterv = Connection.openConnection(strSQLInterv);

                // une fois notre éxécuté on va boucler dessus afin de remplir notre listViwe 
                // de tout ce que nous a retourné notre requete
                while (drSQLInterv.Read())
                {
                    string nom = drSQLInterv["matnom"].ToString();
                    string NoSerie = drSQLInterv["matserie"].ToString();
                    string DateInstallation = drSQLInterv["matdate"].ToString();
                    string mtbf = drSQLInterv["matmtbf"].ToString();
                    string site = drSQLInterv["clientnom"].ToString();
                    string client = drSQLInterv["sitenom"].ToString();

                    // on définit notre listView et on la remplit en lui ajoutant tout ce dont on a besoin d'afficher
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = nom;
                    lvi.SubItems.Add(NoSerie);
                    lvi.SubItems.Add(DateInstallation);
                    lvi.SubItems.Add(mtbf);
                    lvi.SubItems.Add(site);
                    lvi.SubItems.Add(client);

                    listViewMateriel.Items.Add(lvi);
                    // on définit une variable i qu'on va incrémenter afin de cibler à chaque chaque élments de notre listView afin de 
                    // lui mettre pour chauqe éléments une couleur de fond ;)
                    listViewMateriel.Items[i].BackColor = Color.Gray;
                    i++;
                };
            }
             // si une requete sql qui n'a pas fonctionné dans le bout de code qu'on essaye d'éxécuté 
            // alors on attrape l'exception et on affiche l'erreur
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // une fois que le bout de code a fini son éxécution on ferme toute nos connections à la database
            finally
            {
                Connection.closeConnection();
            }
        }

        private void FormCrudGM_Load(object sender, EventArgs e)
        {
            // au chargement de la form on remplit nos comboBox de tout nos clients
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            // on récupère alors tout nos cleints de la database
            strSQLClient = "SELECT * FROM client";
            drSQLClient = Connection.openConnection(strSQLClient);

            // on commence par vider notre comboBox
            comboBoxClient.Items.Add("");
            // puis on boucle sur nos site pour replir notre comboBox du nom du site
            while (drSQLClient.Read())
            {
                comboBoxClient.Items.Add(drSQLClient["nom"].ToString());
            };
            // on ferme ensuite ensuite toutes nos connection à la database
            Connection.closeConnection();

            // on fait ensuite la même chose mais pour site en remplissant de la même manière 
            // notre comboBox de tout les nom de nos sites de la database
            SqlDataReader drSQLSite= null;
            string strSQLSite = "";

            strSQLSite = "SELECT * FROM site";
            drSQLSite = Connection.openConnection(strSQLSite);

            comboBoxSite.Items.Add("");
            while (drSQLSite.Read())
            {
                comboBoxSite.Items.Add(drSQLSite["nom"].ToString());
            };
            Connection.closeConnection();
        }

        private void buttonMatos_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudMatos en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrudMatos));
            if (isFormOpen == false)
            {
                FormCrudMatos lematos = new FormCrudMatos();
                lematos.StartPosition = FormStartPosition.CenterScreen;
                lematos.ShowDialog();
            }
           
        }

        private void buttonTech_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudTech en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrudTech));
            if (isFormOpen == false)
            {
                FormCrudTech letech = new FormCrudTech();
                letech.StartPosition = FormStartPosition.CenterScreen;
                letech.ShowDialog();                
            }
            
        }
    }
}
