using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento
{
    public class Cliente
    {
        public string Name { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string celular, string email) 
        {
            Name = nome;
            Celular = celular;
            Email = email;
        }

        public void Exibir()
        {
            Console.WriteLine($"Cliente: {Name}, Celular: {Celular}, Email: {Email}");
        }

        public override string ToString()
        {
            return $"Cliente: {Name}, Celular: {Celular}, Email: {Email}";
        }
    }
}
