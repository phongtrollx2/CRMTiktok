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
    [Table("Users")]
    public class User : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        [MinLength(6)]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { set; get; }
    }
}
