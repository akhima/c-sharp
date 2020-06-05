namespace myapp
{
    public class PersonDetails
    {
        public string FirstName;
        public string LastName;
        public void IntroduceMe()
        {
            System.Console.WriteLine("My name is "+FirstName+" "+LastName);
        }
    }
}