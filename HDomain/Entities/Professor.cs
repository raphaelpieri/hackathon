namespace HDomain.Entities
{
    using System;
    using HDomain.Enums;
    using Scopes;

    public class Professor : Pessoa
    {
        public Professor() { }
        public Professor(string cpf, string nome, string email, string password) : base(cpf, nome, email, password)
        {
            this.Tipo = TipoPessoa.Professor;
        }

        protected override bool ModoDeAutenticacao(string login, string senha)
        {
            return this.AutenticarProfessor(login, senha);
        }
    }
}
