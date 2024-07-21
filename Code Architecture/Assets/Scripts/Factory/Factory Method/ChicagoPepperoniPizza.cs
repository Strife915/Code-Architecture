using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Chicago Pepperoni Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Chicago Pepperoni Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Chicago Pepperoni Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Chicago Pepperoni Pizza");
        }
    }
}