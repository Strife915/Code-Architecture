using UnityEngine;

namespace CodeArchitecture.Template
{
    public class TeaWithHook : CaffeinBeberageWithHook
    {
        public override void Brew() {
            Debug.Log("Steeping the tea");
        }

        public override void AddCondiments() {
            Debug.Log("Adding lemon");
        }

        public override bool CustomerWantsCondiments() {
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                Debug.Log("Customer adds tea condiments");
                return true;
            }

            return false;
        }
    }
}