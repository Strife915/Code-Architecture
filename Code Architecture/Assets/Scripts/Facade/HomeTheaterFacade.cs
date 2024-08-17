namespace CodeArchitecture.Facade
{
    public class HomeTheaterFacade
    {
        Amplifier _amplifier;
        Tuner _tuner;
        DvdPlayer _dvdPlayer;
        CdPlayer _cdPlayer;
        Projector _projector;
        TheaterLights _theaterLights;
        Screen _screen;
        PopcornPopper _popcornPopper;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper) {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
            _screen = screen;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie) {
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie() {
            _popcornPopper.Off();
            _theaterLights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }

        public void ListenToCd(string cdTitle) {
            _theaterLights.On();
            _amplifier.On();
            _amplifier.SetCd(_cdPlayer);
            _amplifier.SetStereoSound();
            _amplifier.SetVolume(5);
            _cdPlayer.On();
            _cdPlayer.Play(cdTitle);
        }

        public void EndCd() {
            _amplifier.Off();
            _cdPlayer.Stop();
            _cdPlayer.Eject();
            _cdPlayer.Off();
        }

        public void ListenToRadio() {
            _theaterLights.On();
            _amplifier.On();
            _amplifier.SetTuner(_tuner);
        }
    }
}