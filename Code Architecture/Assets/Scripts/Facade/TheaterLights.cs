using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class TheaterLights
    {
        public void On() {
            Debug.Log("Theater lights on");
        }

        public void Off() {
            Debug.Log("Theater lights off");
        }

        public void Dim(int level) {
            Debug.Log("Theater lights dimmed to " + level);
        }
    }
}