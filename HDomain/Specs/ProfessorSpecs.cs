namespace HDomain.Specs
{
    using Entities;
    using System;
    using System.Linq.Expressions;
    public class ProfessorSpecs
    {
        public static Expression<Func<Professor, bool>> AutenticarUsuarios(string cpf, string senha)
        {
            return x => x.Cpf.Equals(cpf) && x.Senha.Equals(senha);
        }
    }
}
