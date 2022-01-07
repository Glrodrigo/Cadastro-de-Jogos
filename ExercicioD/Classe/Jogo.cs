
namespace ExercicioD.Jogo
{
    public class Jogo : EntidadeB
    {
        private Tipo Tipo { get; set; }
        private string Nome { get; set; }
        private string Descrever { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Jogo(int id, Tipo tipo, string nome, string descrever, int ano)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Descrever = descrever;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo: " + this.Tipo + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Descrição: " + this.Descrever + Environment.NewLine;
            retorno += "Lançamento: " + this.Ano;
            return retorno;
        }

        public string retNome()
        {
            return this.Nome;
        }

        public int retId()
        {
            return this.Id;
        }

        public bool RetornExcluido()
        {
            return this.Excluido;
        }
        
        public void Excluir()
        {
            this.Excluido = true;
        }
    }

}