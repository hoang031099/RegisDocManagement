using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisDocManagement.Entities
{
    [Table("Domains")]
    public class Domain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DomainID { get; set; }

        [Required]
        [StringLength(255)]
        public string DomainName { get; set; }

        [StringLength(40)]
        public string Type { get; set; }

        [StringLength(65)]
        public string DomainLabel { get; set; }

        [StringLength(100)]
        public string IssuedCode { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        [StringLength(40)]
        public string ProcedureStatus { get; set; }
        public decimal Fee { get; set; }

        [StringLength(200)]
        public string RegistrarCompanyID { get; set; }
        public int CustomerID { get; set; }
        public int RegisDocID { get; set; }

    }
}
