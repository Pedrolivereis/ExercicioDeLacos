Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());
for (int d = 0; d <= num; d++)
{
    if (d % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(d);
}
