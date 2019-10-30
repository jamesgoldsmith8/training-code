using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
    public class MediaSingleton : IPlayer
    {
        private static readonly MediaSingleton _instance = new MediaSingleton();

        private MediaSingleton() {}
        public static MediaSingleton Instance 
        {
            get
            {
                return _instance;
            }
        }
        
        public void Execute(string command, AMedia media) 
        {
            Console.WriteLine(media);
        }
    }
}