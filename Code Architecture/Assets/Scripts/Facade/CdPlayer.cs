using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class CdPlayer
    {
        Amplifier _amplifier;

        public CdPlayer(Amplifier amplifier) {
            _amplifier = amplifier;
        }

        public void On() {
            Debug.Log("CD player on");
        }

        public void Play(string cd) {
            Debug.Log("CD player playing " + cd);
        }

        public void Stop() {
            Debug.Log("CD player stopped");
        }

        public void Eject() {
            Debug.Log("CD player ejected");
        }

        public void Off() {
            Debug.Log("CD player off");
        }
    }
}