namespace exemplo1ds.Models
{
    public class Pessoa
    {
       public int PessoaId { get; set; } // get vai servir para fazer consultas e retorna o valor atual de um atributo e set permite definir ou modificar os valores de um atributo (get pega e set determina) metodos 
       public string? Nome { get; set; } 
       public string? Email { get; set; }
    }
}
