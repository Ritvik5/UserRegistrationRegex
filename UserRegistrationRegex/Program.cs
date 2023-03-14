namespace UserRegistrationRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration for Validation \n");
            
            Console.WriteLine("Enter the Last Name : \n");
            string lastName = Console.ReadLine();

            Patterns patterns = new Patterns();
            bool isValid = patterns.ValidateFirstName(lastName);
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