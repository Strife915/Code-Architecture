using UnityEngine;

namespace CodeArchitecture.Template
{
    public class CoffeeWithHook : CaffeinBeberageWithHook
    {
        public override void Brew() {
            Debug.Log("Dripping coffee through filter");
        }

        public override void AddCondiments() {
            Debug.Log("Adding sugar and milk");
        }

        public override bool CustomerWantsCondiments() {
            int rand = Random.Range(0, 2);
            if (rand == 0)
                return true;
            return false;
        }
    }
}