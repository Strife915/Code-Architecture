namespace CodeArchitecture.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }   
}
