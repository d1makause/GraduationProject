using Database;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;

namespace WinFormsApplication.Forms
{
    public partial class AcademicLeavesForm : Form
    {
        public AcademicLeavesForm()
        {
            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            using var dbContext = new DatabaseContext();

            academicLeaveContainer.Controls.Clear();

            foreach (var academicLeaveRequest in dbContext.AcademicLeaveRequests
                .Include(x => x.Student)
                .Include(x => x.Student.Group))
            {
                var academicLeaveControl = new AcademicLeaveControl(academicLeaveRequest);

                academicLeaveContainer.Controls.Add(academicLeaveControl);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var createAcademicLeaveForm = new CreateAcademicLeaveForm();

            createAcademicLeaveForm.FormClosed += (s, e) => FillData();

            createAcademicLeaveForm.Show();
        }
    }
}
