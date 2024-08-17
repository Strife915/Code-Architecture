using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class DvdPlayer
    {
        Amplifier _amplifier;

        public DvdPlayer(Amplifier amplifier) {
            _amplifier = amplifier;
        }

        public void On() {
            Debug.Log("DVD player on");
        }

        public void Play(string movie) {
            Debug.Log("DVD player playing " + movie);
        }

        public void Stop() {
            Debug.Log("DVD player stopped");
        }

        public void Eject() {
            Debug.Log("DVD player ejected");
        }

        public void Off() {
            Debug.Log("DVD player off");
        }
    }
}