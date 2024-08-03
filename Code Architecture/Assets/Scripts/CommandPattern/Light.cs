using UnityEngine;

namespace CodeArchitecture.Command
{
    public class Light : IDisplayElement
    {
        string _name;
        public string DisplayText => _name;

        public Light(string name) {
            _name = name;
        }

        public void On() {
            Debug.Log(_name + " Light is on");
        }

        public void Off() {
            Debug.Log(_name + " Light is off");
        }
    }
}