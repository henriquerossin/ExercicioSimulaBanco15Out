using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoResolvidaEmSala
{
    internal class Cliente
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool EPrioritario { get; set; }
        public Cliente Proximo { get; set; }

        public Cliente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            this.Proximo = null;
            if (this.Idade > 59)
            {
                this.EPrioritario = true;
            }
            else
            {
                this.EPrioritario = false;
            }
        }

        public override string ToString()
        {
            return
                $"Nome: {this.Nome}, " +
                $"\nIdade: {this.Idade}, " +
                $"\nPrioritário: " + (this.EPrioritario ? "Sim" : "Não");
        }
    }
}
