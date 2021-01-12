namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            DIENNUOCs = new HashSet<DIENNUOC>();
            HDDIENNUOCs = new HashSet<HDDIENNUOC>();
            HOPDONGs = new HashSet<HOPDONG>();
        }

        [Key]
        [StringLength(20)]
        public string MAPHONG { get; set; }

        public int SOPHONG { get; set; }

        [StringLength(10)]
        public string MAKHU { get; set; }

        public int SOLUONGSV { get; set; }

        public double GIAPHONG { get; set; }

        public int SOCHOTRONG { get; set; }

        [Required]
        [StringLength(200)]
        public string MOTAKHAC { get; set; }

        public bool TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIENNUOC> DIENNUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDDIENNUOC> HDDIENNUOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        public virtual KHUNHA KHUNHA { get; set; }
    }
}
