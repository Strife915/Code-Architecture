namespace CodeArchitecture.Decorator
{
    public class Whips : IBeverage
    {
        readonly IBeverage _beverage;

        public Whips(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", Whips";
        }

        public double GetCost()
        {
            return _beverage.GetCost() + 0.10;
        }

        public void SetSize()
        {
        }

        public void GetSize()
        {
        }
    }
}