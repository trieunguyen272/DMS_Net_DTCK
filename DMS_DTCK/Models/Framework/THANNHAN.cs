namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANNHAN")]
    public partial class THANNHAN
    {
        [Key]
        public int MATHANNHAN { get; set; }

        [StringLength(10)]
        public string MASV { get; set; }

        [Required]
        [StringLength(50)]
        public string HOTENCHA { get; set; }

        [Required]
        [StringLength(50)]
        public string NGHENGHIEPCHA { get; set; }

        [Required]
        [StringLength(10)]
        public string SDTCHA { get; set; }

        [Required]
        [StringLength(50)]
        public string HOTENME { get; set; }

        [Required]
        [StringLength(50)]
        public string NGHENGHIEPME { get; set; }

        [Required]
        [StringLength(10)]
        public string SDTME { get; set; }

        public bool THANNHANSVNT { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
