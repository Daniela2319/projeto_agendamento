using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Agendamento
{
    public class Servico
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Servico(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Serviço: {Nome}, Preço: R$ {Preco:F2}";
        }
    }
}
