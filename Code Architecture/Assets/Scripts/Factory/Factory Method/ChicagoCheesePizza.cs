using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class ChicagoCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Chicago Cheese Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Chicago Cheese Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Chicago Cheese Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Chicago Cheese Pizza");
        }
    }
}