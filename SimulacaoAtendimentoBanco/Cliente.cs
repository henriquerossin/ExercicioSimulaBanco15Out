using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoAtendimentoBanco
{
    public class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EPrioritario { get; set; }
        public Cliente Proximo { get; set; }

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

        public Cliente()
        {
            this.Proximo = null;
        }
    }
}
