using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormSos : Form
    {
        public FormSos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormSite));
            if (isFormOpen == false)
            {
                FormSite formSite = new FormSite();
                formSite.StartPosition = FormStartPosition.CenterScreen;
                formSite.Show();
            }
        }

        private void confirm_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormRapport));
            if (isFormOpen == false)
            {
                FormRapport formRapport = new FormRapport();
                formRapport.StartPosition = FormStartPosition.CenterScreen;
                formRapport.Show();
            }
        }
    }
}
