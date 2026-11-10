Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("IMPAR");
for (int i = 0; i <= num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("PAR");

for (int i = num; i >= 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
