using System.ComponentModel.DataAnnotations;

namespace APICsharp.Models
{
    public class Cateogry
    {
        [Key]

        public int Id {get; set;}

        [Required(ErrorMessage="Esse é um campo obrigatório")]
        [MaxLength(60,ErrorMessage="Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3,ErrorMessage="Este campo deve conter entre 3 e 60 caracteres")]

        public string Title {get; set;}
    }
}