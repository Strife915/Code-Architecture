using UnityEngine;

namespace CodeArchitecture.Abstract.Factory
{
    public interface IPizza
    {
        string Name { get; }
        IDough Dough { get; }
        ISauce Sauce { get; }
        IVeggies[] Veggies { get; }
        ICheese Cheese { get; }
        IPepperoni Pepperoni { get; }
        IClams Clams { get; }
        void Prepare();
        void Cut();
        void Box();
    }

    public abstract class Pizza : IPizza
    {
        public string Name { get; protected set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public IVeggies[] Veggies { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IPepperoni Pepperoni { get; protected set; }
        public IClams Clams { get; protected set; }

        public abstract void Prepare();

        public void Cut() {
        }

        public void Box() {
        }
    }

    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public CheesePizza(PizzaIngredientFactory ingredientFactory) {
            _ingredientFactory = ingredientFactory;
            Name = "Cheese Pizza";
        }

        public override void Prepare() {
            Debug.Log("Prepearing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
            Clams = _ingredientFactory.CreateClams();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }

    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory) {
            _ingredientFactory = ingredientFactory;
            Name = "Clam Pizza";
        }

        public override void Prepare() {
            Debug.Log("Prepearing " + Name);
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Veggies = _ingredientFactory.CreateVeggies();
            Clams = _ingredientFactory.CreateClams();
            Pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}