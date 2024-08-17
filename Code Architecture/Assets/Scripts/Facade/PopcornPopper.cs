using UnityEngine;

namespace CodeArchitecture.Facade
{
    public class PopcornPopper
    {
        public void On() {
            Debug.Log("Popcorn popper on");
        }

        public void Pop() {
            Debug.Log("Popcorn popper popping popcorn");
        }

        public void Off() {
            Debug.Log("Popcorn popper off");
        }
    }
}