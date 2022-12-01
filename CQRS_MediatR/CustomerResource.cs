using System.ComponentModel.DataAnnotations;

namespace CQRS_MediatR
{
    public class CustomerResource
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
    }
}
