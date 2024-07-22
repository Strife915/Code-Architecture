namespace CodeArchitecture.Abstract.Factory
{
    public interface PizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough CreateDough() {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce() {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese() {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggies() {
            IVeggies[] veggies = { new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public IPepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }

        public IClams CreateClams() {
            return new FreshClams();
        }
    }

    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough CreateDough() {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce() {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese() {
            return new MozzarellaCheese();
        }

        public IVeggies[] CreateVeggies() {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }

        public IPepperoni CreatePepperoni() {
            return new PorkPepperoni();
        }

        public IClams CreateClams() {
            return new FrozenClams();
        }
    }
}