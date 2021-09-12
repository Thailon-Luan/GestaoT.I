using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ChamadosTI.Models.Modelo
{
    [Table("Perifericos")]
    public class Perifericos
    {
        [Key]
        public int id { get; set; }


        [StringLength(25, ErrorMessage = "Tamanho de caracteres Inavalido")]
        [Display(Name = "Nome do Periférico")]
        public string nomePerifericos { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho de caracteres Inavalido")]
        [Display(Name = "Especificação")]
        public string especificacaoPerifericos { get; set; }

        [Required(ErrorMessage = "Informe  quantidade")]
        [Display(Name = "Quantidade")]
        [Range(minimum:1, maximum:8, ErrorMessage = "Minumo 1, Maximo 8")]
        public float quantidadePerifericos { get; set; }

        public ICollection<Solicitacoes> SolicitacoesPerifericos { get; set; }
        
    }
}
