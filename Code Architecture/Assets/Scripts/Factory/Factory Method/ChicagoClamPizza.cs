using CodeArchitecture.SimpleFactory;
using UnityEngine;

namespace CodeArchitecture.FactoryMethod
{
    public class ChicagoClamPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Chicago Clam Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Chicago Clam Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Chicago Clam Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Chicago Clam Pizza");
        }
    }
}