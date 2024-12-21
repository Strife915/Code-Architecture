using CodeArchitecture.Iterator;

namespace CodeArchitecture.Composite
{
    public abstract class MenuComponent
    {
        public abstract IIterator CreateIterator();

        public virtual void Add(MenuComponent menuComponent) {
            throw new System.NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent) {
            throw new System.NotImplementedException();
        }

        public virtual MenuComponent GetChild(int i) {
            throw new System.NotImplementedException();
        }

        public virtual string GetName() {
            throw new System.NotImplementedException();
        }

        public virtual string GetDescription() {
            throw new System.NotImplementedException();
        }

        public virtual double GetPrice() {
            throw new System.NotImplementedException();
        }

        public virtual bool IsVegetarian() {
            throw new System.NotImplementedException();
        }

        public virtual void Print() {
            throw new System.NotImplementedException();
        }
    }
}