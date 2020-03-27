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

        private void buttonInterv_Click(object sender, EventArgs e)
        {
            // on charge la FormCrudInterv en vérifiant si elle est pas déjà ouverte 
            // afin d'éviter d'ouvrir un doublon
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormCrudInterv));
            if (isFormOpen == false)
            {
                FormCrudInterv linterv = new FormCrudInterv();
                linterv.StartPosition = FormStartPosition.CenterScreen;
                linterv.ShowDialog();
            }
        }
    }
}
