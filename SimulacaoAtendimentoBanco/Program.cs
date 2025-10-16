
using SimulacaoAtendimentoBanco;

using static SimulacaoAtendimentoBanco.Fila;

Banco banco = new Banco();

Fila FilaNormal = new Fila();
Fila FilaPrioritaria = new Fila();

int opcao;

do
{

    Console.WriteLine("Escolha uma operação: ");
    Console.WriteLine("1 - Inserir novo cliente: ");
    Console.WriteLine("2 - Atender próximo cliente: ");
    Console.WriteLine("3 - Exibir filas de clientes: ");
    Console.WriteLine("4 - Encerrar o programa: ");
    opcao = int.Parse(Console.ReadLine()!);

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
            break;
        case 2:
            banco.OrdemAtendimento(FilaNormal, FilaPrioritaria);
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
            Console.WriteLine("Saindo...");
            break;
    }

} while (opcao != 4);
