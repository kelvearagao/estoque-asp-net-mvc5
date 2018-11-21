using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaelumEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(20)]
        public String Nome { get; set; }

        [Range(0.0, 10000.0)]
        public float Preco { get; set; }

        public CategoriaDoProduto Categoria { get; set; }

        public int? CategoriaId { get; set; }

        [Required]
        public String Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}