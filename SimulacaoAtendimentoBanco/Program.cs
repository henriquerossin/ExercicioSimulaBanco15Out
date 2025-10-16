
using SimulacaoAtendimentoBanco;

using static SimulacaoAtendimentoBanco.Fila;

Fila FilaNormal = new Fila();
Fila FilaPrioritaria = new Fila();

int num = 0;

do
{

    Console.WriteLine("Escolha uma operação: ");
    Console.WriteLine("1 - Inserir novo cliente: ");
    Console.WriteLine("2 - Atender próximo cliente: ");
    Console.WriteLine("3 - Exibir filas de clientes: ");
    Console.WriteLine("4 - Encerrar o programa: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Cliente cliente = new Cliente();
            cliente.VerificarPrioridade(cliente);
            if (cliente.EPrioritario == false)
            {
                FilaNormal.CadastrarCliente(cliente);
                FilaNormal.CriarFila(cliente);
            }
            else
            {
                FilaPrioritaria.CadastrarCliente(cliente);
                FilaPrioritaria.CriarFila(cliente);
            }
            Console.WriteLine("Fila Comum: ");
            FilaNormal.MostrarFila();
            Console.WriteLine();
            Console.WriteLine("Fila Prioritária: ");
            FilaPrioritaria.MostrarFila();
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Em desenvolvimento...");
            break;
        case 3:
            Console.WriteLine("Fila Comum: ");
            FilaNormal.MostrarFila();
            Console.WriteLine();
            Console.WriteLine("Fila Prioritária: ");
            FilaPrioritaria.MostrarFila();
            Console.WriteLine();
            break;
        case 4:
            num = 4;
            break;
    }

} while (num != 4);
