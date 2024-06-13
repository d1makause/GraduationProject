using Database;
using Database.Entities;

namespace WinFormsApplication.Components
{
    public partial class RejectAcademicLeaveControl : UserControl
    {
        private readonly RejectAcademicLeaveRequestDemand _rejectAcademicLeaveRequestDemand;

        public event Action DemandDeleted = delegate { };

        public RejectAcademicLeaveControl(RejectAcademicLeaveRequestDemand rejectAcademicLeaveRequestDemand)
        {
            _rejectAcademicLeaveRequestDemand = rejectAcademicLeaveRequestDemand;

            InitializeComponent();

            titleLabel.Text = string.Format(titleLabel.Text, rejectAcademicLeaveRequestDemand.AcademicLeaveRequest.Student.FullName);
            descriptionLabel.Text = string.Format(
                descriptionLabel.Text,
                rejectAcademicLeaveRequestDemand.AcademicLeaveRequest.RequestTime.ToShortDateString());
            contactNumberLabel.Text = string.Format(contactNumberLabel.Text, rejectAcademicLeaveRequestDemand.AcademicLeaveRequest.ContactPhone);
            studentGroupLabel.Text = string.Format(studentGroupLabel.Text, rejectAcademicLeaveRequestDemand.AcademicLeaveRequest.Student.Group.Name);
            requestTimeLabel.Text = string.Format(requestTimeLabel.Text, rejectAcademicLeaveRequestDemand.RequestTime);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DatabaseContext())
            {
                dbContext.RejectAcademicLeaveRequestDemands.Remove(_rejectAcademicLeaveRequestDemand);

                dbContext.AcademicLeaveRequests.Remove(_rejectAcademicLeaveRequestDemand.AcademicLeaveRequest);

                dbContext.SaveChanges();
            }

            MessageBox.Show("Заявка на академический отпуск успешно удалена");

            DemandDeleted();
        }
    }
}
