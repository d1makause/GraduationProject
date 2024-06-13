namespace WinFormsApplication.Forms
{
    partial class AcademicLeavesForm
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
            academicLeaveContainer = new FlowLayoutPanel();
            addButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(747, 35);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Академические отпуска";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // academicLeaveContainer
            // 
            academicLeaveContainer.AutoScroll = true;
            academicLeaveContainer.Dock = DockStyle.Fill;
            academicLeaveContainer.Location = new Point(0, 35);
            academicLeaveContainer.Name = "academicLeaveContainer";
            academicLeaveContainer.Padding = new Padding(5);
            academicLeaveContainer.Size = new Size(747, 415);
            academicLeaveContainer.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 7);
            addButton.Name = "addButton";
            addButton.Size = new Size(91, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AcademicLeavesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(addButton);
            Controls.Add(academicLeaveContainer);
            Controls.Add(titleLabel);
            MaximumSize = new Size(763, 489);
            MinimumSize = new Size(763, 489);
            Name = "AcademicLeavesForm";
            Text = "Академические отпуска";
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private FlowLayoutPanel academicLeaveContainer;
        private Button addButton;
    }
}