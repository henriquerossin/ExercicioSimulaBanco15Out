using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAtendimentoBanco
{
    public class Fila
    {
        private Cliente head;
        private Cliente tail;

        public Fila()
        {
            head = null;
            tail = null;
        }

        public Cliente CadastrarCliente(Cliente cliente)
        {
            Console.Write("Informe o nome do novo cliente");
            cliente.Nome = Console.ReadLine()!;
            Console.Write("Informe a idade do cliente: ");
            cliente.Idade = int.Parse(Console.ReadLine()!);

            return cliente;
        }

        public Cliente VerificarPrioridade(Cliente cliente)
        {
            Console.Write("O Cliente é prioritário? (Sim/Não): ");
            string tipoCliente = Console.ReadLine()!;

            if (tipoCliente == "Sim")
                cliente.EPrioritario = true;
            else
                cliente.EPrioritario = false;
            return cliente;
        }

        public void CriarFila(Cliente cliente)
        {
                if (head == null)
                {
                    head = tail = cliente;
                }
                else
                {
                    tail.Proximo = cliente;
                    tail = cliente;
                }
        }

        public void Desenfileirar(Cliente cliente)
        {
            if (head == null)
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                head = head.Proximo;
                if (head == null)
                    tail = null;
            }
        }

        public void MostrarFila()
        {
            if (head == null)
            {
                Console.WriteLine("Fila Vazia");
                return;
            }

            Cliente aux = head;
            while (aux != null)
            {
                Console.WriteLine(aux.Nome);
                aux = aux.Proximo;
            }
        }
    }
}
