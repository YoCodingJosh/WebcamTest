namespace WebcamTest
{
    partial class MainForm
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
            this.cameraDropdownList = new System.Windows.Forms.ComboBox();
            this.cameraDropdownLabel = new System.Windows.Forms.Label();
            this.refreshCameraListButton = new System.Windows.Forms.Button();
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.SuspendLayout();
            // 
            // cameraDropdownList
            // 
            this.cameraDropdownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraDropdownList.FormattingEnabled = true;
            this.cameraDropdownList.Location = new System.Drawing.Point(64, 12);
            this.cameraDropdownList.Name = "cameraDropdownList";
            this.cameraDropdownList.Size = new System.Drawing.Size(238, 21);
            this.cameraDropdownList.TabIndex = 0;
            this.cameraDropdownList.SelectedIndexChanged += new System.EventHandler(this.cameraDropdownList_SelectedIndexChanged);
            // 
            // cameraDropdownLabel
            // 
            this.cameraDropdownLabel.AutoSize = true;
            this.cameraDropdownLabel.Location = new System.Drawing.Point(12, 15);
            this.cameraDropdownLabel.Name = "cameraDropdownLabel";
            this.cameraDropdownLabel.Size = new System.Drawing.Size(46, 13);
            this.cameraDropdownLabel.TabIndex = 1;
            this.cameraDropdownLabel.Text = "Camera:";
            // 
            // refreshCameraListButton
            // 
            this.refreshCameraListButton.Image = global::WebcamTest.Properties.Resources.Refresh_16x;
            this.refreshCameraListButton.Location = new System.Drawing.Point(308, 10);
            this.refreshCameraListButton.Name = "refreshCameraListButton";
            this.refreshCameraListButton.Size = new System.Drawing.Size(29, 23);
            this.refreshCameraListButton.TabIndex = 3;
            this.refreshCameraListButton.UseVisualStyleBackColor = true;
            this.refreshCameraListButton.Click += new System.EventHandler(this.refreshCameraListButton_Click);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Location = new System.Drawing.Point(0, 46);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(640, 480);
            this.videoPlayer.TabIndex = 1000;
            this.videoPlayer.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 528);
            this.Controls.Add(this.refreshCameraListButton);
            this.Controls.Add(this.cameraDropdownLabel);
            this.Controls.Add(this.cameraDropdownList);
            this.Controls.Add(this.videoPlayer);
            this.Name = "MainForm";
            this.Text = "DigitalMagic Webcam Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cameraDropdownList;
        private System.Windows.Forms.Label cameraDropdownLabel;
        private System.Windows.Forms.Button refreshCameraListButton;
        private AForge.Controls.VideoSourcePlayer videoPlayer;
    }
}

