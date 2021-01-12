namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDDIENNUOC")]
    public partial class HDDIENNUOC
    {
        [Key]
        public int MAHOADON { get; set; }

        [StringLength(20)]
        public string MAPHONG { get; set; }

        [StringLength(10)]
        public string MAQL { get; set; }

        public int THANG { get; set; }

        public int NAM { get; set; }

        public int CHISODIENCU { get; set; }

        public int CHISODIENMOI { get; set; }

        public int? MADGDIEN { get; set; }

        public double TIENDIEN { get; set; }

        public int CHISONUOCCU { get; set; }

        public int CHISONUOCMOI { get; set; }

        public int? MADGNUOC { get; set; }

        public double TIENNUOC { get; set; }

        public double TONGTIEN { get; set; }

        public bool TRANGTHAITHANHTOAN { get; set; }

        public virtual DGDIEN DGDIEN { get; set; }

        public virtual DGNUOC DGNUOC { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual QUANLY QUANLY { get; set; }
    }
}
