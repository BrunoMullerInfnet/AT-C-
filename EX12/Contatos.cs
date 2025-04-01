
namespace EX12
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
        public static Contatos FromString(string linha)
        {
            var partes = linha.Split('|');

            return new Contatos(partes[0].Replace("Nome:","").Trim(), partes[1].Replace("Telefone:","").Trim(),
                partes[2].Replace("Email:","").Trim());
        }

    }
}
