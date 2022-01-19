namespace HelloDIO.Interfaces
{
    public interface IPessoa
    {
        string ObterEmaileTelefone();
        void SetTelefone(string telefone);
        void SetEmail(string email);

    }
}