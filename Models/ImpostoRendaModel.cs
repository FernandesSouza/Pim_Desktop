using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SagitarioRH.Models
{
    [Table("cadImpRenda")]
    public class ImpostoRendaModel
    {
        [Key]

        public int Id { get; set; }
        public decimal VlInicial { get; set; }
        public decimal VlFinal { get; set; }
        public decimal Aliquota { get; set; }
        public decimal VlDeducao { get; set; }
    }
}
