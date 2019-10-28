using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;

namespace MediaWorld.Client
{
    /// <summary>
    /// contain the start point
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// starts the application
        /// </summary>
        private static void Main()
        {
            Play();
        }

        private static void Play()
        {
            /*
            var mediaPlayer = MediaSingleton.GetInstance();
             
            Music song = new Song();
            Music audible = new Audible();

            mediaPlayer.Play(song);
            mediaPlayer.Play(audible);
            */

            var mediaPlayer = MediaSingleton.Instance;
            AMedia song = new Song();
            AMedia movie = new Movie();

            mediaPlayer.Execute("play", song);
            mediaPlayer.Execute("play", movie);
        }
    }
}
