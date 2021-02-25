namespace FacadePattern
{
    public class HomeTheatreFacade
    {
        private Dimmer _dimmer;
        private Dvd _dvd;
        private DvdPlayer _dvdPlayer;

        public HomeTheatreFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdPlayer)
        {
            _dvd = dvd;
            _dimmer = dimmer;
            _dvdPlayer = dvdPlayer;
        }

        public void WatchMovie()
        {
            _dimmer.Dim(5);
            _dvdPlayer.On();
            _dvdPlayer.Insert(_dvd);
            _dvdPlayer.Play();
        }

        public void Pause()
        {
            _dimmer.Dim(10);
            _dvdPlayer.Pause();
        }

        public void Resume()
        {
            _dimmer.Dim(5);
            _dvdPlayer.Resume();
        }
    }
}