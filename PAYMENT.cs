/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class PAYMENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Payment_ID { get; set; }
        public int Invoice_ID { get; set;}
        public int Paid_Amount { get; set; }
        public string Payment_Date { get; set; }
    }
}
*/