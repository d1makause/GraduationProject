using Database;
using Database.Entities;
using WinFormsApplication.Forms;

namespace WinFormsApplication.Components
{
    public partial class EventsControl : UserControl
    {
        private Event _eventEntity;

        public event Action EntityRemoved = delegate { };

        public event Action EntityUpdated = delegate { };

        public EventsControl(Event eventEntity, Employee[] employees, Student[] students)
        {
            _eventEntity = eventEntity;

            InitializeComponent();

            var containEmployeeFullNames = employees
                .Where(x => eventEntity.EmployeeIds.Contains(x.Id))
                .Select(x => x.FullName);

            var containStudentFullNames = students
                .Where(x => eventEntity.StudentIds.Contains(x.Id))
                .Select(x => x.FullName);

            nameLabel.Text = eventEntity.Name;
            descriptionLabel.Text = string.Format(descriptionLabel.Text, eventEntity.Description);
            participantsAmountLabel.Text = string.Format(participantsAmountLabel.Text, eventEntity.ParticipantsAmount);
            startDateLabel.Text = string.Format(startDateLabel.Text, eventEntity.StartDate.ToString());
            isCompletedCheckbox.Checked = eventEntity.IsCompleted;
            studentsLabel.Text = string.Format(studentsLabel.Text, string.Join(", ", containEmployeeFullNames));
            employeesLabel.Text = string.Format(employeesLabel.Text, string.Join(", ", containStudentFullNames));
            activityKindLabel.Text = string.Format(activityKindLabel.Text, eventEntity.ActivityKind.Name);
            activityCategoryLabel.Text = string.Format(activityCategoryLabel.Text, eventEntity.ActivityCategory.Name);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new DatabaseContext())
            {
                dbContext.Events.Remove(_eventEntity);

                dbContext.SaveChanges();
            }

            EntityRemoved();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editForm = new EventSetForm(_eventEntity);

            editForm.EventsUpdated += EntityUpdated;

            editForm.Show();
        }

        private void isCompletedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var eventEntity = dbContext.Events.First(x => x.Id == _eventEntity.Id);

            eventEntity.IsCompleted = _eventEntity.IsCompleted = isCompletedCheckbox.Checked;

            dbContext.SaveChanges();
        }
    }
}
