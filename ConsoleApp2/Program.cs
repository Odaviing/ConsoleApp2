using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = "", number2 = "";
            double i_check;
            bool check1 = false, check2 = false;
            Console.WriteLine("Enter your numbers, Mason");
            while (!check1 || !check2)
            {
                Console.WriteLine("First number");
                number1 = Console.ReadLine();
                Console.WriteLine("Second number");
                number2 = Console.ReadLine();
                check1 = double.TryParse(number1, out i_check);
                check2 = double.TryParse(number2, out i_check);
                if (!check1)
                {
                    Console.WriteLine("WE NEED THOSE NUMBERS, MASON!");
                }
                if (!check2)
                {
                    Console.WriteLine("ARE YOU OUT OF YORU MIND, MASON? GIVE US DAMN NUMBERS!");
                }
            }
            double d_number1 = Convert.ToDouble(number1);
            double d_number2 = Convert.ToDouble(number2);
            // Console.WriteLine(d_number1);
            // Console.WriteLine(d_number2);
            Console.WriteLine("Finally. Now, show us the operation you need to execute");
            Console.WriteLine("Press 1 to add your numbers");
            Console.WriteLine("Press 2 to subtract your numbers");
            Console.WriteLine("Press 3 to multiply your numbers");
            Console.WriteLine("Press 4 to divide your numbers");
            string choice = Console.ReadLine();
            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                Console.WriteLine("Fine. Lets proceed to the calculations");
            }
            else
            {

                while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("WE GAVE YOU CERTAIN OPTIONS, WHAT THE FUCK IS WRONG WITH YOU? CHOOSE ONE OF THE OPTIONS ABOVE!");
                    choice = Console.ReadLine();
                }
            }
            //Console.WriteLine(choice);
            double result;
            switch(choice)
            {
                case "1":
                    result = d_number1 + d_number2;
                    Console.WriteLine("Here is the result: " + result);
                    break;
                case "2":
                    result = d_number1 - d_number2;
                    Console.WriteLine("Here is the result: " + result);
                    break;
                case "3":
                    result = d_number1 * d_number2;
                    Console.WriteLine("Here is the result: " + result);
                    break;
                case "4":
                    result = d_number1 / d_number2;
                    Console.WriteLine("Here is the result: " + result);
                    break;
            }
        }
    }
}
