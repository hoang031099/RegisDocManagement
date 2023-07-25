using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisDocManagement.Entities
{
    [Table("RegistrarUsers")]
    public class RegistrarUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrarUserID { get; set; }

        [Required]
        [StringLength(200)]
        public string RegistrarCompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

    }
}
