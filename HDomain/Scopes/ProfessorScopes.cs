using HDomain.Entities;
using HSharedKernel.Validation;

namespace HDomain.Scopes
{
    public static class ProfessorScopes
    {
        public static bool AutenticarProfessor(this Professor professor, string cpf, string senha)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertAreEquals(professor.Cpf, cpf, "Login errado"),
                AssertionConcern.AssertAreEquals(professor.Senha, senha, "Cpf invalido")
            );
        }
    }
}
