namespace MVCCodebasedTestQuestion2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieID { get; set; }

        [StringLength(50)]
        public string Moviename { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfRelease { get; set; }

        [StringLength(50)]
        public string MovieType { get; set; }
    }
}
