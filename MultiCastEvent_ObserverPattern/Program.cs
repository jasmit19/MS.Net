namespace MultiCastEvent_ObserverPattern
{
    public delegate void NotifyEventHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // coupling subscriber methods() to the Event of publisher class via Notify (event object)
            // :: Multi-cast event
            publisher.Notify += subscriber.Method1;
            publisher.Notify += subscriber.Method2;

            // Raise the event
            // send notification to subscriber methods() via Event method (notifySubscribers) of Publisher class
            publisher.NotifySubscribers("The Grand Sale is UP! Upto 70% off on selected products!");

            // remove Method1 from receiving notifications
            publisher.Notify -= subscriber.Method1;

            // now only method2 will recieve notifications
            publisher.NotifySubscribers("Flash Sale! Extra 10 % off on Electronics!");
        }
    }
    public class Subscriber
    {
        public void Method1(string message)
        {
            Console.WriteLine($"Method1 recieved : {message} via sms");
        }
        public void Method2(string message)
        {
            Console.WriteLine($"Method2 recieved : {message} via email");
        }
    }
    public class Publisher
    {
        public event NotifyEventHandler Notify;

        public void NotifySubscribers(string message)
        {
            //  Notify.Invoke(message);
            Notify?.Invoke(message);
        }
    }
}
