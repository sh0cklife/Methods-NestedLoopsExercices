static int CalculateFactorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }
    return fact;
}


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int factA = CalculateFactorial(a);
int factB = CalculateFactorial(b);
Console.WriteLine(factA / factB);
