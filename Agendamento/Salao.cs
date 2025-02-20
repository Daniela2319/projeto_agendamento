using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento
{
    public class Salao
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Servico> Servicos { get; set; } = new List<Servico>();
        public List<Agenda> Agenda { get; set; } = new List<Agenda>();

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Name}, Email: {cliente.Email}");
        }

        public void AdicionarServico(Servico servico)
        {
            Servicos.Add(servico);
            Console.WriteLine($"Serviço {servico.Nome} adicionado com sucesso!");
        }

        public void AgendarServico(Cliente cliente, Servico servico, DateTime dataHora)
        {
            var agendamento = new Agenda(cliente, servico, dataHora);
            Agenda.Add(agendamento);
            Console.WriteLine($"Agendamento realizado: {agendamento}");
        }

        public void ListaAgendamento()
        {
            Console.WriteLine("\n--- Agendamento ---");
            foreach (var agendamento in Agenda)
            {
                Console.WriteLine(agendamento.ToString());
            }
        }
    }
}
