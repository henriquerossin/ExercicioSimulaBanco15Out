using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacaoResolvidaEmSala
{
    internal class Banco
    {
        public Fila FilaNormal { get; set; }
        public Fila FilaPrioritaria { get; set; }
        public int contador { get; set; }

        public Banco()
        {
            this.FilaNormal = new Fila();
            this.FilaPrioritaria = new Fila();
            this.contador = 0;
        }

        public Cliente AtenderCliente()
        {
            if (this.FilaNormal.Vazia() && this.FilaPrioritaria.Vazia())
            {
                return null;
            }
            else
            {
                if (this.FilaPrioritaria.Vazia())
                {
                    return this.FilaNormal.Desenfileirar();
                }
                else if (this.FilaNormal.Vazia())
                {
                    return this.FilaPrioritaria.Desenfileirar();
                }
                else
                {
                    if (this.contador % 3 == 0)
                    {
                        this.contador++;
                        return this.FilaPrioritaria.Desenfileirar();
                    }
                    else
                    {
                        this.contador++;
                        return this.FilaNormal.Desenfileirar();
                    }
                }
            }
        }
    }
}
