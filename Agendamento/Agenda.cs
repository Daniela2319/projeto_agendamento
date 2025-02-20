using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agendamento
{
    public class Agenda
    {
        public Cliente Cliente { get; set; }
        public Servico Servico { get; set; }
        public DateTime DataHora { get; set; }

        public Agenda(Cliente cliente, Servico servico, DateTime dataHora)
        {
            Cliente = cliente;
            Servico = servico;
            DataHora = dataHora;
        }

        public override string ToString()
        {
            return $"Agendamento {Cliente.Name} -  {Servico.Nome} em  {DataHora:dd/MM/yyyy HH:mm}";
        }
    }
}