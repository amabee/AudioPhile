using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioPhile.Props;
using AudioPhile.Singleton;
using NAudio.Wave;

namespace AudioPhile.Custom_Components
{
    public partial class MusicListTile : UserControl
    {
        private string _audioFilePath;
        private IWavePlayer _wavePlayer;
        private AudioFileReader _audioFileReader;

        private MusicMetaData _musicMetaData;

        public MusicListTile(MusicMetaData musicMetaData)
        {
            InitializeComponent();

            lblSongTitle.Text = musicMetaData.SongTitle;
            lblSinger.Text = musicMetaData.SongArtist;
            songImage.Image = musicMetaData.AlbumArt;
            _audioFilePath = musicMetaData.AudioFilePath;
            _musicMetaData = musicMetaData;
        }

        private void lblSongTitle_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lblSongTitle_Click(object sender, EventArgs e)
        {
            PlayAudio();
            music.isPlaying = true;
            
        }

        private void PlayAudio()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_audioFilePath))
                {
                    MessageBox.Show($"Invalid music name or file path{_audioFilePath}");
                   
                    return;
                }

                PlaybackManager.Play(_musicMetaData);
            }
            catch (Exception ex) {

                MessageBox.Show($"An error occurred while playing the audio: {ex.Message}");
                Console.WriteLine($"An error occurred while playing the audio: {ex.Message}");
            }
        }
    }
}
