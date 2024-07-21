using CodeArchitecture.SimpleFactory;

namespace CodeArchitecture.FactoryMethod
{
    public interface IPizzaStore
    {
        IPizza CreatePizza(PizzaTypes type);
        void OrderPizza();
    }

    public abstract class PizzaStore : IPizzaStore
    {
        public abstract IPizza CreatePizza(PizzaTypes type);

        public void OrderPizza()
        {
            IPizza pizza = CreatePizza(PizzaTypes.Cheese);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}