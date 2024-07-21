using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class ChicagoVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Chicago Veggie Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Chicago Veggie Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Chicago Veggie Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Chicago Veggie Pizza");
        }
    }
}