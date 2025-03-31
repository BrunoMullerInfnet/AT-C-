namespace EX11
{
    public class Contatos
    {
        public string nome;
        public string numero;
        public string email;

        public Contatos(string nome, string numero, string email)
        {
            this.nome = nome;
            this.numero = numero;
            this.email = email;
        }

        public (bool, string) verificarNumero()
        {
            numero = numero.Replace("-", "");

            if (!long.TryParse(numero, out _) || numero.Length != 9)
            {
                return (false, numero);
            }

            numero = numero.Insert(5, "-");
            return (true, numero);
        }

        public bool verificarEmail()
        {
            if (!email.Contains("@") && !email.Contains(".com"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
