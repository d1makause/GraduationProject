using System.Text.RegularExpressions;
using Database;
using Database.Entities;

namespace WinFormsApplication.Forms
{
    public partial class CreateAcademicLeaveForm : Form
    {
        private readonly Regex _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", RegexOptions.Compiled);
        private readonly EditContext _editContext;

        public CreateAcademicLeaveForm()
        {
            _editContext = new EditContext();

            InitializeComponent();

            using var dbContext = new DatabaseContext();

            foreach (var student in dbContext.Students)
            {
                studentsComboBox.Items.Add(new StudentItem()
                {
                    Id = student.Id,
                    FullName = student.FullName
                });
            }

            startTimePicker.MinDate = DateTime.Now.AddDays(14);

            endDatePicker.MinDate = DateTime.Now.AddDays(14);

            _editContext.Create(phoneTextBox, phoneLabel, () => _phoneRegex.IsMatch(phoneTextBox.Text));

            _editContext.Create(studentsComboBox, studentLabel, () => studentsComboBox.SelectedItem is StudentItem);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (_editContext.VerifyAll() == false)
            {
                return;
            }

            using (var dbContext = new DatabaseContext())
            {
                dbContext.AcademicLeaveRequests.Add(new AcademicLeaveRequest()
                {
                    StudentId = (studentsComboBox.SelectedItem as StudentItem).Id,
                    ContactPhone = phoneTextBox.Text,
                    StartTime = startTimePicker.Value,
                    EndTime = endDatePicker.Value,
                    RequestTime = DateTime.Now,
                    IsAccepted = false,
                });

                dbContext.SaveChanges();

                MessageBox.Show("Заявка успешно создана");
            }

            Close();
        }

        private class StudentItem
        {
            public int Id { get; set; }

            public string FullName { get; set; }

            public override string ToString() => FullName;
        }
    }
}
