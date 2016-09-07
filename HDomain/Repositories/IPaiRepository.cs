namespace HDomain.Repositories
{
    using HDomain.Entities;
    public interface IPaiRepository
    {
        Pessoa AutenticarPai(string cpf, string senha);
    }
}
