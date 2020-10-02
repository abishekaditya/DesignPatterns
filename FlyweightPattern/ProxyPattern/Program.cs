using System;

namespace FacadePattern
{
    internal static class Program
    {
        private static void Main()
        {
            var dimmer = new Dimmer();
            var dvdPlayer = new DvdPlayer();
            var dvd = new Dvd("Gone with the Wind 2 : Electric Bugaloo");
            var homeTheater = new HomeTheatreFacade(dimmer,dvd,dvdPlayer);

            homeTheater.WatchMovie();
            Console.WriteLine();
            homeTheater.Pause();
            Console.WriteLine();
            homeTheater.Resume();
            Console.WriteLine();
            homeTheater.Pause();
        }
    }
}
