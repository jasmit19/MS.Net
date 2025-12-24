namespace MultiCastDelegate
{
    // declare a delegate
    public delegate void MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Did the Guest arrive?    (y/n)");
            string isGuestArrived = Console.ReadLine();

            // create a class object to call the CollegeEvents methods()
            CollegeAnnualEvent college = new CollegeAnnualEvent();

            // create an object of Delegate to add CollegeEvents methods() and make a list
            // and 1 method()
            MyEventHandler handler = college.Welcome;

            // use coupling operator to add more methods() and make a list
            // add accordingly to call in a sequence
            handler += college.WelSpeech;

            if(isGuestArrived.ToLower() == "y")
            {
                handler += college.GuestSpeech;
            }
            else
            {
                // This ensures that no matter what, the delegate list will not contain GuestSpeech unless the condition is true.
                // for future safety
                handler -= college.GuestSpeech;
            }

            handler += college.Dance;
            handler += college.Dinner;
            handler += college.GoodBye;
            handler += college.EndEvent;

            //Invoke delegate: This calls every method in the list, in order. It’s like pressing “play” on the schedule.
            handler();

        }
    }
    public class CollegeAnnualEvent
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome everyone!!");
        }
        public void WelSpeech()
        {
            Console.WriteLine("Host: blah blah blah blah!!");
        }
        public void GuestSpeech()
        {
            Console.WriteLine("Guest: blah blah blah blah!!");
        }
        public void Dance()
        {
            Console.WriteLine("Oh GOD, we have have to go through this!!");
        }
        public void Dinner()
        {
            Console.WriteLine("We insist everyone , please enjoy dinner...!!");
        }
        public void GoodBye()
        {
            Console.WriteLine("Bye bye.. please ghar jao...!!");
        }
        public void EndEvent()
        {
            Console.WriteLine("Pack UP...!!");
        }
    }
}
