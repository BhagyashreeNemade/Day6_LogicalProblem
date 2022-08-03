namespace Day6_LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day6_LogicalProblem");

            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeNumber.PrimeNum(num);

        }
    }
}