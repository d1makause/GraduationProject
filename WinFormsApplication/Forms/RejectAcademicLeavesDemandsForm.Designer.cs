namespace WinFormsApplication.Forms
{
    partial class RejectAcademicLeavesDemandsForm
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
            rejectAcademicLeaveDemandContainer = new FlowLayoutPanel();
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
            titleLabel.Text = "Заявки на отказ от академического отпуска";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rejectAcademicLeaveDemandContainer
            // 
            rejectAcademicLeaveDemandContainer.AutoScroll = true;
            rejectAcademicLeaveDemandContainer.Dock = DockStyle.Fill;
            rejectAcademicLeaveDemandContainer.Location = new Point(0, 35);
            rejectAcademicLeaveDemandContainer.Name = "rejectAcademicLeaveDemandContainer";
            rejectAcademicLeaveDemandContainer.Padding = new Padding(5);
            rejectAcademicLeaveDemandContainer.Size = new Size(747, 415);
            rejectAcademicLeaveDemandContainer.TabIndex = 2;
            // 
            // RejectAcademicLeavesDemandsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(rejectAcademicLeaveDemandContainer);
            Controls.Add(titleLabel);
            MaximumSize = new Size(763, 489);
            MinimumSize = new Size(763, 489);
            Name = "RejectAcademicLeavesDemandsForm";
            Text = "Заявки на отказ от академического отпуска";
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private FlowLayoutPanel rejectAcademicLeaveDemandContainer;
    }
}