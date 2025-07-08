namespace Assignment1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You will be adding two numbers input your first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number");
            int y = Convert.ToInt32(Console.ReadLine());
            int finalNumber = x + y;
            Console.WriteLine(finalNumber);

        }
    }
}
