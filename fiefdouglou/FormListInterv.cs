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
    public partial class FormListInterv : Form
    {
        public FormListInterv()
        {
            // on charge notre form en initialisant tout ses composants
            InitializeComponent();
            // on récupère les identifiants de connection à la database
            Connection.getConnectionString();
        }

        private void FormListInterv_Load(object sender, EventArgs e)
        {
            // au chargement de la form on remplit nos comboBox de tout nos sites
            // notre comboBox de tout les nom de nos sites de la database
            SqlDataReader drSQLSite = null;
            string strSQLSite = "";

            strSQLSite = "SELECT m.type AS filtre_par_type, c.nom AS filtre_par_client, s.nom AS filtre_par_site, " +
                " m.nom as filtre_par_nom FROM materiel m INNER JOIN client c ON c.id_client = m.id_client " +
                " INNER JOIN site s ON s.id_site = m.id_site";
            drSQLSite = Connection.openConnection(strSQLSite);

            while (drSQLSite.Read())
            {
                if (!comboBoxSite.Items.Contains("site fif"))
                    comboBoxSite.Items.Add(drSQLSite["filtre_par_site"].ToString());
                if (!comboBoxClient.Items.Contains("test"))
                    comboBoxClient.Items.Add(drSQLSite["filtre_par_client"].ToString());
                comboBoxMat.Items.Add(drSQLSite["filtre_par_nom"].ToString());
                if (!comboBoxType.Items.Contains("informatique"))
                    comboBoxType.Items.Add(drSQLSite["filtre_par_type"].ToString());
            }
            Connection.closeConnection();

            button4_Click(sender, e);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // on récupère ce qui à été définit dans nos comboBox
            string sitechoisi = comboBoxSite.SelectedItem.ToString();

            string strfilter = " WHERE (s.nom = '" + sitechoisi + "' )";
            string query = "SELECT i.materiel_concerne as nom_matos, i.commentaire as com_matos, i.date_intervention " +
                " as date_com, i.valide as val_com, t.nom as nom_du_technicien, s.nom as nom_du_param FROM intervention i" +
                " inner join site s on i.id_site = s.id_site inner join technicien t on " +
                " i.id_technicien = t.id_technicien " + strfilter;
            remplirListViewInterv(query);

        }

        private void remplirListViewInterv(string sqlQuery)
        {
            // on commence par vider notre listView juste au cas où
            listViewMat.Items.Clear();

            SqlDataReader drSQL = null;
            string strSQL = "";
            int i = 0;

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
                strSQL = sqlQuery;
                drSQL = Connection.openConnection(strSQL);

                // une fois notre éxécuté on va boucler dessus afin de remplir notre listViwe 
                // de tout ce que nous a retourné notre requete
                while (drSQL.Read())
                {
                    string nom = drSQL["nom_matos"].ToString();
                    string NoSerie = drSQL["com_matos"].ToString();
                    string DateInstallation = drSQL["date_com"].ToString();
                    string mtbf = drSQL["val_com"].ToString();
                    string tech = drSQL["nom_du_technicien"].ToString();
                    string site = drSQL["nom_du_param"].ToString();


                    // on définit notre listView et on la remplit en lui ajoutant tout ce dont on a besoin d'afficher
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = nom;
                    lvi.SubItems.Add(NoSerie);
                    lvi.SubItems.Add(DateInstallation);
                    lvi.SubItems.Add(mtbf);
                    lvi.SubItems.Add(tech);
                    lvi.SubItems.Add(site);

                    listViewMat.Items.Add(lvi);
                    // on définit une variable i qu'on va incrémenter afin de cibler à chaque chaque élments de notre listView afin de 
                    // lui mettre pour chauqe éléments une couleur de fond ;)
                    listViewMat.Items[i].BackColor = Color.Gray;
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

            // une fois que le bout de code a fini son éxécution on ferme toute nos connections à la database
            finally
            {
                Connection.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // on récupère ce qui à été définit dans nos comboBox
            string clientchoisi = comboBoxClient.SelectedItem.ToString();

            string strfilter = " WHERE (c.nom = '" + clientchoisi + "' )";
            string query = "SELECT i.materiel_concerne as nom_matos, i.commentaire as com_matos, i.date_intervention " +
                " as date_com, i.valide as val_com, t.nom as nom_du_technicien, c.nom as nom_du_param FROM intervention i" +
                " inner join client c on i.id_client = c.id_client inner join technicien t on " +
                " i.id_technicien = t.id_technicien " + strfilter;
            remplirListViewInterv(query);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // on récupère ce qui à été définit dans nos comboBox
            string matchoisi = comboBoxMat.SelectedItem.ToString();

            string strfilter = " WHERE (i.materiel_concerne = '" + matchoisi + "' )";
            string query = "SELECT i.materiel_concerne as nom_matos, i.commentaire as com_matos, i.date_intervention " +
                " as date_com, i.valide as val_com, t.nom as nom_du_technicien, s.nom as nom_du_param FROM intervention i" +
                " inner join site s on i.id_site = s.id_site inner join technicien t on " +
                " i.id_technicien = t.id_technicien " + strfilter;
            remplirListViewInterv(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // on récupère ce qui à été définit dans nos comboBox
            string typechoisi = comboBoxType.SelectedItem.ToString();

            string strfilter = " WHERE (m.type = '" + typechoisi + "' )";
            string query = "SELECT i.materiel_concerne as nom_matos, i.commentaire as com_matos, i.date_intervention " +
                " as date_com, i.valide as val_com, t.nom as nom_du_technicien, s.nom as nom_du_site, m.type " +
                " as nom_du_param FROM intervention i inner join site s on i.id_site = s.id_site inner join " +
                " technicien t on i.id_technicien = t.id_technicien inner join materiel m " +
                " on m.nom = i.materiel_concerne " + strfilter;
            remplirListViewInterv(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // on commence par vider notre listView juste au cas où
            listViewMat.Items.Clear();

            // on récupère notre procédure stockée qui permet de récupérer tout les matériel périmés dont la date de 
            // leur prochaines intervention - mtbf (exprimé en nombre de jour) est inférieur à la date actuelle
            SqlDataReader md = Connection.executeProcedure("PrevIntervention");

            // on boucle sur les valeurs dans la database et on les remplit une par une dans la listview
            // en précisant uniquement les colonnes de la database que l'on souhaite afficher dans la listview
            // on remplit la listview et ensuite on définit une largueur pour chaque colonne de notre listview ainsi qu'une
            // couleur de fond pour chaque élément de notre listView
            while (md.Read())
            {
                string nom = md["materiel_concerne"].ToString();
                string NoSerie = md["commentaire"].ToString();
                string DateInstallation = md["date_intervention"].ToString();
                string mtbf = md["valide"].ToString();
                string tech = md["id_technicien"].ToString();
                string site = md["id_site"].ToString();

                // on définit notre listView et on la remplit en lui ajoutant tout ce dont on a besoin d'afficher
                ListViewItem lvi = new ListViewItem();
                lvi.Text = nom;
                lvi.SubItems.Add(NoSerie);
                lvi.SubItems.Add(DateInstallation);
                lvi.SubItems.Add(mtbf);
                lvi.SubItems.Add(tech);
                lvi.SubItems.Add(site);

                listViewMat.Items.Add(lvi);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // on commence par vider notre listView juste au cas où
            listViewMat.Items.Clear();

            // on récupère notre procédure stockée qui permet de récupérer tout les matériel périmés dont la date de 
            // leur prochaines intervention - mtbf (exprimé en nombre de jour) est inférieur à la date actuelle
            SqlDataReader md = Connection.executeProcedure("NextIntervention");

            // on boucle sur les valeurs dans la database et on les remplit une par une dans la listview
            // en précisant uniquement les colonnes de la database que l'on souhaite afficher dans la listview
            // on remplit la listview et ensuite on définit une largueur pour chaque colonne de notre listview ainsi qu'une
            // couleur de fond pour chaque élément de notre listView
            while (md.Read())
            {
                string nom = md["materiel_concerne"].ToString();
                string NoSerie = md["commentaire"].ToString();
                string DateInstallation = md["date_intervention"].ToString();
                string mtbf = md["valide"].ToString();
                string tech = md["id_technicien"].ToString();
                string site = md["id_site"].ToString();

                // on définit notre listView et on la remplit en lui ajoutant tout ce dont on a besoin d'afficher
                ListViewItem lvi = new ListViewItem();
                lvi.Text = nom;
                lvi.SubItems.Add(NoSerie);
                lvi.SubItems.Add(DateInstallation);
                lvi.SubItems.Add(mtbf);
                lvi.SubItems.Add(tech);
                lvi.SubItems.Add(site);

                listViewMat.Items.Add(lvi);
            }
        }
    }
}
