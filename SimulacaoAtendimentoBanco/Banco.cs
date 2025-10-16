using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SimulacaoAtendimentoBanco.Fila;

namespace SimulacaoAtendimentoBanco
{
    public class Banco
    {

        Fila FilaNormal = new Fila();
        Fila FilaPrioritaria = new Fila();
        private int count = 0;

        public void OrdemAtendimento(Fila FilaNormal, Fila FilaPrioritaria)
        {
            if (count < 2)
            {
                if (FilaNormal.Vazia() && FilaPrioritaria.Vazia())
                {
                    Console.WriteLine("Não há clientes para serem atendidos.");
                    return;
                }
                else if (FilaNormal.Vazia())
                {
                    FilaPrioritaria.Desenfileirar();
                    count = 0;
                    return;
                }
                else if (FilaPrioritaria.Vazia())
                {
                    FilaNormal.Desenfileirar();
                    count++;
                    return;
                }
                FilaNormal.Desenfileirar();
                count++;
            }
            else
            {
                FilaPrioritaria.Desenfileirar();
                count = 0;
            }
        }
    }
}
