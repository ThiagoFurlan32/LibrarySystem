using LibrarySystem.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models.Mapeamento
{
    public class ClienteMap : IEnityTypeConfiguration<Cliente>
    {
        public void Configure(IEnityTypeConfiguration<Cliente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).ValueGeneratedOnAdd();
            builder.Property(p => p.nome).HasMaxLength(35).IsRequired();
            builder.Property(p => p.cpf).HasMaxLenght(14).IsRequires();
            builder.Property(p => p.plano).HasMaxLength(14).IsRequires();
            builder.Property(p => p.movimentacao).HaMaxLength(35).IsRequires();

        }



    }  
        
 }
