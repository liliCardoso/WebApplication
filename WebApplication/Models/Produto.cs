using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage ="O Campo {0} é de preenchimento obrigatório!")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório!")]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório!")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O Campo {0} é de preenchimento obrigatório!")]
        public int Estoque { get; set; }

    }
}
