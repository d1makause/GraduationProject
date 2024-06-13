using Database;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Components;
using WinFormsApplication.Forms;

namespace WinFormsApplication
{
    public partial class EventsForm : Form
    {
        private int _containerWidth;
        private const int SCROLLBAR_WIDTH = 25 + 30;

        public EventsForm()
        {
            InitializeComponent();

            _containerWidth = eventsContainer.Width;

            FillData();
        }

        private void FillData()
        {
            eventsContainer.Controls.Clear();

            using var dbContext = new DatabaseContext();

            var employees = dbContext.Employees.ToArray();
            var students = dbContext.Students.ToArray();

            foreach (var eventEntity in dbContext.Events
                .Include(x => x.ActivityKind)
                .Include(x => x.ActivityCategory))
            {
                var eventControl = new EventsControl(eventEntity, employees, students);

                eventControl.EntityRemoved += FillData;
                eventControl.EntityUpdated += FillData;

                eventControl.Width = _containerWidth - SCROLLBAR_WIDTH;

                eventsContainer.Controls.Add(eventControl);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createEventForm = new EventSetForm();

            createEventForm.EventsUpdated += FillData;

            createEventForm.Show();
        }

        private void eventsContainer_SizeChanged(object sender, EventArgs e)
        {
            if (_containerWidth == eventsContainer.Width)
            {
                return;
            }

            _containerWidth = eventsContainer.Width;

            foreach (Control eventControl in eventsContainer.Controls)
            {
                eventControl.Width = _containerWidth - SCROLLBAR_WIDTH;
            }
        }
    }
}
