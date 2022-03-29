using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem
{
    class ROLE
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        [Key]
        public int Role_ID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string Role_Name { get; set; }

        public ICollection<USERS> USERS { get; set; }

    }
}
