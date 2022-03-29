using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Invoice_ID	Customer_ID	Unit_Sold	Total_Price
1	123	600	210000
2	123	300	90000
*/
namespace InventoryManagementSystem
{
    class INVOICE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Invoice_ID { get; set; }
        [Required]
        [MaxLength(4, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Customer_ID { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Unit_Sold { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Total_Price { get; set; }
        [Required]
        public DateTime Payment_Date { get; set; }

        public ICollection<SHIPPING> SHIPPING { get; set; }
    }
}
