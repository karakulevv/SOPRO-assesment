using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOPRO.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Period Period { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal CurrencyAmount { get; set; }

        [Required]
        public string CurrencyName { get; set; }

        public Union Union { get; set; }

    }
}
