using Database.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    [Table("Customers")]
    public class Customer : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Phone { get; set; }

        [MaxLength(250)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }

        [MaxLength(250)]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }

        [ForeignKey("CategoryId")]
        public virtual CustomerCategory CustomerCategory { set; get; }
    }
}
