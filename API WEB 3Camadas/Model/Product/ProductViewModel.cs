using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Product
{
    [Table("TB_PRODUTO")]
    
    public class ProductViewModel
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name="Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }
    }
}
