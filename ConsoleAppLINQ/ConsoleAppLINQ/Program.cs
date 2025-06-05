namespace hehe12;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int result = 0;

        while (true)
        {
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                result = a / b;
                Console.WriteLine(result);

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong input");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cant devide by zero ");
            }
        }
    }
}