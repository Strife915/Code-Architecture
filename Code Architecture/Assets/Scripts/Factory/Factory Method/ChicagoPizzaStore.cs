using CodeArchitecture.Enums;
using CodeArchitecture.SimpleFactory;

namespace CodeArchitecture.FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaTypes type) {
            return type switch
            {
                PizzaTypes.Cheese => new ChicagoCheesePizza(),
                PizzaTypes.Pepperoni => new ChicagoPepperoniPizza(),
                PizzaTypes.Clam => new ChicagoClamPizza(),
                PizzaTypes.Veggie => new ChicagoVeggiePizza(),
                _ => new ChicagoCheesePizza()
            };
        }
    }
}