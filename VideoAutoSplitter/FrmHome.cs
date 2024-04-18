using MediaToolkit.Model;
using MediaToolkit.Options;
using MediaToolkit;
using System.Drawing.Imaging;
using Xabe.FFmpeg;
using System.Resources;
using Microsoft.VisualBasic;

namespace VideoAutoSplitter
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private const string _messageBoxTitle = "Video Auto Splitter";

        double duration = 0;

        private async void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "mp4 files (*.mp4)|*.mp4|flv files (*.flv)|*.flv|avi files (*.avi)|*.avi" })
            {
                dialog.ShowDialog();
                txtFilePath.Text = dialog.FileName;

                if (!string.IsNullOrEmpty(txtFilePath.Text))
                {
                    if (File.Exists(txtFilePath.Text))
                    {
                        txtOutputFolder.Text = Path.GetDirectoryName(dialog.FileName) + "\\_splited";
                        btnSplitVideo.BeginInvoke(() =>
                        {
                            btnSplitVideo.Enabled = false;
                        });
                        IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(txtFilePath.Text);
                        duration = mediaInfo.Duration.Seconds;
                        txtDuration.Text = duration.ToString();
                        btnSplitVideo.BeginInvoke(() =>
                        {
                            btnSplitVideo.Enabled = true;
                        });
                        txtSeconds_TextChanged(null, null);
                    }
                    else
                    {
                        txtFilePath.Text = string.Empty;
                        txtOutputFolder.Text = string.Empty;
                        MessageBox.Show("File does not exists!", _messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private async void btnSplitVideo_Click(object sender, EventArgs e)
        {
            if (IsValidData(out double seconds))
            {
                await SpliteVideo(seconds);
            }
        }

        private bool IsValidData(out double seconds)
        {
            var flag = double.TryParse(txtSeconds.Text, out seconds);
            if (!flag)
            {
                MessageBox.Show("Enter valid seconds!", _messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        private async Task SpliteVideo(double seconds)
        {
            var applicationPath = GetApplicationPath();
            //copy and past ffmpeg folder in application directory\Libs
            FFmpeg.SetExecutablesPath(applicationPath + @"\Libs\ffmpeg\bin");

            btnSplitVideo.BeginInvoke(() =>
            {
                btnSplitVideo.Text = "Wait";
                btnSplitVideo.Enabled = false;
            });
            var ffmpeg = FFmpeg.Conversions.New();
            var splitterCounter = Math.Ceiling(duration / seconds);
            double secondsCounter = 0;

            for (int i = 1; i <= splitterCounter; i++)
            {
                IConversion conversion = await FFmpeg.Conversions.FromSnippet.Split(txtFilePath.Text, $"{txtOutputFolder.Text}\\{i}.mp4", TimeSpan.FromSeconds(secondsCounter), TimeSpan.FromSeconds(seconds));
                await conversion.Start();
                secondsCounter += seconds;
                int percentage;
                if (secondsCounter >= duration)
                {
                    percentage = 100;
                }
                else
                {
                    percentage = (int)((secondsCounter * 100) / duration);
                }

                progressBar.BeginInvoke(() =>
                {
                    progressBar.Value = percentage;
                });
                txtCompleted.BeginInvoke(() =>
                {
                    txtCompleted.Text = $"{splitterCounter}/{i - 1}";
                });
            }
            btnSplitVideo.BeginInvoke(() =>
            {
                btnSplitVideo.Text = "Split Video";
                btnSplitVideo.Enabled = true;
            });
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {
            if (IsValidData(out double seconds))
            {
                var splitterCounter = Math.Ceiling(duration / seconds);
                txtCompleted.Text = $"{splitterCounter}/0";
            }
        }

        public static string GetApplicationPath()
        {
            string currentDir = Directory.GetCurrentDirectory();

            if (currentDir.ToLower().EndsWith(@"\bin\debug") || currentDir.ToLower().EndsWith(@"\bin\release"))
            {
                return Path.GetFullPath(@"..\..\");
            }
            return Path.GetDirectoryName(Application.ExecutablePath) + "\\";
        }

        private void txtSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
