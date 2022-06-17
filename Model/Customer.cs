namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public int CategoryId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool Status { get; set; }

        public virtual CustomerCategory CustomerCategory { get; set; }
    }
}
