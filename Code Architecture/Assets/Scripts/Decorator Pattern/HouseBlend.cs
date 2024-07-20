namespace CodeArchitecture.Decorator
{
    public class HouseBlend : IBeverage
    {
        public string GetDescription()
        {
            return "House Blend Coffee";
        }

        public double GetCost()
        {
            return 0.89;
        }
    }
}