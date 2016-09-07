namespace HDomain.Entities
{
    using System;
    using HDomain.Enums;
    using Scopes;

    public class Pai : Pessoa
    {
        public Pai() { }
        public Pai(string cpf, string nome, string email, string password) : base(cpf, nome, email, password)
        {
            this.Tipo = TipoPessoa.Pai;
        }

        protected override bool ModoDeAutenticacao(string login, string senha)
        {
            return this.AutenticarPai(login, senha);
        }
    }
}
