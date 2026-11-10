Console.WriteLine("Digite um numero inteiro");
int num = int.Parse(Console.ReadLine());
int contador = 0;
for (int i = 0; i <= num; i++)
{
    contador = contador + i;
    Console.WriteLine(contador);
}