namespace WinFormsApplication.Components
{
    partial class EventsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            participantsAmountLabel = new Label();
            descriptionLabel = new Label();
            startDateLabel = new Label();
            isCompletedCheckbox = new CheckBox();
            employeesLabel = new Label();
            activityKindLabel = new Label();
            activityCategoryLabel = new Label();
            editButton = new Button();
            removeButton = new Button();
            studentsLabel = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(17, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Название";
            // 
            // participantsAmountLabel
            // 
            participantsAmountLabel.AutoSize = true;
            participantsAmountLabel.ForeColor = Color.FromArgb(16, 16, 16);
            participantsAmountLabel.Location = new Point(20, 40);
            participantsAmountLabel.Name = "participantsAmountLabel";
            participantsAmountLabel.Size = new Size(158, 15);
            participantsAmountLabel.TabIndex = 1;
            participantsAmountLabel.Text = "Количество участников: {0}";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.ForeColor = Color.FromArgb(16, 16, 16);
            descriptionLabel.Location = new Point(20, 197);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(569, 74);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Описание: {0}";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.ForeColor = Color.FromArgb(16, 16, 16);
            startDateLabel.Location = new Point(20, 63);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(69, 15);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "Начало: {0}";
            // 
            // isCompletedCheckbox
            // 
            isCompletedCheckbox.AutoSize = true;
            isCompletedCheckbox.ForeColor = Color.FromArgb(16, 16, 16);
            isCompletedCheckbox.Location = new Point(19, 84);
            isCompletedCheckbox.Name = "isCompletedCheckbox";
            isCompletedCheckbox.RightToLeft = RightToLeft.Yes;
            isCompletedCheckbox.Size = new Size(89, 19);
            isCompletedCheckbox.TabIndex = 4;
            isCompletedCheckbox.Text = "Завершено";
            isCompletedCheckbox.UseVisualStyleBackColor = true;
            isCompletedCheckbox.CheckedChanged += isCompletedCheckbox_CheckedChanged;
            // 
            // employeesLabel
            // 
            employeesLabel.AutoSize = true;
            employeesLabel.ForeColor = Color.FromArgb(16, 16, 16);
            employeesLabel.Location = new Point(20, 130);
            employeesLabel.Name = "employeesLabel";
            employeesLabel.Size = new Size(196, 15);
            employeesLabel.TabIndex = 7;
            employeesLabel.Text = "Учавствующие преподаватели: {0}";
            // 
            // activityKindLabel
            // 
            activityKindLabel.AutoSize = true;
            activityKindLabel.ForeColor = Color.FromArgb(16, 16, 16);
            activityKindLabel.Location = new Point(20, 152);
            activityKindLabel.Name = "activityKindLabel";
            activityKindLabel.Size = new Size(124, 15);
            activityKindLabel.TabIndex = 8;
            activityKindLabel.Text = "Вид деятельности: {0}";
            // 
            // activityCategoryLabel
            // 
            activityCategoryLabel.AutoSize = true;
            activityCategoryLabel.ForeColor = Color.FromArgb(16, 16, 16);
            activityCategoryLabel.Location = new Point(20, 175);
            activityCategoryLabel.Name = "activityCategoryLabel";
            activityCategoryLabel.Size = new Size(160, 15);
            activityCategoryLabel.TabIndex = 9;
            activityCategoryLabel.Text = "Категория деятельности: {0}";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.Location = new Point(463, 282);
            editButton.Name = "editButton";
            editButton.Size = new Size(126, 23);
            editButton.TabIndex = 10;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeButton.Location = new Point(340, 282);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(117, 23);
            removeButton.TabIndex = 11;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.ForeColor = Color.FromArgb(16, 16, 16);
            studentsLabel.Location = new Point(20, 106);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(163, 15);
            studentsLabel.TabIndex = 6;
            studentsLabel.Text = "Учавствующие студенты: {0}";
            // 
            // EventsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(removeButton);
            Controls.Add(editButton);
            Controls.Add(activityCategoryLabel);
            Controls.Add(activityKindLabel);
            Controls.Add(employeesLabel);
            Controls.Add(studentsLabel);
            Controls.Add(isCompletedCheckbox);
            Controls.Add(startDateLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(participantsAmountLabel);
            Controls.Add(nameLabel);
            Name = "EventsControl";
            Size = new Size(609, 322);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label participantsAmountLabel;
        private Label descriptionLabel;
        private Label startDateLabel;
        private CheckBox isCompletedCheckbox;
        private Label employeesLabel;
        private Label activityKindLabel;
        private Label activityCategoryLabel;
        private Button editButton;
        private Button removeButton;
        private Label studentsLabel;
    }
}
