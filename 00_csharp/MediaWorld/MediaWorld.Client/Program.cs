using System;
using MediaWorld.Domain.Models;

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
            var mediaPlayer = MediaSingleton.GetInstance();
            Music song = new Song();
            Music audible = new Audible();

            mediaPlayer.Play(song);
            mediaPlayer.Play(audible);
        }
    }
}
