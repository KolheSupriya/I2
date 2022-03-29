using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Product_ID	Invoice_ID	Product_Type(optional)	Customer_ID	Sold_Quantity	Shipping_Date	Shipped_From	Shipped_To	Total_Price
1	1	iphone	123	300	26-03-22	Mumbai	Pune	90000
2	1	ipad	123	300	26-03-22	Mumbai	Pune	120000
2	2	ipod	123	300	26-03-22	Mumbai	Kolkata	90000
*/
namespace InventoryManagementSystem
{
    class SHIPPING
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]

        public int Shipping_ID { get; set; }
        [Required]
        public int Product_ID { get; set; }
        [ForeignKey("Product_ID")]
        public virtual Products Product { get; set; }


        [Required]
        public int Invoice_ID { get; set; }
        [ForeignKey("Invoice_ID")]
        public virtual INVOICE INVOICE { get; set; }


        [Required]
        [MaxLength(4, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Customer_ID { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(1, ErrorMessage = "{0} length must be above {2}.")]
        public int Sold_Quantity { get; set; }
        [Required]
        
        public DateTime Shipping_Date { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string Shipped_From { get; set;}
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string Shipped_To { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public int Total_Price { get; set; }
    }
}
