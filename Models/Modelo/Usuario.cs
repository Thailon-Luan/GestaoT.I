using IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChamadosTI.Models.Modelo
{

   
    public class Usuario
    {

       
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho de caracteres Inavalido")]
        [Required(ErrorMessage ="Informe o Nome")]
        [Display(Name = "Nome do Usuário")]
        public string nomeUsuario { get; set; }

        [StringLength(25, ErrorMessage = "Tamanho de caracteres Inavalido")]
        [Display(Name = "Tipo de Máquina")]
        public string maquinaUsuario { get; set; }

        [StringLength(12, ErrorMessage = "Tamanho de caracteres Inavalido")]
        [Display(Name = "Setor")]
        public string setorUsuario { get; set; }



        public string email { get; set; }

        //lembrar da relação do usuario com demais eventos
        //um usuario pode ter demais eventos 1/N

        public ICollection<Chamados> chamados{ get; set; }
        //relacionamento entre usuario e chamados

        public ICollection<Solicitacoes> solicitacoes { get; set; }


    }
}
