// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormCrudMatos qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormCrudMatos : Form
    {
        // on définit un mode qui sera soit pour un ajouter ou modifer une information de la database
        private string mode;

        public FormCrudMatos()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // on propose à l'utiisateur de quitter la FormCrudMatos si il le souhaite
            Close();
        }

        private void FormCrudMatos_Load(object sender, EventArgs e)
        {
            // au chargement de notre form, on apelle la méthode chargeClient pour tout initialiser 
            chargeClient();
        }

        // on initialise notre form en définissant tout ce qui a besoin d'etre définit au chargement de la form
        private void chargeClient()
        {
            // on commence par vider notre listbox au chargement juste au cas où
            listBoxMatos.Items.Clear();
            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                // on récupère tout nos site depuis la databse et on remplit notre listbox avec tout ce que notre requete 
                // nous a retourné comme donnée
                strSQLClient = "SELECT * FROM materiel";
                drSQLClient = Connection.openConnection(strSQLClient);

                // on remplit notre listbox juste du nom du site ce qui nous permettra par la suite de pouvoir cibler un éléments 
                // de la listbox en nous basant juste de son nom ce qui sera plus simple et parlant plutot que d'utiliser son id 
                while (drSQLClient.Read())
                {
                    listBoxMatos.Items.Add(drSQLClient["nom"].ToString());
                }
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
            // puis on rend les textbox grisée (non selectionnable)
            EnableClient(false);
        }
        // on rend clickable ou non nos éléments en fonction du booléen passé en parametre 
        // true = nos éléments sont alors selectionnable, clickable (non grisée)
        // false = nos éléments sont alors non selectionnable, non clickable (grisée)
        // petite précision si les textbox sont grisés alors les boutons/listbox sont clickables
        // et inversement si c'est les bouton/listbox qui sont grisés on utilise alors le !b pour avoir
        // l'inverse de ce qui à été passé en paramêtre
        private void EnableClient(bool b)
        {
            comboBoxClientMatos.Enabled = b;
            comboBoxSiteMatos.Enabled = b;
            textBoxNomMatos.Enabled = b;
            textBoxDescMatos.Enabled = b;
            comboBoxTypeMatos.Enabled = b;
            DateTimePickerIntervMatos.Enabled = b;
            textBoxMtbfMatos.Enabled = b;
            listBoxMatos.Enabled = !b;
            buttonAjouterClient.Enabled = !b;
            buttonValider.Enabled = b;
            buttonModifierClient.Enabled = !b;
            buttonSupprimerClient.Enabled = !b;
            buttonAnnuler.Enabled = b;
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNomCLient = listBoxMatos.SelectedItem.ToString();


            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete les informations précise 
            // que l'on souhaite récupéreré et afficher depuis la database
            strSQLClient = "SELECT * FROM materiel where nom = '" + strNomCLient + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            while (drSQLClient.Read())
            {
                comboBoxClientMatos.Items.Add(drSQLClient["id_client"].ToString());
                comboBoxSiteMatos.Items.Add(drSQLClient["id_site"].ToString());
                textBoxNomMatos.Text = drSQLClient["nom"].ToString();
                textBoxDescMatos.Text = drSQLClient["description"].ToString();
                comboBoxTypeMatos.Items.Add(drSQLClient["type"].ToString());
                DateTimePickerIntervMatos.Text = drSQLClient["date_intervention_faite"].ToString().Substring(0, 10);
                textBoxMtbfMatos.Text = drSQLClient["mtbf"].ToString();
            }
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsClient();

            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete les informations précise 
            // que l'on souhaite récupéreré et afficher depuis la database
            strSQLClient = "SELECT m.type as type_matos, s.id_site as liste_site, c.id_client as list_client " +
                " FROM materiel m inner join site s on s.id_site = m.id_site inner join client c " +
                " on c.id_client = m.id_client";
            drSQLClient = Connection.openConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            while (drSQLClient.Read())
            {
                if (!comboBoxClientMatos.Items.Contains("2"))
                    comboBoxClientMatos.Items.Add(drSQLClient["list_client"].ToString());
                if (!comboBoxSiteMatos.Items.Contains("1"))
                    comboBoxSiteMatos.Items.Add(drSQLClient["liste_site"].ToString());
                if (!comboBoxTypeMatos.Items.Contains("informatique"))
                    comboBoxTypeMatos.Items.Add(drSQLClient["type_matos"].ToString());
            }

            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableClient(true);

            comboBoxClientMatos.Focus();
            mode = "Ajouter";
        }

        private void EffaceInformationsClient()
        {
            // on vide tout les éléments visuels de notre form (textbox, listbox...)
            comboBoxClientMatos.Items.Clear();
            comboBoxSiteMatos.Items.Clear();
            textBoxNomMatos.Text = "";
            textBoxDescMatos.Text = "";
            DateTimePickerIntervMatos.Text = "";
            comboBoxTypeMatos.Items.Clear();
            textBoxMtbfMatos.Text = "";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = comboBoxClientMatos.Text;
            string stradr = comboBoxSiteMatos.Text;
            string strlgn = textBoxNomMatos.Text;
            string strpwd = textBoxDescMatos.Text;
            string strmail = comboBoxTypeMatos.Text;
            string strmtbf = textBoxMtbfMatos.Text;

            // on vérifie que la textbox pour le nom n'est pas vide
            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de client vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // si on a clické sur ajouter le mode définit est alors égale à Ajouter 
            // on peut alors éxécuter notre requete d'insert de données dans la database
            if (mode == "Ajouter")
            {
                // on définit ensuite notre requete de modifcation en filtrant pour modifier uniquement l'élément selectionné
                strSQL = string.Format("INSERT INTO materiel (id_client, id_site, nom, description, type, " +
                    "date_intervention_faite, mtbf) " +
                    "VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6})",
                    sternom, stradr, strlgn, strpwd, strmail, DateTimePickerIntervMatos.Value, strmtbf);
            }
            // si on a clické sur modifier le mode définit est alors égale à Modifier 
            // on peut alors éxécuter notre requete de modifiquation de données dans la database
            else if (mode == "Modifier")
            {
                // on récupère l'id du matériel car pour mettre à jour nos informations nous devons nous baser l'id de l'éléments
                int idmat;
                string sql2 = "select * from materiel  where nom = '" + listBoxMatos.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idmat = Convert.ToInt32(drSQLInterv["id_mat"]);
                drSQLInterv.Close();

                // on définit ensuite notre requete de modifcation en filtrant pour modifier uniquement l'élément selectionné
                strSQL = string.Format("UPDATE materiel SET id_client = {0}, id_site = {1}, nom = '{2}', " +
                    "description = '{3}', type = '{4}', date_intervention_faite = '{5}', " +
                    "mtbf = {6} where id_mat = {7}",
                    sternom, stradr, strlgn, strpwd, strmail, DateTimePickerIntervMatos.Value, strmtbf, idmat);
            }
            // si un mode différent à été définit on la gère en retournant une exception
            else
            {
                throw new Exception("Mode invalide");
            }
            // on éxécute notre requete sql
            Connection.executeQuery(strSQL);
            // et on ferme toute nos connection à la database
            Connection.closeConnection();
            // puis une fois la requete executé, on apelle la méthode chargeSite pour tout réinitialiser 
            // et recharger notre form automatiquement avec les modifcation que l'on iven de saisir 
            chargeClient();
            // et on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsClient();
        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            // si aucun élément de la listbox n'a été selectionné il faut empecher l'utilisateur de pouvoir agir sur la database
            // c'est pourquoi on lui retourne une erreur si il click sur ajouter ou modifier alors qu'aucun éléments n'a été selectionné 
            if (listBoxMatos.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un matériel !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxMatos.Focus();
                return;
            }
            // on récupère le nom du matériel selectionné
            string sternom = textBoxNomMatos.Text;
            string strSQLClient = "";

            // on définit notre requete de supression en filtrant sur son nom et on l'éxécute
            strSQLClient = "delete from materiel where nom = '" + sternom + "'";
            Connection.openConnection(strSQLClient);

            chargeClient();

            EffaceInformationsClient();
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            // si aucun élément de la listbox n'a été selectionné il faut empecher l'utilisateur de pouvoir agir sur la database
            // c'est pourquoi on lui retourne une erreur si il click sur ajouter ou modifier alors qu'aucun éléments n'a été selectionné 
            if (listBoxMatos.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxMatos.Focus();
                return;
            }
            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableClient(true);

            // et on définit notre mode pour qu'il soit égale à Modifier celà veut dire que le bouton modifier à été clické
            comboBoxClientMatos.Focus();
            mode = "Modifier";
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsClient();
            // on rend toute nos textbox disable donc non clickable (grisée)
            EnableClient(false);
            // et on vide le contenu de notre variable mode 
            mode = "";
        }
    }
}
