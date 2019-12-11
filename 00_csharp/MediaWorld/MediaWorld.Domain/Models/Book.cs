using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models 
{
    public class Book : AAudio 
    {
        public Book()
        {
            Initialize();
        }

        public Book(string title, TimeSpan duration, int bitRate) 
        {
            Initialize(title, duration, bitRate);
        }

        private void Initialize(string title = "Untitled", TimeSpan duration = new TimeSpan(), int bitRate = 10) 
        {
            Title = title;
            Duration = duration;
            BitRate = bitRate;
        }
    }
}