using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC2.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo descrição é obrigatório")]

        public string Descricao { get; set; }
        [Range(1,10,ErrorMessage ="Valor fora da faixa")]

        public List <Produto> Produtos { get; set; }
    }
}


