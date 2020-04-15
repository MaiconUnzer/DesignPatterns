using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter.Exemplo2
{
    public class MediaPlayer
    {
        private readonly IMediaPlayer _mediaPlayer;

        public MediaPlayer(IMediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        public void PlayMedia(string fileName)
        {
            _mediaPlayer.Play(fileName);
        }
    }
}
