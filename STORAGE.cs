/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem
{
    class STORAGE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Storage_ID { get; set; }
        [Required]
        [ForeignKey("productList")]
        public int Product_List_ID { get; set; }
        public ProductList productList { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string SubProduct_Name { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; } = DateTime.Now;
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string Description { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Current_Storage { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Sold { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Remaining_Quantity { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Unit_Price { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Total_Selling_Amount { get; set; }

        public ICollection<ProductSubcategory> PRODUCT_SUBCATEGORY { get; set; }
    }
}
*/