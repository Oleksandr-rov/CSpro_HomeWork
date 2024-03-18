namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();

            user1.Gender = GenderType.Male;

            Console.Write("Enter First Name: ");
            user1.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            user1.LastName = Console.ReadLine();

            Console.WriteLine(user1);
        }
    }
}
