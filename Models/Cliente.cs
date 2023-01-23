using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapMarketPlace.Models
{
    [Table("Cadastro de Clientes")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "N° ID")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "EMAIL")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }


    }
}
