
using Agendamento;

Cliente cliente = new Cliente("Maria", "(41)9999-6677", "maria@gmail.com");
cliente.Exibir();

Servico servico = new Servico("Manicure", 19.90);
servico.Exibir();

Agenda agenda = new Agenda(cliente, servico, new DateTime(2025, 03, 01, 14, 0, 0));

agenda.Exibir();