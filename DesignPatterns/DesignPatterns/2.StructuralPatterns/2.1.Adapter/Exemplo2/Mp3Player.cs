using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter.Exemplo2
{
    //Target Class
    public class Mp3Player : IMediaPlayer
    {
        public void Play(string fileName)
        {
            Console.WriteLine("Playing Mp3, FileName: ", fileName);
        }
    }
}
