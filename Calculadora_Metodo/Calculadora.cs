namespace Calculadora
{
    class Operacoes
    {
        public static decimal ObterValor()
        {
         repetir:
          Console.Write("Informe  o valor: ");
          if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
          {
            Console.WriteLine("Valor inválido! ");
            goto repetir;
          }   
          else
          {
            return valor;
          } 
        }
        public static void Adicao(decimal valor1, decimal valor2)
    {
        Console.WriteLine ($"A somas dos valores é: {valor1 + valor2} ");
                }
    }
}