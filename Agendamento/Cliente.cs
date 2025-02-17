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

        public Cliente(string nome, string celular) 
        {
            Name = nome;
            Celular = celular;
        }

        public void Exibir()
        {
            Console.WriteLine($"Cliente: {Name}, Celular: {Celular}");
        }

        public override string ToString()
        {
            return $"Cliente: {Name}, Celular: {Celular}";
        }
    }
}
