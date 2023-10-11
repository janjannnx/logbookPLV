using logbookPLV.LOGBOOKPLVDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;

namespace logbookPLV
{
    public partial class CapturePreviewForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap capturedImage = null;

        public CapturePreviewForm()
        {
            InitializeComponent();
        }
        public Bitmap CapturedImage
        {
            get { return capturedImage; }
            set { capturedImage = value; }
        }

        private void CapturePreviewForm_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video devices found.");
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (videoSource.IsRunning)
                {
                    Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
                    pictureBox1.Image = frame;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing frame: {ex.Message}");
            }
        }

        private void takePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource.IsRunning)
                {
                    capturedImage = (Bitmap)pictureBox1.Image.Clone();
                    logbook logbookForm = Application.OpenForms.OfType<logbook>().FirstOrDefault();
                    if (logbookForm != null)
                    {
                        logbookForm.CapturedImage = capturedImage;
                    }
                    else
                    {
                        MessageBox.Show("LogbookForm is not open.");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The video source is not running.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing image: {ex.Message}");
            }
        }


    }
}
