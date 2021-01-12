namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIENNUOC")]
    public partial class DIENNUOC
    {
        [Key]
        public int MADIENNUOC { get; set; }

        [StringLength(20)]
        public string MAPHONG { get; set; }

        [StringLength(10)]
        public string MAQL { get; set; }

        public int THANG { get; set; }

        public int NAM { get; set; }

        public int CHISODIEN { get; set; }

        public int CHISONUOC { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual QUANLY QUANLY { get; set; }
    }
}
