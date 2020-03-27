// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormCrudClient qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormCrudClient : Form
    {
        // on définit un mode qui sera soit pour un ajouter ou modifer une information de la database
        private string mode;

        public FormCrudClient()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // on propose à l'utiisateur de quitter la FormCrudSite si il le souhaite
            Close();
        }

        private void FormCrudClient_Load(object sender, EventArgs e)
        {
            // au chargement de notre form, on apelle la méthode chargeSite pour tout initialiser 
            chargeClient();
        }

        // on initialise notre form en définissant tout ce qui a besoin d'etre définit au chargement de la form
        private void chargeClient()
        {
            // on commence par vider notre listbox au chargement juste au cas où aisi que nos combobox
            listBoxClient.Items.Clear();

            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            try
            {
                 // on récupère tout nos clients depuis la databse et on remplit notre listbox avec tout ce que notre 
                // requete nous a retourné comme donnée
                strSQLClient = "SELECT * FROM client";
                drSQLClient = Connection.openConnection(strSQLClient);

                // une fois la requete executé, on ferme tout nos connection à la database que l'on a définit
                while (drSQLClient.Read())
                {
                    listBoxClient.Items.Add(drSQLClient["nom"].ToString());
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
            comboBoxSiteClient.Enabled = b;
            comboBoxIntervClient.Enabled = b;
            textBoxLoginClient.Enabled = b;
            textBoxPassClient.Enabled = b;
            textBoxTelClient.Enabled = b;
            textBoxMailClient.Enabled = b;
            listBoxClient.Enabled = !b;
            buttonAjouterClient.Enabled = !b;
            buttonValider.Enabled = b;
            buttonModifierClient.Enabled = !b;
            buttonSupprimerClient.Enabled = !b;
            buttonAnnuler.Enabled = b;
        }

        private void listBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strNomCLient = listBoxClient.SelectedItem.ToString();


            SqlDataReader drSQLClient = null;
            string strSQLClient = "";

            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete 
            // les informations précise que l'on souhaite récupéreré et afficher depuis la database
            strSQLClient = "SELECT * FROM client where nom = '" + strNomCLient + "'";
            drSQLClient = Connection.openConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            while (drSQLClient.Read())
            {
                // au chargement de la form on remplit nos comboBox de tout nos sites
                // notre comboBox de tout les nom de nos sites, interventions de la database
                comboBoxIntervClient.Items.Add(drSQLClient["id_intervention"].ToString());
                comboBoxSiteClient.Items.Add(drSQLClient["site"].ToString());

                textBoxLoginClient.Text = drSQLClient["nom"].ToString();
                textBoxPassClient.Text = drSQLClient["prenom"].ToString();
                textBoxMailClient.Text = drSQLClient["mail"].ToString();
                textBoxTelClient.Text = drSQLClient["telephone"].ToString();
            }           
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsClient();

            SqlDataReader drSQLClient = null;
            string strSQLClient = "";
            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete 
            // les informations précise que l'on souhaite récupéreré et afficher depuis la database
            strSQLClient = "SELECT c.nom as nom_client, c.prenom as prenom_client, c.mail as mail_client, " +
                " c.telephone as tel_client, s.id_site as id_du_site, i.id_intervention as id_de_intervention FROM client c" +
                " inner join site s on s.id_site = c.site inner join intervention i on " +
                " i.id_intervention = c.id_intervention ";
            drSQLClient = Connection.openConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            while (drSQLClient.Read())
            {
                    comboBoxIntervClient.Items.Add(drSQLClient["id_de_intervention"].ToString());
                    comboBoxSiteClient.Items.Add(drSQLClient["id_du_site"].ToString());
            }

            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableClient(true);
            // et on définit notre mode pour qu'il soit égale à Ajouter celà veut dire que le bouton ajouter à été clické
            comboBoxIntervClient.Focus();
            mode = "Ajouter";
        }

        private void EffaceInformationsClient()
        {
            // on vide tout les éléments visuels de notre form (textbox, combobox...)
            comboBoxIntervClient.Items.Clear();
            comboBoxSiteClient.Items.Clear();
            textBoxLoginClient.Text = "";
            textBoxPassClient.Text = "";
            textBoxTelClient.Text = "";
            textBoxMailClient.Text = "";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            string sternom = comboBoxIntervClient.Text;
            string stradr = comboBoxSiteClient.Text;
            string strlgn = textBoxLoginClient.Text;
            string strpwd = textBoxPassClient.Text;
            string strtel = textBoxTelClient.Text;
            string strmail = textBoxMailClient.Text;
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
                strSQL = string.Format("INSERT INTO client(id_intervention, site, nom, prenom, mail, telephone) " +
                    "VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}')", 
                    sternom, stradr, strlgn, strpwd, strmail, strtel);
            }
            // si on a clické sur modifier le mode définit est alors égale à Modifier 
            // on peut alors éxécuter notre requete de modifiquation de données dans la database
            else if (mode == "Modifier")
            {
                // on récupère l'id du client car pour mettre à jour nos informations nous devons nous baser l'id de l'éléments
                int idclient;
                string sql2 = "select * from client  where nom = '" + listBoxClient.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.openConnection(sql2);
                drSQLInterv.Read();
                idclient = Convert.ToInt32(drSQLInterv["id_client"]);
                drSQLInterv.Close();

                // on définit ensuite notre requete de modifcation en filtrant pour modifier uniquement l'élément selectionné
                strSQL = string.Format("UPDATE client SET id_intervention = {0}, site = {1}, nom = '{2}', " +
                    "prenom = '{3}', mail = '{4}', telephone = '{5}' where id_client = {6}",
                    sternom, stradr, strlgn, strpwd, strmail, strtel, idclient);
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
            if (listBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxClient.Focus();
                return;
            }

            // on récupère le nom du client selectionné
            string sternom = textBoxLoginClient.Text;
            string strSQLClient = "";

            // on définit notre requete de supression en filtrant sur son nom et on l'éxécute
            strSQLClient = "delete from client where nom = '" + sternom + "'";
            Connection.openConnection(strSQLClient);

            chargeClient();

            EffaceInformationsClient();
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            // si aucun élément de la listbox n'a été selectionné il faut empecher l'utilisateur de pouvoir agir sur la database
            // c'est pourquoi on lui retourne une erreur si il click sur ajouter ou modifier alors qu'aucun éléments n'a été selectionné 
            if (listBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxClient.Focus();
                return;
            }

            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableClient(true);

            // et on définit notre mode pour qu'il soit égale à Modifier celà veut dire que le bouton modifier à été clické
            comboBoxIntervClient.Focus();
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
