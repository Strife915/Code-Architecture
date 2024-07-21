using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class NycClamPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Nyc Clam Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Nyc Clam Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Nyc Clam Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Nyc Clam Pizza");
        }
    }
}