using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    public class Plano
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float porcen_desconto { get; set; }

        public ICollection<Cliente> cliente { get; set; }
    }
}
