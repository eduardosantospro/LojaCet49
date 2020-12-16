using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCet49.Dados.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }                                                         /* propriedade de leitura e escrita get: pode ler, set: pode escrever*/

        public string Nome { get; set; }

        public string Morada { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        [Display(Name = "Nº de Contribuinte")]
        public int NumContribuinte { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNasc { get; set; }

        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }

        [Display(Name = "Bom Pagador")]
        public bool BomPagador { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Crédito")]
        public double Credito { get; set; }
    }
}
