namespace WinFormsApplication.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            ShowForm(new EventsForm());
        }

        private void academicLeaveButton_Click(object sender, EventArgs e)
        {
            ShowForm(new AcademicLeavesForm());
        }

        private void rejectAcademicLeaveButton_Click(object sender, EventArgs e)
        {
            ShowForm(new RejectAcademicLeavesDemandsForm());
        }

        private void ShowForm(Form form)
        {
            Opacity = 0;

            ShowInTaskbar = false;

            form.FormClosed += (s, e) =>
            {
                Opacity = 1;

                ShowInTaskbar = true;

                Focus();
            };

            form.Show();
        }
    }
}
