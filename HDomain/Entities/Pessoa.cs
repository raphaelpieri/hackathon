using System;
using HDomain.Enums;

namespace HDomain.Entities
{
    public abstract class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string cpf, string nome, string email, string senha)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
        public int Id { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public TipoPessoa Tipo { get; protected set; }

        public void Autenticar(string login, string senha)
        {
            if (this.ModoDeAutenticacao(login, senha))
                return;
        }

        public void AlterarTipo(TipoPessoa novoTipo)
        {
            this.Tipo = novoTipo;
        }

        protected abstract bool ModoDeAutenticacao(string login, string senha);
    }
}
