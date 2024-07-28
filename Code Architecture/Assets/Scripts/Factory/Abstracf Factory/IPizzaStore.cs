using CodeArchitecture.Enums;

namespace CodeArchitecture.Abstract.Factory
{
    public interface IPizzaStore
    {
        IPizza CreatePizza(PizzaTypes type);
        void OrderPizza(PizzaTypes type);
    }

    public abstract class PizzaStore : IPizzaStore
    {
        public abstract IPizza CreatePizza(PizzaTypes type);

        public void OrderPizza(PizzaTypes type) {
        }
    }
}