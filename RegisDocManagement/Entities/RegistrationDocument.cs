using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisDocManagement.Entities
{
    [Table("RegistrationDocuments")]
    public class RegistrationDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegisDocID { get; set; }

        [Required]
        [StringLength(200)]
        public string FileName { get; set; }

        [Required]
        [StringLength(500)]
        public string FilePath { get; set; }
        public int FileType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UploadDate { get; set; }

        [StringLength(1000)]
        public string Note { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int DomainID { get; set; }
    }
}
