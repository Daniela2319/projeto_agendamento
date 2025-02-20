
using Agendamento;

//Criando objeto salão
Salao salao = new Salao();

//Adicionar o Clientes, criar objeto cliente
Cliente cliente_A = new Cliente("Frank João", "(41)9999-7878", "frank@gmail.com");
Cliente cliente_B = new Cliente("Valdemar Taborda", "(41)8888-4141", "valdemar@gmail.com");
Cliente cliente_C = new Cliente("Daniela Velter", "(41)8888-4242", "dani@gmail.com");

//Adicionar o serviço, objeto serviço
Servico manicure = new Servico("Manicure", 21.90);
Servico corteCabelo = new Servico("Corte de Cabelo", 30.0);
Servico progressiva = new Servico("Progressiva", 210.99);

//Agenda o serviço
salao.AgendarServico(cliente_A, corteCabelo, new DateTime(2025, 02, 20, 14, 3, 2));
salao.AgendarServico(cliente_B, manicure, new DateTime(2025, 02, 22, 17, 4, 2));
salao.AgendarServico(cliente_C, progressiva, new DateTime(2025, 02, 25, 13, 0, 0));

// Listando agendamento
salao.ListaAgendamento();




