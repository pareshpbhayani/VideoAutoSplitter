namespace VideoAutoSplitter
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            btnBrowse = new Button();
            txtFilePath = new TextBox();
            progressBar = new ProgressBar();
            txtSeconds = new TextBox();
            label1 = new Label();
            btnSplitVideo = new Button();
            txtOutputFolder = new TextBox();
            txtDuration = new TextBox();
            label2 = new Label();
            txtCompleted = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(199, 47);
            btnBrowse.Margin = new Padding(0, 6, 0, 6);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(88, 32);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse File";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Enabled = false;
            txtFilePath.Location = new Point(12, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(462, 26);
            txtFilePath.TabIndex = 1;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 161);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(462, 23);
            progressBar.TabIndex = 2;
            // 
            // txtSeconds
            // 
            txtSeconds.Location = new Point(107, 129);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(57, 26);
            txtSeconds.TabIndex = 3;
            txtSeconds.Text = "10";
            txtSeconds.TextAlign = HorizontalAlignment.Center;
            txtSeconds.TextChanged += txtSeconds_TextChanged;
            txtSeconds.KeyPress += txtSeconds_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 4;
            label1.Text = "Split Seconds";
            // 
            // btnSplitVideo
            // 
            btnSplitVideo.Location = new Point(199, 123);
            btnSplitVideo.Margin = new Padding(0, 6, 0, 6);
            btnSplitVideo.Name = "btnSplitVideo";
            btnSplitVideo.Size = new Size(88, 32);
            btnSplitVideo.TabIndex = 0;
            btnSplitVideo.Text = "Split Video";
            btnSplitVideo.UseVisualStyleBackColor = true;
            btnSplitVideo.Click += btnSplitVideo_Click;
            // 
            // txtOutputFolder
            // 
            txtOutputFolder.Enabled = false;
            txtOutputFolder.Location = new Point(12, 88);
            txtOutputFolder.Name = "txtOutputFolder";
            txtOutputFolder.Size = new Size(462, 26);
            txtOutputFolder.TabIndex = 1;
            // 
            // txtDuration
            // 
            txtDuration.Enabled = false;
            txtDuration.Location = new Point(417, 44);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(57, 26);
            txtDuration.TabIndex = 3;
            txtDuration.Text = "0";
            txtDuration.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 47);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 4;
            label2.Text = "Duration";
            // 
            // txtCompleted
            // 
            txtCompleted.Enabled = false;
            txtCompleted.Location = new Point(335, 132);
            txtCompleted.Name = "txtCompleted";
            txtCompleted.Size = new Size(57, 26);
            txtCompleted.TabIndex = 3;
            txtCompleted.Text = "-";
            txtCompleted.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 135);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 4;
            label3.Text = "Completed";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 193);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCompleted);
            Controls.Add(txtDuration);
            Controls.Add(txtSeconds);
            Controls.Add(progressBar);
            Controls.Add(txtOutputFolder);
            Controls.Add(txtFilePath);
            Controls.Add(btnSplitVideo);
            Controls.Add(btnBrowse);
            Font = new Font("Segoe UI", 10.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(0, 6, 0, 6);
            Name = "FrmHome";
            Text = "Video Auto Splitter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private TextBox txtFilePath;
        private ProgressBar progressBar;
        private TextBox txtSeconds;
        private Label label1;
        private Button btnSplitVideo;
        private TextBox txtOutputFolder;
        private TextBox txtDuration;
        private Label label2;
        private TextBox txtCompleted;
        private Label label3;
    }
}
