using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Classe responsável por representar a entidade de cliente
    /// </summary>
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }
    }
}
