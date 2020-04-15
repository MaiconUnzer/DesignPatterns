using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter.Exemplo2
{
    // Adapter Class
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(IAdvancedMediaPlayer advancedMediaPlayer)
        {
            _advancedMediaPlayer = advancedMediaPlayer;
        }

        public void Play(string fileName)
        {
            _advancedMediaPlayer.PlayAdvanced(fileName);
        }
    }
}
