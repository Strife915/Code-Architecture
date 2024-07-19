namespace CodeArchitecture.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    public interface IDisplayElement
    {
        void Display();
    }

    public interface IObserver
    {
        void UpdateObserver(object data);
    }
}