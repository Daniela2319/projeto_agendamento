using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento
{
    public class Menu
    {

        private Salao _salao = new Salao();

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU DO SALÃO ===");
                Console.WriteLine("1 - Adicionar Cliente");
                Console.WriteLine("2 - Adicionar Serviço");
                Console.WriteLine("3 - Agendar Serviço");
                Console.WriteLine("4 - Listar Agendamentos");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarCliente();
                        break;
                    case "2":
                        AdicionarServico();
                        break;
                    case "3":
                        AgendarServico();
                        break;
                    case "4":
                        ListarAgendamentos();
                        break;
                    case "5":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void AdicionarCliente()
        {
            Console.Write("\nNome do Cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Celular: ");
            string celular = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(nome, celular, email);
            _salao.AdicionarCliente(cliente);

            Console.WriteLine("\nCliente adicionado com sucesso!");
        }

        private void AdicionarServico()
        {
            Console.Write("\nNome do Serviço: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Servico servico = new Servico(nome, preco);
            _salao.AdicionarServico(servico);

            Console.WriteLine("\nServiço adicionado com sucesso!");
        }
        private void AgendarServico()
        {
            Console.Write("\nNome do Cliente: ");
            string nomeCliente = Console.ReadLine();
            Cliente cliente = _salao.Clientes.FirstOrDefault(c => c.Name == nomeCliente);

            Console.Write("Nome do Serviço: ");
            string nomeServico = Console.ReadLine();
            Servico servico = _salao.Servicos.FirstOrDefault(s => s.Nome == nomeServico);

            if (cliente != null && servico != null)
            {
                Console.Write("Data e Hora (yyyy-MM-dd HH:mm): ");
                DateTime dataHora;

                if (DateTime.TryParse(Console.ReadLine(), out dataHora))
                {
                    _salao.AgendarServico(cliente, servico, dataHora);
                    Console.WriteLine("\nAgendamento realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nFormato de data inválido. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("\nCliente ou serviço não encontrado. Certifique-se de adicioná-los antes de agendar.");
            }
        }


        private void ListarAgendamentos()
        {
            Console.WriteLine("\n=== Agendamentos ===");
            _salao.ListaAgendamento();
        }
    }
}
