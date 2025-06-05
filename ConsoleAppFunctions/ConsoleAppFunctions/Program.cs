namespace ConsoleAppFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //例
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (CheckDiv(number1, number2)) //(number1 % number2 == 0) //Make a function !
            {
                Console.WriteLine("You can devide " + number1 + " by " + number2);
            }
            else
            {
                Console.WriteLine("You can't devide " + number1 + " by " + number2);
            }
            //end of the 例


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a + b; //Make a function #1 !

            //Make a function #2 !
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + userName + "!");
            //function #2 end

            if (result % 2 == 0) //Make a function #3 !
            {
                Console.WriteLine(result + " is even");
            }
            else
            {
                Console.WriteLine(result + " is odd");
            }

            Random rnd = new Random();
            int randomNumber = rnd.Next(10); //Make a function #4 !
            Console.WriteLine("Your lucky number is " + randomNumber);
        }

        static bool CheckDiv(int a, int b)
        {
            return a % b == 0;
        }
    }
}
