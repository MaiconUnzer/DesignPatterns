﻿using System;

namespace DesignPatterns._2.StructuralPatterns._2._1.Adapter.Exemplo2
{
    //Adaptee class
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayAdvanced(string fileName)
        {
            Console.WriteLine("Playing VLC, FileName: ", fileName);
        }
    }
}
