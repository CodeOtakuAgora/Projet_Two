// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormCrudTech qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormCrudTech : Form
    {
        // on définit un mode qui sera soit pour un ajouter ou modifer une information de la database
        private string mode;

        public FormCrudTech()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.GetConnectionString();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // on propose à l'utiisateur de quitter la FormCrudTech si il le souhaite
            Close();
        }

        private void FormCrudTech_Load(object sender, EventArgs e)
        {
            // au chargement de notre form, on apelle la méthode chargeSite pour tout initialiser 
            ChargeSite();
        }

        // on initialise notre form en définissant tout ce qui a besoin d'etre définit au chargement de la form
        private void ChargeSite()
        {
            // on commence par vider notre listbox au chargement juste au cas où
            listBoxTech.Items.Clear();

            try
            {
                // on récupère tout nos site depuis la databse et on remplit notre listbox avec tout ce que notre requete 
                // nous a retourné comme donnée
                string strSQLClient = "SELECT * FROM technicien";
                SqlDataReader drSQLClient = Connection.OpenConnection(strSQLClient);

                // on remplit notre listbox juste du nom du site ce qui nous permettra par la suite de pouvoir cibler un éléments 
                // de la listbox en nous basant juste de son nom ce qui sera plus simple et parlant plutot que d'utiliser son id 
                while (drSQLClient.Read())
                {
                    listBoxTech.Items.Add(drSQLClient["nom"].ToString());
                }
                // une fois la requete executé, on ferme tout nos connection à la database que l'on a définit
                Connection.CloseConnection();
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
                Connection.CloseConnection();
            }
            // puis on rend les textbox grisée (non selectionnable)
            EnableSite(false);
        }

        // on rend clickable ou non nos éléments en fonction du booléen passé en parametre 
        // true = nos éléments sont alors selectionnable, clickable (non grisée)
        // false = nos éléments sont alors non selectionnable, non clickable (grisée)
        // petite précision si les textbox sont grisés alors les boutons/listbox sont clickables
        // et inversement si c'est les bouton/listbox qui sont grisés on utilise alors le !b pour avoir
        // l'inverse de ce qui à été passé en paramêtre
        private void EnableSite(bool b)
        {
            textBoxNomTech.Enabled = b;
            comboBoxIntervTech.Enabled = b;
            listBoxTech.Enabled = !b;
            buttonAjouterSite.Enabled = !b;
            buttonValiderSite.Enabled = b;
            buttonModifierSite.Enabled = !b;
            buttonSupprimerSite.Enabled = !b;
            buttonAnnulerSite.Enabled = b;
        }

        private void ListBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete les informations précise 
            // que l'on souhaite récupéreré et afficher depuis la database
            string strSQLClient = "SELECT * FROM technicien where nom = '" + listBoxTech.SelectedItem.ToString() + "'";
            SqlDataReader drSQLClient = Connection.OpenConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            drSQLClient.Read();

            textBoxNomTech.Text = drSQLClient["nom"].ToString();
            comboBoxIntervTech.Items.Add(drSQLClient["id_intervention"].ToString());

            // et on ferme toute les connection à la database
            Connection.CloseConnection();
        }

        private void ButtonSupprimerSite_Click(object sender, EventArgs e)
        {
            // si aucun élément de la listbox n'a été selectionné il faut empecher l'utilisateur de pouvoir agir sur la database
            // c'est pourquoi on lui retourne une erreur si il click sur ajouter ou modifier alors qu'aucun éléments n'a été selectionné 
            if (listBoxTech.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un Technicien !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxTech.Focus();
                return;
            }
            // on récupère le nom du technicien selectionné
            string sternom = textBoxNomTech.Text;

            // on définit notre requete de supression en filtrant sur son nom et on l'éxécute
            string strSQLClient = "delete from technicien where nom = '" + sternom + "'";
            Connection.ExecuteQuery(strSQLClient);

            // puis une fois la requete executé, on apelle la méthode chargeSite pour tout réinitialiser 
            // et recharger notre form automatiquement avec les modifcation que l'on iven de saisir 
            ChargeSite();
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsSite();
        }
        // on vide tout les éléments
        private void EffaceInformationsSite()
        {
            // on vide tout les éléments visuels de notre form (textbox, listbox...)
            textBoxNomTech.Text = "";
            comboBoxIntervTech.Items.Clear();
        }

        private void ButtonAnnulerSite_Click(object sender, EventArgs e)
        {
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsSite();
            // on rend toute nos textbox disable donc non clickable (grisée)
            EnableSite(false);
            // et on vide le contenu de notre variable mode 
            mode = "";
        }

        private void ButtonAjouterSite_Click(object sender, EventArgs e)
        {
            // on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsSite();

            // une fois qu'un éléments de notre listbox à été clické et donc définit en sql on précise dans notre requete les informations précise 
            // que l'on souhaite récupéreré et afficher depuis la database
            string strSQLClient = "SELECT * FROM technicien";
            SqlDataReader drSQLClient = Connection.OpenConnection(strSQLClient);

            // puis on boucle sur le site selectionné et on remplit nos textbox 
            while (drSQLClient.Read())
            {
                comboBoxIntervTech.Items.Add(drSQLClient["id_intervention"].ToString());
            }

            // et on ferme toute les connection à la database
            Connection.CloseConnection();

            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableSite(true);
            // et on définit notre mode pour qu'il soit égale à Ajouter celà veut dire que le bouton ajouter à été clické
            textBoxNomTech.Focus();
            mode = "Ajouter";
        }

        private void ButtonModifierSite_Click(object sender, EventArgs e)
        {
            // si aucun élément de la listbox n'a été selectionné il faut empecher l'utilisateur de pouvoir agir sur la database
            // c'est pourquoi on lui retourne une erreur si il click sur ajouter ou modifier alors qu'aucun éléments 
            // n'a été selectionné 
            if (listBoxTech.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client !",
                    "Avertissement", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                listBoxTech.Focus();
                return;
            }
            // on rend toute nos textbox enable donc clickable (non grisée)
            EnableSite(true);
            // et on définit notre mode pour qu'il soit égale à Modifier celà veut dire que le bouton modifier à été clické
            textBoxNomTech.Focus();
            mode = "Modifier";
        }

        private void ButtonValiderSite_Click(object sender, EventArgs e)
        {
            // on récupère dans des variables tout ce qui à été saisie dans les textbox
            string strSQL = "";
            string sternom = textBoxNomTech.Text;
            string stradr = comboBoxIntervTech.Text;

            // on vérifie que la textbox pour le nom n'est pas vide
            if (sternom == string.Empty)
            {
                MessageBox.Show("Nom de Site vide", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // si on a clické sur ajouter le mode définit est alors égale à Ajouter 
            // on peut alors éxécuter notre requete d'insert de données dans la database
            if (mode == "Ajouter")
            {
                strSQL = string.Format("INSERT INTO technicien(id_intervention, nom) VALUES({0}, '{1}')", stradr, sternom);
            }
            // si on a clické sur modifier le mode définit est alors égale à Modifier 
            // on peut alors éxécuter notre requete de modifiquation de données dans la database
            else if (mode == "Modifier")
            {
                // on récupère l'id du technicien car pour mettre à jour nos informations nous devons nous baser l'id de l'éléments
                int idsite;
                string sql2 = "select * from technicien  where nom = '" + listBoxTech.SelectedItem.ToString() + "'";
                SqlDataReader drSQLInterv = Connection.OpenConnection(sql2);
                drSQLInterv.Read();
                idsite = Convert.ToInt32(drSQLInterv["id_technicien"]);
                drSQLInterv.Close();

                // on définit ensuite notre requete de modifcation en filtrant pour modifier uniquement l'élément selectionné
                strSQL = string.Format("UPDATE technicien SET id_intervention = {0}, nom = '{1}' where id_technicien = {2}", stradr, sternom, idsite);
            }
            // on éxécute notre requete sql
            Connection.ExecuteQuery(strSQL);
            // et on ferme toute nos connection à la database
            Connection.CloseConnection();
            // puis une fois la requete executé, on apelle la méthode chargeSite pour tout réinitialiser 
            // et recharger notre form automatiquement avec les modifcation que l'on iven de saisir 
            ChargeSite();
            // et on vide tout ce qui est contenu dans tout nos éléments visuels (textbox, listbox...)
            EffaceInformationsSite();
        }
    }
}
