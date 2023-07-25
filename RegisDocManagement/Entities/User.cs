using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegisDocManagement.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Username { get; set; }

        public string Password { get; set; }

    }
}
