using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Printing;

namespace AudioPhile.Custom_Components
{
    public partial class CustomAlertForm : Form
    {
        public CustomAlertForm()
        {
            InitializeComponent();
        }

        private void btnSongSelect_Click(object sender, EventArgs e)
        {
        

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "Audio files (*.mp3;*.wav;*.aac)|*.mp3;*.wav;*.aac|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                    MessageBox.Show($"Selected audio file: {filePath}");
                        Close();
                    }
                }

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            string directories = Properties.Settings.Default.SongDirectories;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    MessageBox.Show($"Selected folder: {folderPath}");
                    if (!string.IsNullOrWhiteSpace(folderPath))
                    {
                        string[] directoryList = directories.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        List<string> updateDirectory = new List<string>(directoryList);


                        if (!updateDirectory.Contains(folderPath.Trim()))
                        {
                            updateDirectory.Add(folderPath.Trim());
                        }



                        SaveSettings(updateDirectory);


                        foreach (var directory in directoryList)
                        {
                            
                            MessageBox.Show($"Directory: {directory.Trim()}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Directories");
                    }
                    Close();
                }
            }
        }

        private  void SaveSettings(List<string> updatedDirectories)
        {
            Properties.Settings.Default.SongDirectories = string.Join(",", updatedDirectories);
            Properties.Settings.Default.Save();
        }
    }
}
