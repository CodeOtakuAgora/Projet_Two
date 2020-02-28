using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fiefdouglou
{
    class Connection
    {
        private static SqlConnection cnSQL = null;
        private static SqlCommand cmSQL = null;
        private static SqlDataReader drSQL = null;
        private static string strSQL = "";
        private static string connString = "";
        private bool isOpen = false;


        // on récupère les identifiants de connection à la base de donnée
        public static void getConnectionString()
        {
            connString = ConfigurationManager.ConnectionStrings["fiefdouglouConnectionString"].ToString();
        }

        // on execute n'importe quels requetes select
        public static SqlDataReader openConnection(string sqlQuery)
        {
            strSQL = sqlQuery;
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(strSQL, cnSQL);
            drSQL = cmSQL.ExecuteReader();
            return drSQL;
        }

        // on execute n'importe quels requetes contenuant un select avec un count
        public static int executeCountQuery(string sqlQuery)
        {
            strSQL = sqlQuery;
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(strSQL, cnSQL);
            int res = (int)cmSQL.ExecuteScalar();
            return res;
        }

        // on execute n'importe quels requetes autres select
        public static void executeQuery(string sqlQuery)
        {
            strSQL = sqlQuery;
            cnSQL = new SqlConnection(connString);
            cnSQL.Open();
            cmSQL = new SqlCommand(strSQL, cnSQL);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = new SqlCommand(sqlQuery, cnSQL);
            adapter.UpdateCommand.ExecuteNonQuery();
        }

        // on ferme tout nos instances de connections à la base donnée
        public static void closeConnection()
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
        public bool isAlreadyOpen(System.Type formType)
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
