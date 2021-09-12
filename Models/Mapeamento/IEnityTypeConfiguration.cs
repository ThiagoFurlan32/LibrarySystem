using System;

namespace LibrarySystem.Models.Mapeamento
{
    public interface IEnityTypeConfiguration<T>
    {
        void Configure(Mapeamento.IEnityTypeConfiguration );
        void HasKey(Func<object, object> p);
        object Property(Func<object, object> p);
    }
}