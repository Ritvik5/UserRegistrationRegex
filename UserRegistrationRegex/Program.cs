namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration for Validation \n");
            
            Console.WriteLine("Enter the First Name : \n");
            string firstName = Console.ReadLine();

            Patterns patterns = new Patterns();
            bool isValid = patterns.ValidateFirstName(firstName);
            if (isValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}