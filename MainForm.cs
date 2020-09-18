using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebcamTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoDevice;
        private void MainForm_Load(object sender, EventArgs e)
        {
            FetchVideoDevices();

            if (this.videoDevices.Count == 0)
            {
                this.cameraDropdownList.Items.Clear();
                this.cameraDropdownList.Items.Add("No cameras found. Ensure drivers are installed.");
            }
            else
            {
                this.cameraDropdownList.Items.Clear();
                foreach (FilterInfo device in videoDevices)
                {
                    this.cameraDropdownList.Items.Add(device.Name);
                }
            }
        }

        private void FetchVideoDevices()
        {
            this.cameraDropdownList.Items.Clear();
            this.cameraDropdownList.Items.Add("Fetching cameras...");

            this.videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            this.cameraDropdownList.Items.Clear();
        }

        private void refreshCameraListButton_Click(object sender, EventArgs e)
        {
            FetchVideoDevices();

            if (this.videoDevices.Count == 0)
            {
                this.cameraDropdownList.Items.Clear();
                this.cameraDropdownList.Items.Add("No cameras found. Ensure drivers are installed.");
            }
            else
            {
                this.cameraDropdownList.Items.Clear();
                foreach (FilterInfo device in videoDevices)
                {
                    this.cameraDropdownList.Items.Add(device.Name);
                }
            }
        }

        private void cameraDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.videoDevice = new VideoCaptureDevice(this.videoDevices[this.cameraDropdownList.SelectedIndex].MonikerString);

            if (videoPlayer.IsRunning)
            {
                videoPlayer.Stop();
                videoPlayer.VideoSource = null;
            }

            videoPlayer.VideoSource = this.videoDevice;
            videoPlayer.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoPlayer.IsRunning)
            {
                videoPlayer.Stop();
                videoPlayer.VideoSource = null;
            }
        }
    }
}
