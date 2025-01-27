﻿using AudioPhile.Props;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPhile.Singleton
{
    public class PlaybackManager
    {
        private static IWavePlayer _currentWavePlayer;
        private static AudioFileReader _currentAudioFileReader;
        private static MusicMetaData _currentMusicMetaData;

        private static TimeSpan _pausedTime = TimeSpan.Zero;
        private static bool _isPaused = false;
        private static int _currentIndex = -1;
        public static MusicMetaData CurrentMusicMetaData => _currentMusicMetaData;

        public static TimeSpan CurrentPosition => _currentAudioFileReader?.CurrentTime ?? TimeSpan.Zero;
        public static TimeSpan Duration => _currentAudioFileReader?.TotalTime ?? TimeSpan.Zero;
        public static List<MusicMetaData> MusicList { get; set; } = new List<MusicMetaData>();

        //public static void Play(int index)
        //{
        //    if (index < 0 || index >= MusicList.Count) return ;

        //    Stop();

        //    _currentIndex = index;

        //    _currentMusicMetaData = MusicList[index];


        //    _currentAudioFileReader = new AudioFileReader(_currentMusicMetaData.AudioFilePath);
        //    _currentWavePlayer = new WaveOutEvent();
        //    _currentWavePlayer.Init(_currentAudioFileReader);
        //    _currentWavePlayer.Play();
        //    _isPaused = false;

        //}

        public static void Play(MusicMetaData musicMetaData)
        {
            Stop(); 

            _currentMusicMetaData = musicMetaData; 

            _currentAudioFileReader = new AudioFileReader(musicMetaData.AudioFilePath);
            

            _currentWavePlayer = new WaveOutEvent();
            _currentWavePlayer.Init(_currentAudioFileReader);
            _currentWavePlayer.Play();
            _isPaused = false;
        }


        public static void changeVolume(float volumeValue)
        {
            if (_currentAudioFileReader != null) {

                _currentAudioFileReader.Volume = volumeValue / 100f;
            }
        }

        public static void Stop()
        {
            if (_currentWavePlayer != null) { 
            
                _currentWavePlayer.Stop();
                _currentWavePlayer.Dispose();  
                _currentWavePlayer = null;
            }

            if (_currentAudioFileReader != null) {
            
                _currentAudioFileReader.Dispose();
                _currentAudioFileReader = null;
            }
        }

        public static void Pause()
        {
            if (_currentWavePlayer != null && !_isPaused)
            {
                _pausedTime = _currentAudioFileReader.CurrentTime;
                _currentWavePlayer.Stop();
                _isPaused = true;
            }
        }

        public static void Resume()
        {
            if (_currentAudioFileReader != null && _isPaused)
            {

                _currentAudioFileReader.CurrentTime = _pausedTime;
                _currentWavePlayer.Play();
                _isPaused = false;
            }
        }

        //public static void Previous()
        //{
        //    if (MusicList.Count == 0 || _currentIndex == -1) return;

        //    int prevIndex = (_currentIndex - 1 + MusicList.Count) % MusicList.Count;
        //    Play(prevIndex);
        //}

        //public static void Next()
        //{
        //    if(MusicList.Count == 0 || _currentIndex == -1) return;
            
        //    int nextIndex = (_currentIndex + 1) % MusicList.Count;
        //    Play(nextIndex);
        //}

        public static void LoadAllMusicFromMetaData()
        {

        }
    }
}
