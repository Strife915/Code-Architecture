using UnityEngine;

namespace CodeArchitecture.Template
{
    public abstract class CaffeinBeberageWithHook
    {
        public abstract void Brew();
        public abstract void AddCondiments();

        public void PrepareRecipe() {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
                AddCondiments();
        }

        void BoilWater() {
            Debug.Log("Boiling water");
        }

        void PourInCup() {
            Debug.Log("Pouring into cup");
        }

        public virtual bool CustomerWantsCondiments() {
            return true;
        }
    }
}