namespace SimulacaoResolvidaEmSala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fila dos bancos");
            Banco banco = new Banco();
            int opcao;

            void MostrarFilas()
            {
                Console.WriteLine();
                Console.WriteLine("Fila Prioritária: ");
                banco.FilaPrioritaria.MostrarFila();
                Console.WriteLine();
                Console.WriteLine("Fila Normal: ");
                banco.FilaNormal.MostrarFila();
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("1 - Adicionar: ");
                Console.WriteLine("2 - Atender: ");
                Console.WriteLine("3 - Mostrar fila: ");
                Console.WriteLine("4 - Sair: ");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do cliente: ");
                        string nome = Console.ReadLine()!;
                        Console.WriteLine("Informe a idade do cliente: ");
                        int idade = int.Parse(Console.ReadLine()!);

                        Cliente cliente = new(nome, idade);

                        if (cliente.EPrioritario)
                        {
                            banco.FilaPrioritaria.Enfileirar(cliente);
                        }
                        else
                        {
                            banco.FilaNormal.Enfileirar(cliente);
                        }
                        MostrarFilas();
                        break;
                    case 2:
                        cliente = banco.AtenderCliente();
                        if (cliente is null)
                        {
                            Console.WriteLine("Não há clientes na fila!");
                            break;
                        }
                        else
                            Console.WriteLine(cliente.ToString());
                        MostrarFilas();
                        break;
                    case 3:
                        MostrarFilas();
                        break;
                    case 4:
                        Console.WriteLine("Saindo.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (true);

        }
    }
}
