//on définit toutes les librairies(assembly) dont on a besoins
// dans le fichiers en les important
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

// on encapsule toute notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité FormSite qui étends la class Form afin de récupérer toute les class pour manipuler des formulaire windows form
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    * et de type partial car quand vous utilisez une source générée automatiquement, vous pouvez ajouter du code à la classe sans avoir à 
    * recréer le fichier source. Visual Studio suit cette approche pour créer des formulaires Windows Forms
    */
    public partial class FormSite : Form
    {
        public FormSite()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
        }

        private void ButtonIntervention_Click(object sender, EventArgs e)
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

        private void ButtonNewIntervention_Click(object sender, EventArgs e)
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

        private void buttonRetourSite_Click(object sender, EventArgs e)
        {
            // si on quite cette form avec le bouton retour alors la form actuelle se ferme
            // puis on charge la FormHome en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            this.Close();
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormHome));
            if (isFormOpen == false)
            {
                FormHome formHome = new FormHome();
                formHome.StartPosition = FormStartPosition.CenterScreen;
                formHome.Show();
            }
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            SqlDataReader drSQLSite, drSQLInterv = null;
            string strSQLSite, strSQLInterv = "";
            // on définit un compteur afin que lorsque que l'on va surligner une intervention (rouge, vert)
            // pour fficher de manière graphique si elle est validé ou pas, on a alors beosin d'un compteur qui commence à 0
            // pour que le surlignage ne ce fasse que un élemnt précis de notre listView
            int i = 0;

            try
            {
                // on essaye d'éxecuter un bout de code
                // on récupère tout les sites ainsi que toutes les interventions dont l'id 
                // est supérieur a 2 pour afficher que 2 intervention car il faut savoir qu'une listView nous génére une
                // erreur si elle contient plus de 3 éléments je ne sais pas pourquoi du coup pour éviter celà 
                // on filtre les interventions
                strSQLSite = "SELECT * FROM site";
                drSQLSite = Connection.openConnection(strSQLSite);

                strSQLInterv = "SELECT * FROM intervention where id_intervention > 2";
                drSQLInterv = Connection.openConnection(strSQLInterv);

                // on vide notre listView et notre comboBox avant de les remplirs juste au cas où
                comboBoxSiteNom.Items.Clear();
                listViewInterv.Items.Clear();

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la comboBox et la textBox
                while (drSQLSite.Read())
                {
                    comboBoxSiteNom.Items.Add(drSQLSite["nom"].ToString());
                    textBoxAdresseSite.Text = drSQLSite["adresse"].ToString() + " / " + drSQLSite["code_postal"].ToString() + " / " + drSQLSite["ville"].ToString();
                }

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listView
                while (drSQLInterv.Read())
                {
                    listViewInterv.Items.Add(drSQLInterv["id_intervention"].ToString() + " / " + drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString() + " / " + drSQLInterv["valide"].ToString());
                    // on définit la largueur de chqaue colonne pour chaque élement de notre listView
                    listViewInterv.Columns[i].Width = 1000;
                    // on convertit la valeur de retour en booléen et on regarde le contenu du champ valide pour chaque
                    // élément de notre listView
                    if ((bool)drSQLInterv["valide"] == true)
                    {
                       // l'intervention est validé car elle vaut true donc on surligne l'élément en vert 
                       listViewInterv.Items[i].BackColor = Color.Green;
                    }
                    else
                    {
                        // l'intervention n'est pas validé car elle vaut false donc on surligne l'élément en rouge 
                        listViewInterv.Items[i].BackColor = Color.Red;
                    }
                    // puis on incrémente notre compteur
                    i++;
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

        private void buttonValiderSite_Click(object sender, EventArgs e)
        {
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            string strSQLInterv, text;
            // ce booléen nous permettra de savoir si la requete c'est bien passé afin qu'on puisse recharger la form
            // une fois que la requete executé pour que les modifiquations soient prises en compte
            bool validate = false;

            try
            {
                // on récupère tout le contenu de l'élément de la la listView qui à été selectionné
                text = listViewInterv.SelectedItems[0].Text;
                // si l'élement de notre listView selectionné contient la valeur False
                // et qu'on cherche a validé une intervention qui à pas déjà été validé 
                // on demande la confirmation de l'utilisateur sur la validation de l'intervention
                if (text.Contains("False"))
                {
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment valider cette intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        // on éxécute ensuite notre requete de mise à jour pour notre intervention selectionné
                        // en modifiant la valeur du champ valide on définit si l'intervention est validé ou pas
                        // dans cette requette on passe le champ valide à 1 pour valider une intervention
                        // 1 : intervention validé 
                        // 0 : intervention pas encore validé
                        strSQLInterv = string.Format("UPDATE intervention SET valide = 1 WHERE id_intervention = {0}", text[0]);
                        Connection.executeQuery(strSQLInterv);
                        // la requete s'est bien passé donc notre booléen passe à true
                        validate = true;
                    }
                }
                // si l'élement de notre listView selectionné contient la valeur True
                // et qu'on cherche a validé une intervention qui à déjà été validé 
                // on affiche alors un message d'avertissement pour prévenir l'utilisateur qu'il fait une erreur
                else if (text.Contains("True"))
                {
                    MessageBox.Show("Cette intervention à déjà été validée", "Log d'Infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // si il y a une erreur de passage d'arguments dans n'importe quelle méthode qu'on essaye d'éxécuté 
            // alors on attrape l'exception et on affiche l'erreur
            catch (ArgumentException)
            {
                MessageBox.Show("Veuillez selectionner une intervention", "Érreur d'Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // si la requete s'est bien passé validate contiendra alors true et rechargera alors la formSite
                // avec les nouvelles modifications qui ont été prises en compte grace aux requete précédemmment éxécuté
                if (validate == true)
                {
                    // si on quite cette form avec le bouton retour alors la form actuelle se ferme
                    // puis on charge la FormHome en vérifiant si elle est pas déjà ouverte 
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
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            string strSQLInterv, strSQLCountInterv;
            SqlDataReader drSQLInterv;
            // on définit un compteur afin que lorsque que l'on va surligner une intervention (rouge, vert)
            // pour fficher de manière graphique si elle est validé ou pas, on a alors beosin d'un compteur qui commence à 0
            // pour que le surlignage ne ce fasse que un élement précis de notre listView
            int i = 0;
            int interv;
            try
            {
                // on essaye d'éxecuter un bout de code
                // on récupère toutes les intervention dont le materiel concerné correpond à ce qui à été rentré 
                // dans la barre de recherche si il y a une correpondace l'intervention sera alors affiché
                strSQLInterv = string.Format("SELECT * FROM intervention WHERE materiel_concerne LIKE '%{0}%' AND id_intervention > 2", textBoxSearch.Text);
                drSQLInterv = Connection.openConnection(strSQLInterv);

                // on va vérifier si lintervention existe comme ca on pourra gérer si l'utilisateur rentre n'importe quoi
                // dans la barre de recherche on pourra alors lui afficher une message d'erreur
                strSQLCountInterv = string.Format("SELECT COUNT(*) FROM intervention WHERE materiel_concerne LIKE '%{0}%'", textBoxSearch.Text);
                interv = Connection.executeCountQuery(strSQLCountInterv);

                // on vide notre listView avant de la remplir juste au cas où
                listViewInterv.Items.Clear();

                // on boucle sur les valeurs dans la database et on les remplit une par une dans la listbox
                // en précisant unqiuement les colonnes de la databse que l'on souhaite afficher dans la listbox
                while (drSQLInterv.Read())
                {
                    listViewInterv.Items.Add(drSQLInterv["id_intervention"].ToString() + " / " + drSQLInterv["materiel_concerne"].ToString() + " / " + drSQLInterv["commentaire"].ToString() + " / " + drSQLInterv["date_intervention"].ToString() + " / " + drSQLInterv["valide"].ToString());
                    // on définit la largueur de chqaue colonne pour chaque élement de notre listView
                    listViewInterv.Columns[i].Width = 1000;

                    // on convertit la valeur de retour en booléen et on regarde le contenu du champ valide pour chaque
                    // élément de notre listView
                    if ((bool)drSQLInterv["valide"] == true)
                    {
                        // l'intervention est validé car elle vaut true donc on surligne l'élément en vert 
                        listViewInterv.Items[i].BackColor = Color.Green;
                    }
                    else
                    {
                        // l'intervention n'est pas validé car elle vaut false donc on surligne l'élément en rouge 
                        listViewInterv.Items[i].BackColor = Color.Red;
                    }
                    // puis on incrémente notre compteur
                    i++;
                }

                // si aucune intervention n'a été trouvé dans le recherche qui à été saisie on affiche un message d'erreur
                if (interv == 0)
                {
                    MessageBox.Show("Aucun Résultat", "Érreur de Recherche", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
            string strSQLInterv, text;
            // ce booléen nous permettra de savoir si la requete c'est bien passé afin qu'on puisse recharger la form
            // une fois que la requete executé pour que les modifiquations soient prises en compte 
            bool validate = false;

            try
            {
                // on récupère tout le contenu de l'élément de la la listView qui à été selectionné
                text = listViewInterv.SelectedItems[0].Text;
                // si l'élement de notre listView selectionné contient la valeur True
                // et qu'on cherche a annuler la validation d'une intervention qui à été validé 
                // on demande alors la confirmation de l'utilisateur sur la validation de l'intervention
                if (text.Contains("True"))
                {
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment annuler \n la validation de cette intervention ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        // on éxécute ensuite notre requete de mise à jour pour notre intervention selectionné
                        // en modifiant la valeur du champ valide on définit si l'intervention est validé ou pas
                        // dans cette requette on passe le champ valide à 0 pour annuler la validation d'une intervention
                        // 1 : intervention validé 
                        // 0 : intervention pas encore validé
                        strSQLInterv = string.Format("UPDATE intervention SET valide = 0 WHERE id_intervention = {0}", text[0]);
                        Connection.executeQuery(strSQLInterv);
                        // la requete s'est bien passé donc notre booléen passe à true
                        validate = true;
                    }
                }
                // si l'élement de notre listView selectionné contient la valeur False
                // et qu'on cherche a annuler la validation d'une intervention qui à pas déjà été validé 
                // alors on affiche un message d'avertissement pour avertir l'utilisateur qu'il commet une erreur 
                else if (text.Contains("False"))
                {
                    MessageBox.Show("Cette intervention n'à pas déjà été validée", "Log d'Infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             // si il y a une erreur de passage d'arguments dans n'importe quelle méthode qu'on essaye d'éxécuté 
            // alors on attrape l'exception et on affiche l'erreur
            catch (ArgumentException)
            {
                MessageBox.Show("Veuillez selectionner une intervention", "Érreur d'Argument", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // si la requete s'est bien passé validate contiendra alors true et rechargera alors la formSite
                // avec les nouvelles modifications qui ont été prises en compte grace aux requete précédemmment éxécuté
                if (validate == true)
                {
                    // si on quite cette form avec le bouton retour alors la form actuelle se ferme
                    // puis on charge la FormHome en vérifiant si elle est pas déjà ouverte 
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
            }
        }
    }
}