using UnityEngine;

namespace CodeArchitecture.SimpleFactory
{
    public class PizzaStore
    {
        public void OrderPizza(PizzaTypes type)
        {
            var factory = new SimplePizzaFactory();
            IPizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }

    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(PizzaTypes type)
        {
            return type switch
            {
                PizzaTypes.Cheese => new CheesePizza(),
                PizzaTypes.Pepperoni => new PepperoniPizza(),
                PizzaTypes.Clam => new ClamPizza(),
                PizzaTypes.Veggie => new VeggiePizza(),
                _ => new CheesePizza()
            };
        }
    }

    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }

    public abstract class Pizza : IPizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }

    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Cheese Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Cheese Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Cheese Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Cheese Pizza");
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Pepperoni Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Pepperoni Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Pepperoni Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Pepperoni Pizza");
        }
    }

    public class ClamPizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Clam Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Clam Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Clam Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Clam Pizza");
        }
    }

    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Debug.Log("Preparing Veggie Pizza");
        }

        public override void Bake()
        {
            Debug.Log("Baking Veggie Pizza");
        }

        public override void Cut()
        {
            Debug.Log("Cutting Veggie Pizza");
        }

        public override void Box()
        {
            Debug.Log("Boxing Veggie Pizza");
        }
    }
}