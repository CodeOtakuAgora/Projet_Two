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
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormSite));
            if (isFormOpen == false)
            {
                FormSite formSite = new FormSite();
                formSite.StartPosition = FormStartPosition.CenterScreen;
                formSite.Show();
            }
        }

        private void interventionToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormIntervention));
            if (isFormOpen == false)
            {
                FormIntervention formInterv = new FormIntervention();
                formInterv.StartPosition = FormStartPosition.CenterScreen;
                formInterv.Show();
            }
        }

        private void clientToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Connection connection = new Connection();
            bool isFormOpen = connection.isAlreadyOpen(typeof(FormSos));
            if (isFormOpen == false)
            {
                FormSos formSos = new FormSos();
                formSos.StartPosition = FormStartPosition.CenterScreen;
                formSos.Show();
            }
        }

        private void FormHome_Load(object sender, System.EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void consultationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormGM formgm = new FormGM();
            formgm.Show();
        }
    }
}
