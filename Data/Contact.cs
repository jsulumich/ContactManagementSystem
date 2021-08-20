using System;
using System.ComponentModel.DataAnnotations;

// contact entity
namespace ContactManagementSystem.Data
{
    public class Contact
    {
        // unique identifier
        [Key]
        public Guid Id { get; set; }

        // last  name - required field, 250 character limit
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(250, ErrorMessage = "Last name cannot exceed 250 characters.")]
        public string LastName { get; set; }

        // first  name - required field, 250 character limit
        [Required(ErrorMessage = "First name is required")]
        [StringLength(250, ErrorMessage = "First name cannot exceed 250 characters.")]
        public string FirstName { get; set; }

        // phone number - optional field, 15 character limit
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string PhoneNumber { get; set; }

        // birth date - optional field
        public  DateTime? BirthDate { get; set; }

    }
}
