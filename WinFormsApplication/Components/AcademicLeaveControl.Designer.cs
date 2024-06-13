namespace WinFormsApplication.Components
{
    partial class AcademicLeaveControl
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            requestTimeLabel = new Label();
            contactNumberLabel = new Label();
            studentGroupLabel = new Label();
            rejectButton = new Button();
            acceptedCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(17, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(311, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Заявление на академический отпуск от {0}";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(17, 46);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(685, 42);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Прошу предоставить академический отпуск с {0} по {1}";
            // 
            // requestTimeLabel
            // 
            requestTimeLabel.AutoSize = true;
            requestTimeLabel.Location = new Point(17, 133);
            requestTimeLabel.Name = "requestTimeLabel";
            requestTimeLabel.Size = new Size(76, 15);
            requestTimeLabel.TabIndex = 3;
            requestTimeLabel.Text = "Заявка от {0}";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new Point(17, 88);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new Size(188, 15);
            contactNumberLabel.TabIndex = 4;
            contactNumberLabel.Text = "Контактный номер телефона: {0}";
            // 
            // studentGroupLabel
            // 
            studentGroupLabel.AutoSize = true;
            studentGroupLabel.Location = new Point(17, 111);
            studentGroupLabel.Name = "studentGroupLabel";
            studentGroupLabel.Size = new Size(114, 15);
            studentGroupLabel.TabIndex = 5;
            studentGroupLabel.Text = "Студент группы: {0}";
            // 
            // rejectButton
            // 
            rejectButton.Location = new Point(610, 129);
            rejectButton.Name = "rejectButton";
            rejectButton.Size = new Size(92, 23);
            rejectButton.TabIndex = 6;
            rejectButton.Text = "Отозвать";
            rejectButton.UseVisualStyleBackColor = true;
            rejectButton.Click += rejectButton_Click;
            // 
            // acceptedCheckBox
            // 
            acceptedCheckBox.AutoSize = true;
            acceptedCheckBox.Location = new Point(620, 13);
            acceptedCheckBox.Name = "acceptedCheckBox";
            acceptedCheckBox.Size = new Size(82, 19);
            acceptedCheckBox.TabIndex = 7;
            acceptedCheckBox.Text = "Одобрено";
            acceptedCheckBox.UseVisualStyleBackColor = true;
            acceptedCheckBox.CheckedChanged += acceptedCheckBox_CheckedChanged;
            // 
            // AcademicLeaveControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(acceptedCheckBox);
            Controls.Add(rejectButton);
            Controls.Add(studentGroupLabel);
            Controls.Add(contactNumberLabel);
            Controls.Add(requestTimeLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Name = "AcademicLeaveControl";
            Size = new Size(715, 165);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Label requestTimeLabel;
        private Label contactNumberLabel;
        private Label studentGroupLabel;
        private Button rejectButton;
        private CheckBox acceptedCheckBox;
    }
}
