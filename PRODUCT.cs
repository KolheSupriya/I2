/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem
{
    class PRODUCT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Product_ID { get; set; }
        [Required]
        public string Product_Type { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public int Current_Storage { get; set; }
        [Required]
        public int Sold { get; set; }
        [Required]
        public int Remaining_Quantity { get; set; }
        [Required]
        public int Unit_Price { get; set; }
        [Required]
        public int Total_Selling_Amount { get; set; }

    }
}
*/