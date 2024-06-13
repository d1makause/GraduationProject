namespace WinFormsApplication
{
    partial class EventsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            eventsContainer = new FlowLayoutPanel();
            createButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(747, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Мероприятия";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eventsContainer
            // 
            eventsContainer.AutoScroll = true;
            eventsContainer.Dock = DockStyle.Fill;
            eventsContainer.FlowDirection = FlowDirection.TopDown;
            eventsContainer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            eventsContainer.Location = new Point(0, 35);
            eventsContainer.Margin = new Padding(15);
            eventsContainer.Name = "eventsContainer";
            eventsContainer.Padding = new Padding(15);
            eventsContainer.Size = new Size(747, 415);
            eventsContainer.TabIndex = 1;
            eventsContainer.WrapContents = false;
            eventsContainer.SizeChanged += eventsContainer_SizeChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 6);
            createButton.Name = "createButton";
            createButton.Size = new Size(85, 23);
            createButton.TabIndex = 0;
            createButton.Text = "Добавить";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(createButton);
            Controls.Add(eventsContainer);
            Controls.Add(titleLabel);
            MinimumSize = new Size(763, 489);
            Name = "EventsForm";
            Text = "Управление мероприятиями";
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private FlowLayoutPanel eventsContainer;
        private Button createButton;
    }
}
