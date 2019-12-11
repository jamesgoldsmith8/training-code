using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Domain.Delegates;
using MediaWorld.Storing.Repositories;
using Serilog;
using System.Threading;
using System.Threading.Tasks;

namespace MediaWorld.Client
{
    /// <summary>
    /// contain the start point
    /// </summary>
    internal class Program
    {
        
        private static MediaRepository _repository = new MediaRepository();
        /// <summary>
        /// starts the application
        /// </summary>
        private static void Main()   // private static async Task Main()
        {
            var program = new Program();
            program.ApplicationStart();
            Play();
            //MagicThread();
            //MagicTasks();
            //MagicAsync().GetAwaiter().GetResult();  // ends the wait
            //Thread.Sleep(1000);
            //await MagicAsync();
            //Console.WriteLine("end of code");
            Log.Warning("end of Main Method");
        }

        private void ApplicationStart()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("log.txt")
                .CreateLogger();
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
            Log.Information("Play Method");
            var mediaPlayer = MediaSingleton.Instance;

            foreach (var item in _repository.MediaLibrary) 
            {
                Log.Debug("{@puppy} {second} {kitty} {bits}", item, DateTime.Now, item.Duration); //, ((AAudio)item).BitRate);  // didnt see because the minimum level of logger default is information.  so need to change logger level to get this
                mediaPlayer.Execute(item.Play, item);
            }
        }

        private static void MagicThread() 
        {
            var t1 = new Thread(() => { Run("A"); });
            var t2 = new Thread(() => { Run("B"); });

            t1.Start();
            t2.Start();

            t1.Join(); // thread that started this will block until this is done (main in this case)
            t2.Join();

            //if (t1.IsAlive) // can check if t1 is alive for more than five minutes then you can shut it down.
        }

        private static void MagicTasks()
        {
            var t1 = new Task(() => { Run(" All work and no play makes James crazy "); });
            var t2 = new Task(() => { Run("All work and no play makes James CraZy"); });

            t1.Start();
            t2.Start();

            Task.WaitAll(new Task[] {t1, t2}, 10000);  // wait for these two threads for a second
        }

        private static async Task MagicAsync()
        {
            await Task.Run(() => { Run("C"); });  // going to be a task that runs 'Run'.  Just wait for the task to finish.
            await Task.Run(() => { Run("D"); });
        }

        private static void Run(string s)
        {
            for (var x = 0; x < 1000; x++) 
            {
                Console.Write(s);
            }
        }
    }
}
