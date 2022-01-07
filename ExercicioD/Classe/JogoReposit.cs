using System;
using System.Collections.Generic;
using ExercicioD.Jogo.Interface;
{
    
}
namespace ExercicioD.Jogo
{
    public class JogoReposit : IReposit<Jogo>
    {
        private List<Jogo> listaJogo = new List<Jogo>();
        public void Atualizar(int id, Jogo entidade)
        {
            listaJogo[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaJogo[id].Excluir();
        }

        public void Inserir(Jogo entidade)
        {
            listaJogo.Add(entidade);
        }

        public List<Jogo> Lista()
        {
            return listaJogo;
        }

        public int ProxId()
        {
            return listaJogo.Count;
        }

        public Jogo RetornoId(int id)
        {
            return listaJogo[id];
        }
    }
}