using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio_Quartos_Pousada
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
