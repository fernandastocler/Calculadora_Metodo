class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nCalculadora - Escolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    continuar = false;
                    Console.WriteLine("Encerrando a calculadora. Até mais!");
                    break;
                }

                decimal valor1 = Operacoes.ObterValor();
                decimal valor2 = Operacoes.ObterValor();

                switch (opcao)
                {
                    case "1":
                        Operacoes.Adicao(valor1, valor2);
                        break;
                    case "2":
                        Operacoes.Subtracao(valor1, valor2);
                        break;
                    case "3":
                        Operacoes.Multiplicacao(valor1, valor2);
                        break;
                    case "4":
                        Operacoes.Divisao(valor1, valor2);
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
