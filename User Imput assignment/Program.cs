namespace User_Imput_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //int age;
            //double salary;

            //Console.WriteLine("Hello! What is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine("Hi, " + name + ". How old are you?");
            //Int32.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine("So your " + age + " eh? That's not old at all! How much do you make " + name + "?");
            //double.TryParse(Console.ReadLine(), out salary);
            //Console.WriteLine(salary.ToString("C") + "! I hope that's per hour and not per year!");

            string firstName, lastName, login;
            int grade, studentId;
            double average;

            Console.WriteLine("first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Grade (9-12):");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.WriteLine("Student ID:");
            Int32.TryParse(Console.ReadLine(), out studentId);
            Console.WriteLine("Login name:");
            login = Console.ReadLine();
            Console.WriteLine("Average (Rounded to the nearest tenth):");
            double.TryParse(Console.ReadLine(), out average);

        }
    }
}
