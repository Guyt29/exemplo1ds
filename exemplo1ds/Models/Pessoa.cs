using System.ComponentModel.DataAnnotations;

namespace exemplo1ds.Models
{
    public class Pessoa
    {
       [Display(Name = "Código do cliente")]
       public int PessoaId { get; set; } // get vai servir para fazer consultas e retorna o valor atual de um atributo e set permite definir ou modificar os valores de um atributo (get pega e set determina) metodos
        [Display(Name = "Nome do cliente")]
       public string? Nome { get; set; }
        [Display(Name = "Email do cliente")]
       public string? Email { get; set; }
    }
}
