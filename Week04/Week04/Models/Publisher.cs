namespace Week04.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Publisher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publisher()
        {
            Titles = new HashSet<Title>();
        }

        [Key]
        public int PubID { get; set; }

        [StringLength(50)]
        public string companyName { get; set; }

        [StringLength(50)]
        public string contactFName { get; set; }

        [StringLength(50)]
        public string contctSName { get; set; }

        [StringLength(50)]
        public string pubStreet { get; set; }

        [StringLength(50)]
        public string putSuburb { get; set; }

        [StringLength(50)]
        public string pubState { get; set; }

        [StringLength(50)]
        public string pubPC { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Title> Titles { get; set; }
    }
}
