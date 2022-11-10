namespace WindowsFormspPub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roysched1
    {
        [Key]
        [StringLength(6)]
        public string title_id { get; set; }

        public int? lorange { get; set; }

        public int? hirange { get; set; }

        public int? royalty { get; set; }

        public virtual Title titles { get; set; }
    }
}
