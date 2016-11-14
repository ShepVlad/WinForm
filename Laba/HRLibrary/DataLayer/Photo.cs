namespace HRLibrary.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Photo")]
    public partial class Photo
    {
        public int PhotoId { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(256)]
        public string PathPhoto { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
