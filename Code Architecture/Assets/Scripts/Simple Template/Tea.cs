using UnityEngine;

namespace CodeArchitecture.Template
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew() {
            Debug.Log("Steeping the tea");
        }

        public override void AddCondiments() {
            Debug.Log("Adding lemon");
        }
    }
}