int numero = 0;
int fibo = 0;
int f1 = 0;
int f2 = 1;
Console.WriteLine("Digite um numero inteiro: ");
numero = int.Parse(Console.ReadLine());
for (int i = 1; i <= numero; i++)
{
    fibo = f1 + f2;
    f1 = f2;
    f2 = fibo;
    Console.WriteLine(fibo);
}
