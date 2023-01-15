class Program
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            PrintMinAndMax(num2, num1);
        }
        else
        {
            PrintMinAndMax(num1, num2);
        }
    }

    static void PrintMinAndMax(int min, int max)
    {
        Console.WriteLine("min = {0}, max = {1}", min, max);
    }
}
