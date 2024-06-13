namespace WinFormsApplication.Forms
{
    partial class HomeForm
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
            eventsButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            academicLeaveButton = new Button();
            rejectAcademicLeaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(800, 35);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "ПО управления колледжом \"Mamat Kunem\"";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eventsButton
            // 
            eventsButton.Location = new Point(12, 415);
            eventsButton.Name = "eventsButton";
            eventsButton.Size = new Size(118, 23);
            eventsButton.TabIndex = 2;
            eventsButton.Text = "Мероприятия";
            eventsButton.UseVisualStyleBackColor = true;
            eventsButton.Click += eventsButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Volgogradskij_kolledzh_upravleniya_i_novyh_tehnologij_imeni_YUriya_Gagarina;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 371);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.колледж_Лого_с_изменениями_2022_1;
            pictureBox3.Location = new Point(12, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // academicLeaveButton
            // 
            academicLeaveButton.Location = new Point(136, 415);
            academicLeaveButton.Name = "academicLeaveButton";
            academicLeaveButton.Size = new Size(145, 23);
            academicLeaveButton.TabIndex = 5;
            academicLeaveButton.Text = "Заявки на академ";
            academicLeaveButton.UseVisualStyleBackColor = true;
            academicLeaveButton.Click += academicLeaveButton_Click;
            // 
            // rejectAcademicLeaveButton
            // 
            rejectAcademicLeaveButton.Location = new Point(287, 415);
            rejectAcademicLeaveButton.Name = "rejectAcademicLeaveButton";
            rejectAcademicLeaveButton.Size = new Size(145, 23);
            rejectAcademicLeaveButton.TabIndex = 6;
            rejectAcademicLeaveButton.Text = "Отказы от академа";
            rejectAcademicLeaveButton.UseVisualStyleBackColor = true;
            rejectAcademicLeaveButton.Click += rejectAcademicLeaveButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rejectAcademicLeaveButton);
            Controls.Add(academicLeaveButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(eventsButton);
            Controls.Add(titleLabel);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "HomeForm";
            Text = "Домашняя страница";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Button eventsButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button academicLeaveButton;
        private Button rejectAcademicLeaveButton;
    }
}