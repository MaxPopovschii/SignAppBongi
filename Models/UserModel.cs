
using System.ComponentModel.DataAnnotations;

namespace SignAppBongi.Models
{
    public class UserModel
    {

        public int Id { get; set; } 
        
        [Required(ErrorMessage = "The Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; } = "";


        [Required(ErrorMessage = "The Surname is required")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters")]
        public string Surname { get; set; } = "";


        [Required(ErrorMessage = "The Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = "";


        [Required(ErrorMessage = "The DateOfBirth is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime DateOfBirth { get; set; } 


        [Required(ErrorMessage = "You must agree to the terms and conditions")]
        public bool AgreeToTerms { get; set; } = true;


    }
}
