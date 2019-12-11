using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace MediaWorld.Domain.Singletons
{
    public class MediaSingleton : IPlayer
    {
        private static readonly MediaSingleton _instance = new MediaSingleton();

        private int count = 0;

        public static MediaSingleton Instance 
        {
            get
            {
                return _instance;
            }
        }

        public void ResultHandler(AMedia media) 
        {
            System.Console.WriteLine("{0} is playing...", media.Title);
        }

        public void ResultHandlerJames(AMedia media)
        {
            System.Console.WriteLine("Count = {0}", count);
            count++;
        }
        
        private MediaSingleton() {}
        
        public bool Execute(ButtonDelegate button, AMedia media) 
        {
            media.ResultEvent += ResultHandler;
            //media.ResultEvent += ResultHandlerJames;
            return button();
            //System.Console.WriteLine(button());
            //button();h
        }

        public bool VolumeUp()
        {
            return true;
        }

        public bool VolumeDown()
        {
            return true;
        }

        public bool VolumeMute() 
        {
            return true;
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