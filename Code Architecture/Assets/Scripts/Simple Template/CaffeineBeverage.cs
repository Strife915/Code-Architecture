using UnityEngine;

namespace CodeArchitecture.Template
{
    public abstract class CaffeineBeverage
    {
        public abstract void Brew();
        public abstract void AddCondiments();

        void BoilWater() {
            Debug.Log("Boiling water");
        }

        void PourInCup() {
            Debug.Log("Pouring into cup");
        }

        void PrepareRecipe() {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
    }
}