using System;

namespace MediaWorld.Domain.Models
{

    public abstract class Music
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }

        public Music() 
        {
            Artist = "Charlie Daniels";
            Title = "Devil went down to Georgia";
            Genre = "Country";
            Duration = new TimeSpan(0, 3, 0);
        }
    }
}