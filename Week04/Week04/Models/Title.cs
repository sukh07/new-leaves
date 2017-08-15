namespace Week04.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Title
    {
        [Key]
        [StringLength(50)]
        public string ISBN { get; set; }

        public int? PubID { get; set; }

        [Column("title")]
        [StringLength(50)]
        public string title1 { get; set; }

        public int? yearPub { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string topic { get; set; }

        [StringLength(50)]
        public string comments { get; set; }

        [Column(TypeName = "money")]
        public decimal? costPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? retailPrice { get; set; }

        public int? nolnStock { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
