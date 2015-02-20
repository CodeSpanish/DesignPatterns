using System.Security.Cryptography.X509Certificates;

namespace Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObservers(IObserver observer);
        void NotifyObservers();
    }
}