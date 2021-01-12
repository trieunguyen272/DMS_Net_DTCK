namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [Key]
        public int MAHOPDONG { get; set; }

        [StringLength(10)]
        public string MASV { get; set; }

        [StringLength(20)]
        public string MAPHONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYLAP { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBATDAU { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYKETTHUC { get; set; }

        public bool HIEULUCHD { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
