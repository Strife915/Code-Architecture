using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class NycCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Nyc Cheese Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Nyc Cheese Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Nyc Cheese Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Nyc Cheese Pizza");
        }
    }
}