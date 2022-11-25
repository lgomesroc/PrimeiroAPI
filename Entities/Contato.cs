using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModoAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }     
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}