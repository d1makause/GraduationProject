namespace WinFormsApplication.Forms
{
    partial class CreateAcademicLeaveForm
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
            studentsComboBox = new ComboBox();
            studentLabel = new Label();
            phoneLabel = new Label();
            phoneTextBox = new TextBox();
            startTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateLabel = new Label();
            endDatePicker = new DateTimePicker();
            sendButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(484, 35);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Запросить академический отпуск";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // studentsComboBox
            // 
            studentsComboBox.FormattingEnabled = true;
            studentsComboBox.Location = new Point(12, 53);
            studentsComboBox.Name = "studentsComboBox";
            studentsComboBox.Size = new Size(460, 23);
            studentsComboBox.TabIndex = 2;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new Point(12, 35);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(50, 15);
            studentLabel.TabIndex = 3;
            studentLabel.Text = "Студент";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(12, 92);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(123, 15);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Контактный телефон";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(12, 110);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(460, 23);
            phoneTextBox.TabIndex = 6;
            // 
            // startTimePicker
            // 
            startTimePicker.Location = new Point(12, 166);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(460, 23);
            startTimePicker.TabIndex = 7;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(12, 148);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(49, 15);
            startDateLabel.TabIndex = 8;
            startDateLabel.Text = "Начало";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(12, 215);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(41, 15);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "Конец";
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(12, 233);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(460, 23);
            endDatePicker.TabIndex = 9;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(343, 300);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(129, 23);
            sendButton.TabIndex = 11;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // CreateAcademicLeaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 336);
            Controls.Add(sendButton);
            Controls.Add(endDateLabel);
            Controls.Add(endDatePicker);
            Controls.Add(startDateLabel);
            Controls.Add(startTimePicker);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(studentLabel);
            Controls.Add(studentsComboBox);
            Controls.Add(titleLabel);
            MaximumSize = new Size(500, 375);
            MinimumSize = new Size(500, 375);
            Name = "CreateAcademicLeaveForm";
            Text = "Форма запроса академического отпуска";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private ComboBox studentsComboBox;
        private Label studentLabel;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private DateTimePicker startTimePicker;
        private Label startDateLabel;
        private Label endDateLabel;
        private DateTimePicker endDatePicker;
        private Button sendButton;
    }
}