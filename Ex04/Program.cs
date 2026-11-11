int contador = 0;
int numero;
Console.WriteLine("Informe o numero desejado: ");
numero = int.Parse(Console.ReadLine());
for (int i = 2; i <= numero; i++)
{
    contador = 0;
    for (int j = i; j >= 2; j--)
    {
        if (i % j == 0)
        {
            contador++;
        }
        if (contador > 1)
        {
            break;
        }
    }
    if (contador <= 1)
    {
        Console.WriteLine(i);
    }
}
