using System.Windows.Forms;

namespace fiefdouglou
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void siteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormSite));
            if (isFormOpen == false)
            {
                FormSite formSite = new FormSite();
                formSite.StartPosition = FormStartPosition.CenterScreen;
                formSite.Show();
            }
        }

        private void interventionToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormIntervention));
            if (isFormOpen == false)
            {
                FormIntervention formInterv = new FormIntervention();
                formInterv.StartPosition = FormStartPosition.CenterScreen;
                formInterv.Show();
            }
        }

        private void clientToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Connection connect = new Connection();
            bool isFormOpen = connect.isAlreadyOpen(typeof(FormSos));
            if (isFormOpen == false)
            {
                FormSos formSos = new FormSos();
                formSos.StartPosition = FormStartPosition.CenterScreen;
                formSos.Show();
            }
        }
    }
}
