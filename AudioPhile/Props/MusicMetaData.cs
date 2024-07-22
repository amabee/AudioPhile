using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TagLib;
using System.Windows.Forms;

namespace AudioPhile.Props
{
    public class MusicMetaData
    {
        public string SongTitle { get; set; }
        public string SongArtist { get; set; }
        public Image AlbumArt { get; set; }

        public string AudioFilePath { get; set; }

        public MusicMetaData GetMusicMetaData(string filePath)
        {
            var metadata = new MusicMetaData();

            try
            {
                var file = TagLib.File.Create(filePath);

                metadata.SongTitle = file.Tag.Title ?? "Unknown Title";
                metadata.SongArtist = file.Tag.Performers.Length > 0 ? file.Tag.Performers[0] : "Unknown Artist";
                metadata.AudioFilePath = filePath;
                if (file.Tag.Pictures.Length > 0)
                {
                    var picture = file.Tag.Pictures[0];
                    using (var ms = new MemoryStream(picture.Data.Data))
                    {
                        metadata.AlbumArt = Image.FromStream(ms);
                    }
                }
                else
                {
                    metadata.AlbumArt = Properties.Resources.pexels_cytonn_955402;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occued: {ex.Message}");
                metadata.SongTitle = "Unknown Title";
                metadata.SongArtist = "Unknown Artist";
                metadata.AlbumArt = null;
            }

            return metadata;
        }
    }



}
