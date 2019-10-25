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
            var helper = MediaSingleton.GetInstance();
            Console.WriteLine(helper);
        }
    }
}
