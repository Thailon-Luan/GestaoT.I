using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosTI.Models.Modelo
{
    [Table("Chamado")]
    public class Chamados 
    {
       
        public int id { get; set; }
        public Usuario usuariosnomeUsuario { get; set; }


        public string Identificacao { get; set; }
        // public Usuario setornomeUsuario { get; set; }
        [Required(ErrorMessage = "Informe a Descrição")]
        public string descricaoChamados { get; set; }


    }
}
