using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisDocManagement.Entities
{
    [Table("RegistrarCompanies")]
    public class RegistrarCompany
    {
        [Key]
        [Required]
        [StringLength(200)]
        public string RegistrarCompanyID { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(500)]
        public string ContactInfo { get; set; }


    }
}
