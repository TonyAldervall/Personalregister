namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegistry registry = new EmployeeRegistry();

            while (true)
            {
                Console.WriteLine("\n1. Add employee");
                Console.WriteLine("2. Delete employee");
                Console.WriteLine("3. Show employees");
                Console.WriteLine("0. Quit");
                Console.Write("\nYour choice: ");
                string input = Console.ReadLine() ?? string.Empty;
                
                switch (input)
                {
                    case "1":
                        registry.AddEmployee();
                        break;

                    case "2":
                        registry.RemoveEmployeeById();
                        break;

                    case "3":
                        Console.WriteLine(registry);
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nInput has to be a number between 0-2.");
                        break;
                }
            }
        }
    }
}