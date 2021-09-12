using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    public class Livro
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }

        public ICollection<Movimentacao> movimentacao { get; set; }
    }
}
