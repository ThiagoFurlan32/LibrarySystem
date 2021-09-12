using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    public enum TipoMovimento {Venda, Empréstimo}
    public class Movimentacao
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Livro livro { get; set; }
        public int quantidade { get; set; }
        public TipoMovimento movimento { get; set; }
        public float preco { get; set; }
    }
}
