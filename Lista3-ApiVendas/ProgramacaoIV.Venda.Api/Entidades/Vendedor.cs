using System.ComponentModel.DataAnnotations;

namespace ProgramacaoIV.Venda.Api.Entidades
{
    public class Vendedor : AbstractEntity
    {

        public string Nome { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string Email { get; set; } = string.Empty;

        public Vendedor(string nome, string email) {
            Nome = nome.ToUpper() ?? throw new ArgumentNullException(nameof(nome));
            Email = email.ToUpper() ?? throw new ArgumentNullException(nameof(email));
        }
    }
}
