using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCet49.Dados.Entidades
{
    public class Produto
    {
        public int Id { get; set; }                                                         /* propriedade de leitura e escrita get: pode ler, set: pode escrever*/


        public string Nome { get; set; }


        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]         /* Formatação moeda (currency) que não mostra na edição*/
        public decimal Preco { get; set; }


        [Display(Name = "Image")]
        public string UrlDaImagem { get; set; }


        [Display(Name = "Última compra")]
        public DateTime UltimaCompra { get; set; }


        [Display(Name = "Última venda")]
        public DateTime UltimaVenda { get; set; }


        [Display(Name = "Disponibilidade")]
        public bool Disponivel { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
    }
}
