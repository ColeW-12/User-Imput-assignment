using System.Data;
using System.Globalization;

namespace User_Imput_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double salary;

            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So your " + age + " eh? That's not old at all! How much do you make " + name + "?");
            double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine(salary.ToString("C") + "! I hope that's per hour and not per year!");

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
            Console.WriteLine("Your Information:");
            Console.WriteLine("Login: \t \t" + login);
            Console.WriteLine("ID: \t\t" + studentId);
            Console.WriteLine("Name: \t\t" + lastName + ", " + firstName);
            Console.WriteLine("Average: \t" + average);
            Console.WriteLine("Grade: \t\t" + grade);

            string name2;
            int age2;

            Console.WriteLine("Hello! What's your name?");
            name2 = Console.ReadLine();
            Console.WriteLine("Hey, " + name2 + "! How old are you?");
            Int32.TryParse(Console.ReadLine(), out age2);
            Console.WriteLine("Did you know that in 5 years you will be " + (age2 + 5));
            Console.WriteLine("and 5 years ago, you were " + (age2 - 5) + ".");

            double numberA, numberB, numberC, finalNumber;

            Console.WriteLine("The computer will add the numbers and divide them by 2.");
            Console.WriteLine("Input number a. here:");
            double.TryParse(Console.ReadLine(), out numberA);
            Console.WriteLine("Input number b. here:");
            double.TryParse(Console.ReadLine(), out numberB);
            Console.WriteLine("Input number c. here:");
            double.TryParse(Console.ReadLine(), out numberC);
            finalNumber = ((numberA + numberB + numberC) / 2);
            Console.WriteLine("The output of your numbers added and then divided by 2 is: " + finalNumber);

            string item1, item2;
            double item1Price, item2Price, total, discount20, discountTax, discountAmount, taxAmount, subtotal;
            
            Console.WriteLine("What is the name of your first item?");
            item1 = Console.ReadLine();
            Console.WriteLine("What is the price of your first item?");
            double.TryParse(Console.ReadLine(), out item1Price);
            Console.WriteLine("What is the name of your second item?");
            item2 = Console.ReadLine();
            Console.WriteLine("What is the price of your second item?");
            double.TryParse(Console.ReadLine(), out item2Price);
            total = (item1Price + item2Price);
            Console.WriteLine("The price of your items added together is " + total.ToString("C"));
            discount20 = total - (total * 0.2);
            Console.WriteLine("Your 20% discounted price is: " + discount20.ToString("C"));
            discountTax = discount20 + (total * 0.13);
            discountAmount = total * 0.2;
            taxAmount = total * 0.13;
            Console.WriteLine("With tax, the final price will be: " + discountTax.ToString("C"));
            Console.WriteLine("Sales recipt");
            Console.WriteLine("Item 1: \t" + item1);
            Console.WriteLine("Price: \t\t" + item1Price.ToString("C"));
            Console.WriteLine("Item 2: \t" + item2);
            Console.WriteLine("Price: \t\t" + item2Price.ToString("C"));
            Console.WriteLine("Total: \t\t" + total.ToString("C"));
            Console.WriteLine("Discount (20%): " + discountAmount.ToString("C"));
            Console.WriteLine("Subtotal: \t" + discount20.ToString("C"));
            Console.WriteLine("Tax (13%): \t" + taxAmount.ToString("C"));
            Console.WriteLine("Amount owed: \t" + discountTax.ToString("C"));


        }
    }
}
