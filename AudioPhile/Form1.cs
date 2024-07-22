using AudioPhile.Custom_Components;
using AudioPhile.Props;
using AudioPhile.Singleton;
using Guna.UI2.WinForms;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.IFD.Tags;

namespace AudioPhile
{
    public partial class music : Form
    {
        public static Guna2CircleButton PlayPauseButton { get; private set; }

        public static bool isPlaying;
        private bool isStopped = false;
        public music()
        {
            InitializeComponent();
            LoadAllMusic();
            PlayPauseButton = playPauseBtn;
        }
        private void ResetDirectories()
        {
          
            Properties.Settings.Default.SongDirectories = string.Empty;
            Properties.Settings.Default.Save();

            MessageBox.Show("All directories have been cleared.");
        }

        private MusicMetaData GetSelectedMusicData()
        {
            return new MusicMetaData
            {
                SongTitle = PlaybackManager.CurrentMusicMetaData.SongTitle,
                SongArtist = PlaybackManager.CurrentMusicMetaData.SongArtist,
                AlbumArt = PlaybackManager.CurrentMusicMetaData.AlbumArt,
                AudioFilePath = PlaybackManager.CurrentMusicMetaData.AudioFilePath,
            };
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) {
              
                this.WindowState &= FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
           
        }

        public static void onPlay(bool play)
        {
            
            if (play == true)
            {
           
                PlayPauseButton.Image = Properties.Resources.pause;
            }

            if (play == false)
            {
                PlayPauseButton.Image = Properties.Resources.play;
            }
        }
        private void playPauseBtn_Click_1(object sender, EventArgs e)
        {
           
            if (isPlaying)
            {
               
                playPauseBtn.Image = Properties.Resources.play;
                PlaybackManager.Pause();
                isPlaying = false;
                MessageBox.Show($"Is playing?: {isPlaying}");
            }
            else
            {
                
                playPauseBtn.Image = Properties.Resources.pause;
                PlaybackManager.Resume();
                isPlaying = true;
                MessageBox.Show($"Is playing?: {isPlaying}");
            }

            //if (isStopped)
            //{
            //    PlaybackManager.Play();
            //    isStopped = false;
            //}
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pageTabControl.SelectedIndex = 0;
            NowPlaying();
        }

        private void btnMusicList_Click(object sender, EventArgs e)
        {
            pageTabControl.SelectedIndex = 1;
            
            LoadAllMusic();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            PlaybackManager.changeVolume(0);
            volumeController.Value = 0;
        }

        private async void LoadAllMusic()
        {
            string directories = Properties.Settings.Default.SongDirectories;

            if (!string.IsNullOrWhiteSpace(directories))
            {
                string[] directoryList = directories.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                List<MusicMetaData> musicData = await Task.Run(() =>
                {
                    List<MusicMetaData> data = new List<MusicMetaData>();

                    foreach (string directory in directoryList)
                    {
                        string trimmedDirectory = directory.Trim();

                        if (Directory.Exists(trimmedDirectory))
                        {
                            string[] files = Directory.GetFiles(trimmedDirectory, "*.*", SearchOption.AllDirectories)
                                .Where(file => file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase)
                                             || file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase)
                                             || file.EndsWith(".aac", StringComparison.OrdinalIgnoreCase))
                                .ToArray();

                            foreach (string file in files)
                            {
                                MusicMetaData metadata = new MusicMetaData();
                                data.Add(metadata.GetMusicMetaData(file));
                                Console.WriteLine(file);
                            }
                        }
                    }

                    return data;
                });

                this.Invoke((Action)(() =>
                {
                    musicListPanel.Controls.Clear();

                    foreach (var item in musicData)
                    {
                        var musicMetaData = new MusicMetaData
                        {
                            SongTitle = item.SongTitle,
                            SongArtist = item.SongArtist,
                            AlbumArt = item.AlbumArt,
                            AudioFilePath = item.AudioFilePath
                        };

                        MusicListTile musicListTile = new MusicListTile(musicMetaData);
                        musicListTile.Anchor = AnchorStyles.Right;
                        musicListPanel.Controls.Add(musicListTile);
                    }

                    musicListPanel.PerformLayout();
                    musicListPanel.Invalidate();
                    musicListPanel.Update();

                    lblSongCount.Text = $"{musicData.Count} Songs";
                }));
            }
            else
            {
                MessageBox.Show("No directories configured.");
            }
        }

        public void NowPlaying()
        {
            try
            {
                if (
                      PlaybackManager.CurrentMusicMetaData == null 
                    ||PlaybackManager.CurrentMusicMetaData.SongTitle == null
                    || PlaybackManager.CurrentMusicMetaData.SongArtist == null 
                    || PlaybackManager.CurrentMusicMetaData.AlbumArt == null)
                {
                    lblSongTitle.Text = "Song Title";
                    lblSinger.Text = "Song Artist";
                    audioAlbumArt.Image = Properties.Resources.pexels_cytonn_955402;
                    return;
                }
              
                    lblSongTitle.Text = PlaybackManager.CurrentMusicMetaData.SongTitle;
                    lblSinger.Text = PlaybackManager.CurrentMusicMetaData.SongArtist;
                    audioAlbumArt.Image = PlaybackManager.CurrentMusicMetaData.AlbumArt;

               
            }
            catch (Exception ex) {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSongDirectory_Click(object sender, EventArgs e)
        {

            using (CustomAlertForm alertBox = new CustomAlertForm()) {

                DialogResult result = alertBox.ShowDialog();
            }
            
        }

        private void btnResetDirectory_Click(object sender, EventArgs e)
        {
            ResetDirectories();
            musicListPanel.Controls.Clear();
        }

        private void btnScanSongs_Click(object sender, EventArgs e)
        {
            LoadAllMusic();
        }

        private void volumeController_Scroll(object sender, ScrollEventArgs e)
        {
            PlaybackManager.changeVolume(volumeController.Value);
            Console.WriteLine(volumeController.Value);
        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            var currentTimeStampPosition = PlaybackManager.CurrentPosition;
            var songDuration = PlaybackManager.Duration;

            lblElapsedTime.Text = FormatTime(currentTimeStampPosition);
            lblDuration.Text = FormatTime(songDuration);

            
            int maxTimeInSeconds = (int)songDuration.TotalSeconds;
            
            if(maxTimeInSeconds > 0)
            {
               
                playerTrackBar.Maximum = maxTimeInSeconds;

                int currentPositionInSeconds = (int)currentTimeStampPosition.TotalSeconds;
                playerTrackBar.Value = Math.Min(currentPositionInSeconds, playerTrackBar.Maximum);
            }
            
            
        }

        private string FormatTime(TimeSpan time)
        {
            return $"{time.Minutes}:{time.Seconds}";
        }

        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                PlaybackManager.Stop();
                playerTrackBar.Value = 0;
                isStopped = true;
                isPlaying = false;
                return;
            }
        }
    }
}
