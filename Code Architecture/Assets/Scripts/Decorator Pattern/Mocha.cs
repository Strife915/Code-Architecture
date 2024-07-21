namespace CodeArchitecture.Decorator
{
    public class Mocha : IBeverage
    {
        readonly IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public double GetCost()
        {
            return _beverage.GetCost() + 0.20;
        }

        public void SetSize()
        {
        }

        public void GetSize()
        {
        }
    }
}