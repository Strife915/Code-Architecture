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
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IVeggies[] Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClams Clams { get; set; }

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

    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory) {
            _ingredientFactory = ingredientFactory;
            Name = "Pepperoni Pizza";
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

    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory) {
            _ingredientFactory = ingredientFactory;
            Name = "Veggie Pizza";
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