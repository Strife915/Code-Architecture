using UnityEngine;

namespace CodeArchitecture.Template
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew() {
            Debug.Log("Dripping coffee through filter");
        }

        public override void AddCondiments() {
            Debug.Log("Adding sugar and milk");
        }
    }
}