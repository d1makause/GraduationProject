using Database;
using Database.Entities;

namespace WinFormsApplication.Components
{
    public partial class AcademicLeaveControl : UserControl
    {
        private AcademicLeaveRequest _academicLeaveRequest;

        public AcademicLeaveControl(AcademicLeaveRequest academicLeaveRequest)
        {
            _academicLeaveRequest = academicLeaveRequest;

            InitializeComponent();

            titleLabel.Text = string.Format(titleLabel.Text, academicLeaveRequest.Student.FullName);
            descriptionLabel.Text = string.Format(
                descriptionLabel.Text,
                academicLeaveRequest.StartTime.ToShortDateString(),
                academicLeaveRequest.EndTime.ToShortDateString());
            contactNumberLabel.Text = string.Format(contactNumberLabel.Text, academicLeaveRequest.ContactPhone);
            studentGroupLabel.Text = string.Format(studentGroupLabel.Text, academicLeaveRequest.Student.Group.Name);
            requestTimeLabel.Text = string.Format(requestTimeLabel.Text, academicLeaveRequest.RequestTime);
            acceptedCheckBox.Checked = academicLeaveRequest.IsAccepted;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            if (dbContext.RejectAcademicLeaveRequestDemands.Any(x => x.AcademicLeaveRequestId == _academicLeaveRequest.Id))
            {
                MessageBox.Show("Заявка на отказ уже создана!");

                return;
            }

            dbContext.RejectAcademicLeaveRequestDemands.Add(new RejectAcademicLeaveRequestDemand()
            {
                AcademicLeaveRequestId = _academicLeaveRequest.Id,
                RequestTime = DateTime.Now
            });

            dbContext.SaveChanges();

            MessageBox.Show("Заявка на отказ успешно создана!");
        }

        private void acceptedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            _academicLeaveRequest.IsAccepted = acceptedCheckBox.Checked;

            dbContext.AcademicLeaveRequests.Update(_academicLeaveRequest);

            dbContext.SaveChanges();
        }
    }
}
