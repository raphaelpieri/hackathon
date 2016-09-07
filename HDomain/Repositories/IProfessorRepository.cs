namespace HDomain.Repositories
{
    using HDomain.Entities;
    public interface IProfessorRepository
    {
        Pessoa AutenticarProfessor(string cpf, string senha);
    }
}
