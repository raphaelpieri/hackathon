namespace HDomain.Commands
{
    public class UsuarioCommand
    {
        public UsuarioCommand(string cpf, string senha)
        {
            this.Cpf = cpf;
            this.Senha = senha;
        }
        public string Cpf { get;private set; }
        public string Senha { get; private set; }
    }
}
