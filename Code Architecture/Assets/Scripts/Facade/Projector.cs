using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class Projector
    {
        DvdPlayer _dvdPlayer;

        public Projector(DvdPlayer dvdPlayer) {
            _dvdPlayer = dvdPlayer;
        }

        public void On() {
            Debug.Log("Projector on");
        }

        public void WideScreenMode() {
            Debug.Log("Projector in wide screen mode");
        }

        public void Off() {
            Debug.Log("Projector off");
        }
    }
}