using System.ComponentModel.DataAnnotations;

namespace CQRS_MediatR.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Address { get; set; }
    }
}
