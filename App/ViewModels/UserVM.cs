using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(128)]
        [MinLength(6)]
        public string Password { get; set; }

        [MaxLength(256)]
        public string FullName { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }

    }
}
