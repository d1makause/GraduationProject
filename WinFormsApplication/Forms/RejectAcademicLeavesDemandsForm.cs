using Database;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;

namespace WinFormsApplication.Forms
{
    public partial class RejectAcademicLeavesDemandsForm : Form
    {
        public RejectAcademicLeavesDemandsForm()
        {
            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            using var dbContext = new DatabaseContext();

            rejectAcademicLeaveDemandContainer.Controls.Clear();

            foreach (var rejectAcademicLeaveDemand in dbContext.RejectAcademicLeaveRequestDemands
                .Include(x => x.AcademicLeaveRequest)
                .Include(x => x.AcademicLeaveRequest.Student)
                .Include(x => x.AcademicLeaveRequest.Student.Group))
            {
                var rejectAcademicLeaveDemandControl = new RejectAcademicLeaveControl(rejectAcademicLeaveDemand);

                rejectAcademicLeaveDemandControl.DemandDeleted += FillData;

                rejectAcademicLeaveDemandContainer.Controls.Add(rejectAcademicLeaveDemandControl);
            }
        }
    }
}
