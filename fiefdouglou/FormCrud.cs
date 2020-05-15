// on définit toutes les librairies (assembly) dont on a besoins 
// dans le fichiers en les important
using System;
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
            Connection.GetConnectionString();
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            // on propose à l'utiisateur de quitter la FormCrud si il le souhaite
                Close();
        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudClient en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudClient));
            if (!isFormOpen)
            {
                var leclient = new FormCrudClient()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                leclient.Show();
            }
        }

        private void ButtonSite_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudSite en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudSite));
            if (!isFormOpen)
            {
                var lesite = new FormCrudSite()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                lesite.Show();
            }
        }

        private void ButtonMatos_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudMatos en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudMatos));
            if (!isFormOpen)
            {
                var lematos = new FormCrudMatos()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                lematos.Show();
            }

        }

        private void ButtonTech_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudTech en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudTech));
            if (!isFormOpen)
            {
                var letech = new FormCrudTech()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                letech.Show();
            }

        }

        private void ButtonInterv_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.IsAlreadyOpen(typeof(FormCrudInterv));
            if (!isFormOpen)
            {
                var linterv = new FormCrudInterv()
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                linterv.Show();
            }
        }
    }
}
