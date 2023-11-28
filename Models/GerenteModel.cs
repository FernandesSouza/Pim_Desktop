using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagitarioRHDesktop.Models
{
    [Table("gerente")]
    internal class GerenteModel
    {

        [Key]
        public int idusuario { get; set; }
        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public string? usuario { get; set; }
        public string? senha { get; set; }
        public int idempresa { get; set; }

    }
}
