namespace DP.API.Design_Patterns.ODP
{
    public class UserObserverSubject
    {
        private List<IUserObserver> _observers = new List<IUserObserver>();
        public void AddObserver(IUserObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IUserObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify(User user)
        {




            //Task Parallel Library
            //Parallel.ForEach(_observers, observer =>
            //{
            //    observer.UserCreated(user);
            //});

            foreach (var observer in _observers)
            {
                observer.UserCreated(user);
            }
        }
    }
}
