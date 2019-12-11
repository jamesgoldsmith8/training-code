using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
    public class AudioPlayerSingleton : IPlayer
    {
        private static readonly AudioPlayerSingleton _instance = new AudioPlayerSingleton();


        public static AudioPlayerSingleton Instance 
        {
            get
            {
                return _instance;
            }
        }
        
        private AudioPlayerSingleton() {}
        
        public void Execute(string command, AMedia media) 
        {
            Console.WriteLine(media);
        }

        public bool VolumeUp()
        {
            throw new NotImplementedException();
        }

        public bool VolumeDown()
        {
            throw new NotImplementedException();
        }

        public bool VolumeMute() 
        {
            throw new NotImplementedException();
        }

        public bool PowerUp() 
        {
            return true;
        }

        public bool PowerDown() 
        {
            return true;
        }
    }
}