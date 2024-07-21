namespace CodeArchitecture.Decorator
{
    public class Soy : IBeverage
    {
        readonly IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public double GetCost()
        {
            return _beverage.GetCost() + 0.15;
        }

        public void SetSize()
        {
        }

        public void GetSize()
        {
        }
    }
}