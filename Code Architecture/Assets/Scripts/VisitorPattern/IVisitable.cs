namespace CodeArchitecture.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
        void Accept(IVisitor visitor, int value);
        void Accept(IVisitor visitor, string value);
        void Accept(IVisitor visitor, float value);
        void Accept(IVisitor visitor, bool value);
    }   
}
