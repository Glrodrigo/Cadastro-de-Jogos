using System.Collections.Generic;
namespace ExercicioD.Interface
{
    public interface IReposit<T>
    {
         List<T> Lista();
         T RetornoId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atalizar(int id, T entidade);
        int ProxId();
    }
}