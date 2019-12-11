using System;
using System.Threading;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace MediaWorld.Domain.Abstracts
{
    public abstract class AMedia : IControl 
    {
        public event ResultDelegate ResultEvent; // ResultDelegate is what happens do to the event happening

        public TimeSpan Duration { get; set; }

        public string Title { get; set; }

        public AMedia()
        {
            
        }

        public virtual bool Pause()
        {
            return true;
        }

        public virtual bool Play()
        {
            int count = 0;

            if (ResultEvent == null)
            {
                return fals
                
                e;
            }

            while(count < 3)
            {
                Thread.Sleep(2000);
                ResultEvent(this);
                count += 1;
            }

            return true;
        }

        public abstract bool Rewind();

        public bool Stop()
        {
            return true;
        }

        public abstract bool Forward();

        public override string ToString() 
        {
            return $"{this}";
        }
    }
}