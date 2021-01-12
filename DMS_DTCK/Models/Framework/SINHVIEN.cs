namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            HOPDONGs = new HashSet<HOPDONG>();
            THANNHANs = new HashSet<THANNHAN>();
        }

        [Key]
        [StringLength(10)]
        public string MASV { get; set; }

        [Required]
        [StringLength(200)]
        public string MATKHAU { get; set; }

        [Required]
        [StringLength(30)]
        public string HOTENLOT { get; set; }

        [Required]
        [StringLength(20)]
        public string TEN { get; set; }

        [Required]
        [StringLength(50)]
        public string HOVATEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        public bool GIOITINH { get; set; }

        [Required]
        [StringLength(50)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(20)]
        public string CMND { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(30)]
        public string LOP { get; set; }

        [Required]
        [StringLength(30)]
        public string KHOA { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        public bool SVNOITRU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANNHAN> THANNHANs { get; set; }
    }
}
