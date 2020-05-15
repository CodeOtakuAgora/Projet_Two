// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// on encapsule tote notre form dans un bocal (package) propre au projet
namespace fiefdouglou
{
    /* Entité Connection qui contient toutes les méthodes pour se connecter à ql server et éxécuter n'importe quelle requetes sql
    * et d'accésibilité public afin qu'elle soit accesible depuis n'importe quel form à la différence des méthodes private
    *
    * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
    *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe. 
    *  Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique 
    *  en utilisant le nom de classe lui-même
    */
    public class Connection
    {
        // on définie toute nos variables que l'on aura besoin pour éxécuter nos requetes sql

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        private static SqlConnection cnSQL = null;
        private static SqlCommand cmSQL = null;
        private static SqlDataReader drSQL = null;
        private static string connString = "";
        private bool isOpen = false;


        // on récupère les identifiants de connection à la base de donnée du fichier App.config
        // grace au configurationManager de notre connectionString

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static void GetConnectionString()
        {
            connString = ConfigurationManager.ConnectionStrings["fiefdouglouConnectionString"].ToString();
        }

        // cette méthode est a apellé dés qu'on sohaite éxécuter une requete avec un SELECT et donc afficher des
        // informations depuis la database en utilisant un ExecuteReader

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static SqlDataReader OpenConnection(string sqlQuery)
        {
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(sqlQuery, cnSQL);
            drSQL = cmSQL.ExecuteReader();
            return drSQL;
        }

        // cette méthode est a apellé dés qu'on sohaite éxécuter une requete avec un SELECT COUNT et donc
        // savoir si un élément dans la databse existe avec 0 si rien à été trouvé et 1 si la requete 
        // à au moin etourner une valeur dans la database en utilisant un ExecuteScalar et en le convertissant en un entier

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static int ExecuteCountQuery(string sqlQuery)
        {
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(sqlQuery, cnSQL);
            int res = (int)cmSQL.ExecuteScalar();
            return res;
        }

        // cette méthode est a apellé dés qu'on souhaite éxécuter une procédure stockée contenu dans notre database
        // une procédure stockée est un ensemble d'instructions SQL déjà configurés, stockées dans une base de données 
        // et pretes à etre exécutées sur la demande de Sql server
        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static SqlDataReader ExecuteProcedure(string procedure)
        {
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(procedure, cnSQL)
            {
                CommandType = CommandType.StoredProcedure
            };
            return cmSQL.ExecuteReader();
        }

        // cette méthode est a apellé dés qu'on sohaite éxécuter une requete autre que SELECT tels que
        // UPDATE, INSERT, et DELETE et donc permet de modifier une ou des informations présentes dans la database
        // en utilisant un ExecuteNonQuery

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static void ExecuteQuery(string sqlQuery)
        {
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(sqlQuery, cnSQL);
            SqlDataAdapter adapter = new SqlDataAdapter()
            {
                UpdateCommand = new SqlCommand(sqlQuery, cnSQL)
            };
            adapter.UpdateCommand.ExecuteNonQuery();
        }

        // cette méthode permet de fermer toutes les connection à la base de donnée si une quelquonque requete à été défini

        /*
         * on utilise le type static car : une classe statique ne peut pas être instanciée. En d’autres termes, 
         *  vous ne pouvez pas utiliser l’opérateur new pour créer une variable du type classe.
         * Étant donné qu’il n’y a aucune variable d’instance, vous accédez aux membres d’une classe statique
         * en utilisant le nom de classe lui-même
        */
        public static void CloseConnection()
        {
            if (drSQL != null)
                drSQL.Close();
            if (cnSQL != null)
                cnSQL.Close();
            if (cmSQL != null)
                cmSQL.Dispose();
            if (cnSQL != null)
                cnSQL.Dispose();
        }

        /*
            La méthode ci-dessous bouclera à travers tous les formulaires ouverts dans l'application 
            et vérifiera si le formulaire de paramètre d'entrée est le même que celui de tout formulaire 
            ouvert et retournera vrai si le formulaire est déjà ouvert et retournera faux si le formulaire 
            n'est pas ouvert.
        */

        /*
         * on n'utilise pas le type static car sinon le Application.OpenForms risque de garder en mémoire
         * des form qui aurait été ouverte puis fermé et nous déclencharait des erreurs par rapport 
         * aux form déjà ouvertes c'est pourquoi nous devrons alors le définir avec le type new pour instancier 
         * et donc apeller cette méthode pour éviter les doublons de form
        */
        public bool IsAlreadyOpen(System.Type formType)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == formType)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    isOpen = true;
                }
            }
            return isOpen;
        }

    }
}
