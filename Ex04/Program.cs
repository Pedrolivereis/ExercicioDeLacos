Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());
for (int d = 1; d <= num; d++)
{
    
    if (d % 1 == 0 && i % d == 0)
    {
        Console.WriteLine(d);
    }
    
}
