using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         //Métodos
         List<T> Lista();
         T RetornaPorId(int Id);
         void Insere(T objeto);
         void Exclui(int Id);
         void Atualiza(int Id, T objeto);
         int ProximoId();

    }
}