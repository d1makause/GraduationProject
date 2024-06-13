using Database;
using Database.Entities;

namespace WinFormsApplication.Forms
{
    public partial class EventSetForm : Form
    {
        private readonly EditContext _editContext;
        private int? _eventId;

        public event Action EventsUpdated = delegate { };

        public EventSetForm(Event? eventEntity = null)
        {
            _eventId = eventEntity?.Id;

            _editContext = new();

            InitializeComponent();

            if (eventEntity is null)
            {
                titleLabel.Text = Text = "Создание мероприятия";

                submitButton.Text = "Создать";
            }
            else
            {
                titleLabel.Text = Text = "Редактирование мероприятия";

                submitButton.Text = "Обновить";
            }

            using (var dbContext = new DatabaseContext())
            {
                foreach (var employee in dbContext.Employees)
                {
                    var createdIndex = employeesCheckedListBox.Items
                        .Add(new EmployeeItem()
                        {
                            Id = employee.Id,
                            FullName = employee.FullName,
                        });

                    if (eventEntity is not null &&
                        eventEntity.EmployeeIds.Contains(employee.Id))
                    {
                        employeesCheckedListBox.SetItemChecked(createdIndex, true);
                    }
                }

                foreach (var student in dbContext.Students)
                {
                    var createdIndex = studentsCheckedListBox.Items
                        .Add(new StudentItem()
                        {
                            Id = student.Id,
                            FullName = student.FullName,
                        });

                    if (eventEntity is not null &&
                        eventEntity.StudentIds.Contains(student.Id))
                    {
                        studentsCheckedListBox.SetItemChecked(createdIndex, true);
                    }
                }

                foreach (var activityKind in dbContext.ActivityKinds)
                {
                    var createdIndex = activityKindComboBox.Items
                        .Add(new ActivityKindItem()
                        {
                            Id = activityKind.Id,
                            Name = activityKind.Name,
                        });

                    if (eventEntity is not null &&
                        eventEntity.ActivityKindId == activityKind.Id)
                    {
                        activityKindComboBox.SelectedIndex = createdIndex;
                    }
                }

                foreach (var activityCategory in dbContext.ActivityCategories)
                {
                    var createdIndex = activityCategoryComboBox.Items
                        .Add(new ActivityCategoryItem()
                        {
                            Id = activityCategory.Id,
                            Name = activityCategory.Name,
                        });

                    if (eventEntity is not null &&
                        eventEntity.ActivityCategoryId == activityCategory.Id)
                    {
                        activityCategoryComboBox.SelectedIndex = createdIndex;
                    }
                }
            }

            nameTextBox.Text = eventEntity?.Name ?? string.Empty;
            descriptionTextBox.Text = eventEntity?.Description ?? string.Empty;
            participantsAmountInput.Value = eventEntity?.ParticipantsAmount ?? 0;
            startDatePicker.Value = eventEntity?.StartDate ?? DateTime.Now;

            _editContext.Create(nameTextBox, nameLabel, () => nameTextBox.Text is not null && nameTextBox.Text.Length > 3);

            _editContext.Create(participantsAmountInput, participantsAmountLabel, () => true);

            _editContext.Create(startDatePicker, startDateLabel, () => true);

            _editContext.Create(activityKindComboBox, activityKindLabel,
                () => activityKindComboBox.SelectedItem is ActivityKindItem);

            _editContext.Create(activityCategoryComboBox, activityCategoryLabel,
                () => activityCategoryComboBox.SelectedItem is ActivityCategoryItem);

            _editContext.Create(descriptionTextBox, descriptionLabel,
                () => descriptionTextBox.Text is not null && descriptionTextBox.Text.Length > 3);

            _editContext.Create(studentsCheckedListBox, studentsLabel,
                () =>
                {
                    var isValid = true;

                    foreach (var item in studentsCheckedListBox.SelectedItems)
                    {
                        if (item is not StudentItem)
                        {
                            isValid = false;
                            break;
                        }
                    }

                    return isValid;
                });

            _editContext.Create(employeesCheckedListBox, employeesLabel,
                () =>
                {
                    var isValid = true;

                    foreach (var item in employeesCheckedListBox.SelectedItems)
                    {
                        if (item is not EmployeeItem)
                        {
                            isValid = false;
                            break;
                        }
                    }

                    return isValid;
                });
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (_editContext.VerifyAll() == false)
            {
                return;
            }

            var selectedEmployeeIds = new List<int>();
            var selectedStudentIds = new List<int>();

            foreach (EmployeeItem item in employeesCheckedListBox.CheckedItems)
            {
                selectedEmployeeIds.Add(item.Id);
            }

            foreach (StudentItem item in studentsCheckedListBox.CheckedItems)
            {
                selectedStudentIds.Add(item.Id);
            }

            var eventEntity = new Event()
            {
                Id = _eventId ?? 0,
                Name = nameTextBox.Text,
                ActivityCategoryId = (activityCategoryComboBox.SelectedItem as ActivityCategoryItem).Id,
                ActivityKindId = (activityKindComboBox.SelectedItem as ActivityKindItem).Id,
                Description = descriptionTextBox.Text,
                IsCompleted = false,
                StartDate = startDatePicker.Value,
                ParticipantsAmount = (uint)participantsAmountInput.Value,
                EmployeeIds = selectedEmployeeIds.ToArray(),
                StudentIds = selectedStudentIds.ToArray(),
            };

            if (_eventId is null)
            {
                CreateEvent(eventEntity);
            }
            else
            {
                UpdateEvent(eventEntity);
            }
        }

        private void CreateEvent(Event eventEntity)
        {
            using (var dbContext = new DatabaseContext())
            {
                dbContext.Events.Add(eventEntity);

                dbContext.SaveChanges();
            }

            Close();

            EventsUpdated();
        }

        private void UpdateEvent(Event eventEntity)
        {
            using (var dbContext = new DatabaseContext())
            {
                dbContext.Events.Update(eventEntity);

                dbContext.SaveChanges();
            }

            Close();

            EventsUpdated();
        }

        private class EmployeeItem
        {
            public int Id { get; set; }

            public string FullName { get; set; }

            public override string ToString() => FullName;
        }

        private class StudentItem
        {
            public int Id { get; set; }

            public string FullName { get; set; }

            public override string ToString() => FullName;
        }

        private class ActivityCategoryItem
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public override string ToString() => Name;
        }

        private class ActivityKindItem
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public override string ToString() => Name;
        }
    }
}
