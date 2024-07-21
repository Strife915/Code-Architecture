namespace CodeArchitecture.Decorator
{
    public interface IBeverage
    {
        string GetDescription();
        double GetCost();
        void SetSize();
        void GetSize();
    }
}