namespace Övning_1___Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegistry registry = new EmployeeRegistry();
            bool run = true;

            while (run)
            {
                Console.WriteLine("\n1. Add employee");
                Console.WriteLine("2. Delete employee");
                Console.WriteLine("3. Show employees");
                Console.WriteLine("0. Quit");
                Console.Write("\nYour choice: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        registry.AddEmployee();
                        break;

                    case "2":
                        registry.RemoveEmployeeById();
                        break;

                    case "3":
                        Console.WriteLine(registry.ToString());
                        break;

                    case "0": 
                        run = false; 
                        break;

                    default:
                        Console.WriteLine("\nInput has to be a number between 0-2.");
                        break;
                }
            }
        }
    }
}