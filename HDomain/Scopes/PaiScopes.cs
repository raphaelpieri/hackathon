using HDomain.Entities;
using HSharedKernel.Validation;

namespace HDomain.Scopes
{
    public static class PaiScopes
    {
        public static bool AutenticarPai(this Pai pai, string cpf, string senha)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertAreEquals(pai.Cpf, cpf, "Cpf invalido"), 
                AssertionConcern.AssertAreEquals(pai.Senha, senha, "Senha invalido")
            );
        }
    }
}
