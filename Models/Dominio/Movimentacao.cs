using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Dominio
{
    public enum TipoMovimento {Venda, Empréstimo}

    [Table("Movimentacao")]
    public class Movimentacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [Display(Name = "Cliente")]
        public Cliente cliente { get; set; }

        [Display(Name = "Livro")]
        public Livro livro { get; set; }

        [Required(ErrorMessage = "Campo Quantidade é obrigatório")]
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }

        [Display(Name = "TipoMovimento")]
        public TipoMovimento movimento { get; set; }
    }
}
