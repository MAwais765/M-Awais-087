using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M_Awais_087.Models
{
    public class Order
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        [Required]
        [Display(Name ="Item Name")]
        [StringLength(25, MinimumLength =5)]
        public string ProductName { get; set; }
        [Required]
        public int ProductQty { get; set; }
        [Required]
        public Decimal ProductPrice { get; set; }
        [Display(Name = "Address")]
        [StringLength(25, MinimumLength = 5)]
        public string Address { get; set; }
    }
}
