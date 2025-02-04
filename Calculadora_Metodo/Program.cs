using Calculadora;

Console.Clear();

repetir:
Console.WriteLine($"Insira o primeiro valor: ");
if(!decimal.TryParse(Console.ReadLine(), out decimal valor1))
{
    Console.WriteLine("valor invalido! ");
    goto repetir;
}
 Console.WriteLine($"Insira o segundo valor: ");
 if (!decimal.TryParse(Console.ReadLine(), out decimal valor2))
{
    Console.WriteLine("valor invalido!");
    goto repetir;
}

Operacoes.RealizarAdicao(valor1, valor2);
