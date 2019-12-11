namespace MediaWorld.Domain.Interfaces 
{
    public interface IControl 
    {
        bool Pause();

        bool Play();

        bool Rewind();

        bool Stop();

        bool Forward();
    }
}