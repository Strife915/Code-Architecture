namespace CodeArchitecture.Visitor
{
    public interface IVisitor
    {
        void Visit(IVisitable visitable);
        void Visit<T>(IVisitable visitable, T value);
    }
}