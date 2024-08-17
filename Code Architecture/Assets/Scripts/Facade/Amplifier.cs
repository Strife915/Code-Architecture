using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class Amplifier
    {
        Tuner _tuner;
        DvdPlayer _dvdPlayer;
        CdPlayer _cdPlayer;

        public Amplifier(Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer) {
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
        }

        public void SetTuner(Tuner tuner) {
            _tuner = tuner;
        }

        public void On() {
            Debug.Log("Amplifier on");
        }

        public void SetVolume(int volume) {
            Debug.Log("Amplifier volume set to " + volume);
        }

        public void SetSurroundSound() {
            Debug.Log("Amplifier surround sound on");
        }

        public void SetStereoSound() {
            Debug.Log("Amplifier stereo sound on");
        }

        public void Off() {
            Debug.Log("Amplifier off");
        }

        public void SetDvd(DvdPlayer dvdPlayer) {
            Debug.Log("Amplifier set to DVD player");
        }

        public void SetCd(CdPlayer cdPlayer) {
            Debug.Log("Amplifier set to CD player");
        }
    }
}