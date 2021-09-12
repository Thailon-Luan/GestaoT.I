using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosTI.Models.Modelo
{
    [Table("Solicitacoes")]
    public class Solicitacoes 
    {
        public int id { get; set; }

        public Usuario nomeUsuarioSolicitacoes { get; set; }
        public Perifericos perifericosSolicitacoes { get; set; }


      //  public Perifericos especificacaoSolicitacoes { get; set; }
       // public Perifericos quantidadeSolicitacoes { get; set; }



    }
}
