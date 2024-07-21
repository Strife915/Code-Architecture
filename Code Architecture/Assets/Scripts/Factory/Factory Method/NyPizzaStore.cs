using CodeArchitecture.SimpleFactory;

namespace CodeArchitecture.FactoryMethod
{
    public class NyPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaTypes type)
        {
            return type switch
            {
                PizzaTypes.Cheese => new NycCheesePizza(),
                PizzaTypes.Pepperoni => new NycPepperoniPizza(),
                PizzaTypes.Clam => new NycClamPizza(),
                PizzaTypes.Veggie => new NycVeggiePizza(),
                _ => new NycCheesePizza()
            };
        }
    }
}