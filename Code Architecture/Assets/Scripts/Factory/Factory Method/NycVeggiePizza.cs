using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class NycVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Nyc Veggie Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Nyc Veggie Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Nyc Veggie Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Nyc Veggie Pizza");
        }
    }
}