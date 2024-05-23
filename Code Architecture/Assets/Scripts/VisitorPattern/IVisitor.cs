namespace CodeArchitecture.Visitor
{
    public interface IVisitor
    {
        void Visit(object o);
        //void Visit(HealthComponent healthComponent);
        //void Visit(ManaComponent manaComponent);
        // void Visit(IntrusiveHealthComponent intrusiveHealthComponent);
        // void Visit(IntrusiveManaComponent intrusiveManaComponent);
    }
}