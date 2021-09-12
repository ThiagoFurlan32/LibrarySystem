using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public int rg { get; set; }
        public int cep { get; set; }
        public Plano Plano { get; set; }

        public ICollection<Movimentacao> movimentacao { get; set; }
    }
}
