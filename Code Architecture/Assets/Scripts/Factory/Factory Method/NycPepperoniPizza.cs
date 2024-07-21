using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class NycPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Nyc Pepperoni Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Nyc Pepperoni Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Nyc Pepperoni Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Nyc Pepperoni Pizza");
        }
    }
}