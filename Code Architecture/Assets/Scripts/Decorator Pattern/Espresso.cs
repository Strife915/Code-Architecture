namespace CodeArchitecture.Decorator
{
    public class Espresso : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetCost()
        {
            return 1.99;
        }

        public void SetSize()
        {
        }

        public void GetSize()
        {
        }
    }
}