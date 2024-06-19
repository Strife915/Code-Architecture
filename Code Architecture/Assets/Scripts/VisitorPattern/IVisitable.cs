namespace CodeArchitecture.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
        void Accept<T>(IVisitor visitor, T value);
    }
}