int max = Convert.ToInt32(Console.ReadLine());
int num;

for (int i = 0; i < 2; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > max)
    {
        max = num;
    }
}

Console.WriteLine(max);