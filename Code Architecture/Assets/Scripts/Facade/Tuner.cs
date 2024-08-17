using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class Tuner
    {
        Amplifier _amplifier;

        public Tuner(Amplifier amplifier) {
            _amplifier = amplifier;
        }

        void On() {
            Debug.Log("Tuner on");
        }

        void Off() {
            Debug.Log("Tuner off");
        }

        void SetAm() {
            Debug.Log("Tuner set to AM");
        }

        void SetFm() {
            Debug.Log("Tuner set to FM");
        }

        void SetFrequency() {
            Debug.Log("Tuner frequency set");
        }
    }
}