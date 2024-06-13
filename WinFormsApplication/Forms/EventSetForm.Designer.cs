namespace WinFormsApplication.Forms
{
    partial class EventSetForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            activityKindLabel = new Label();
            activityKindComboBox = new ComboBox();
            activityCategoryComboBox = new ComboBox();
            activityCategoryLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            participantsAmountLabel = new Label();
            participantsAmountInput = new NumericUpDown();
            startDateLabel = new Label();
            startDatePicker = new DateTimePicker();
            studentsLabel = new Label();
            studentsCheckedListBox = new CheckedListBox();
            employeesCheckedListBox = new CheckedListBox();
            employeesLabel = new Label();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)participantsAmountInput).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(454, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Обновление мероприятия";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activityKindLabel
            // 
            activityKindLabel.AutoSize = true;
            activityKindLabel.Location = new Point(12, 92);
            activityKindLabel.Name = "activityKindLabel";
            activityKindLabel.Size = new Size(104, 15);
            activityKindLabel.TabIndex = 1;
            activityKindLabel.Text = "Вид деятельности";
            // 
            // activityKindComboBox
            // 
            activityKindComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            activityKindComboBox.FormattingEnabled = true;
            activityKindComboBox.Location = new Point(12, 110);
            activityKindComboBox.Name = "activityKindComboBox";
            activityKindComboBox.Size = new Size(430, 23);
            activityKindComboBox.TabIndex = 2;
            // 
            // activityCategoryComboBox
            // 
            activityCategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            activityCategoryComboBox.FormattingEnabled = true;
            activityCategoryComboBox.Location = new Point(12, 169);
            activityCategoryComboBox.Name = "activityCategoryComboBox";
            activityCategoryComboBox.Size = new Size(430, 23);
            activityCategoryComboBox.TabIndex = 4;
            // 
            // activityCategoryLabel
            // 
            activityCategoryLabel.AutoSize = true;
            activityCategoryLabel.Location = new Point(12, 151);
            activityCategoryLabel.Name = "activityCategoryLabel";
            activityCategoryLabel.Size = new Size(140, 15);
            activityCategoryLabel.TabIndex = 3;
            activityCategoryLabel.Text = "Категория деятельности";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 53);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(430, 23);
            nameTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(12, 223);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(430, 84);
            descriptionTextBox.TabIndex = 8;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 205);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(62, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Описание";
            // 
            // participantsAmountLabel
            // 
            participantsAmountLabel.AutoSize = true;
            participantsAmountLabel.Location = new Point(15, 322);
            participantsAmountLabel.Name = "participantsAmountLabel";
            participantsAmountLabel.Size = new Size(138, 15);
            participantsAmountLabel.TabIndex = 9;
            participantsAmountLabel.Text = "Количество участников";
            // 
            // participantsAmountInput
            // 
            participantsAmountInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            participantsAmountInput.Location = new Point(12, 340);
            participantsAmountInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            participantsAmountInput.Name = "participantsAmountInput";
            participantsAmountInput.Size = new Size(430, 23);
            participantsAmountInput.TabIndex = 10;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(15, 379);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(49, 15);
            startDateLabel.TabIndex = 11;
            startDateLabel.Text = "Начало";
            // 
            // startDatePicker
            // 
            startDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            startDatePicker.CustomFormat = "MM/dd/yy HH:mm:ss";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(12, 397);
            startDatePicker.MaxDate = new DateTime(2199, 12, 31, 0, 0, 0, 0);
            startDatePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(430, 23);
            startDatePicker.TabIndex = 12;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Location = new Point(15, 439);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new Size(143, 15);
            studentsLabel.TabIndex = 13;
            studentsLabel.Text = "Учавствующие студенты";
            // 
            // studentsCheckedListBox
            // 
            studentsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            studentsCheckedListBox.CheckOnClick = true;
            studentsCheckedListBox.FormattingEnabled = true;
            studentsCheckedListBox.Location = new Point(12, 460);
            studentsCheckedListBox.Name = "studentsCheckedListBox";
            studentsCheckedListBox.Size = new Size(430, 94);
            studentsCheckedListBox.TabIndex = 14;
            // 
            // employeesCheckedListBox
            // 
            employeesCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            employeesCheckedListBox.CheckOnClick = true;
            employeesCheckedListBox.FormattingEnabled = true;
            employeesCheckedListBox.Location = new Point(12, 593);
            employeesCheckedListBox.Name = "employeesCheckedListBox";
            employeesCheckedListBox.Size = new Size(430, 94);
            employeesCheckedListBox.TabIndex = 16;
            // 
            // employeesLabel
            // 
            employeesLabel.AutoSize = true;
            employeesLabel.Location = new Point(15, 571);
            employeesLabel.Name = "employeesLabel";
            employeesLabel.Size = new Size(176, 15);
            employeesLabel.TabIndex = 15;
            employeesLabel.Text = "Учавствующие преподаватели";
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitButton.Location = new Point(302, 703);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(140, 23);
            submitButton.TabIndex = 17;
            submitButton.Text = "Отправить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // EventSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 738);
            Controls.Add(submitButton);
            Controls.Add(employeesCheckedListBox);
            Controls.Add(employeesLabel);
            Controls.Add(studentsCheckedListBox);
            Controls.Add(studentsLabel);
            Controls.Add(startDatePicker);
            Controls.Add(startDateLabel);
            Controls.Add(participantsAmountInput);
            Controls.Add(participantsAmountLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(activityCategoryComboBox);
            Controls.Add(activityCategoryLabel);
            Controls.Add(activityKindComboBox);
            Controls.Add(activityKindLabel);
            Controls.Add(titleLabel);
            Name = "EventSetForm";
            Text = "Обновление мероприятия";
            ((System.ComponentModel.ISupportInitialize)participantsAmountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label activityKindLabel;
        private ComboBox activityKindComboBox;
        private ComboBox activityCategoryComboBox;
        private Label activityCategoryLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label participantsAmountLabel;
        private NumericUpDown participantsAmountInput;
        private Label startDateLabel;
        private DateTimePicker startDatePicker;
        private Label studentsLabel;
        private CheckedListBox studentsCheckedListBox;
        private CheckedListBox employeesCheckedListBox;
        private Label employeesLabel;
        private Button submitButton;
    }
}