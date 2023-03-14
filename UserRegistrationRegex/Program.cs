namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration for Validation \n");
            
            Console.WriteLine("Enter the Valid Email Id : \n");
            string email = Console.ReadLine();

            Patterns patterns = new Patterns();
            bool isValid = patterns.ValidateFirstName(email);
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