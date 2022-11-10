namespace WindowsFormspPub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class jobs1
    {
        [Key]
        public short job_id { get; set; }

        [Required]
        [StringLength(50)]
        public string job_desc { get; set; }

        public byte min_lvl { get; set; }

        public byte max_lvl { get; set; }
    }
}
