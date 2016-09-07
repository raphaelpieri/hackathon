using HDomain.Entities;
using System;
using System.Linq.Expressions;

namespace HDomain.Specs
{
    public class PaiSpecs
    {
        public static Expression<Func<Pai, bool>> AutenticarPai(string cpf, string senha)
        {
            return x => x.Cpf.Equals(cpf) && x.Senha.Equals(senha);
        }
    }
}
