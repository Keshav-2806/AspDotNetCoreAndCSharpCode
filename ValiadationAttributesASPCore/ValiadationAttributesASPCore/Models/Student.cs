using System.ComponentModel.DataAnnotations;

namespace ValiadationAttributesASPCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is Must")]
        //  [StringLength(15,MinimumLength =3, ErrorMessage ="Name must be within 3 to 15 characters")]
        //  [MaxLength(15)]
        [MinLength(3,ErrorMessage ="Minimum length must be 3 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Is Must")]
        // [EmailAddress]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is Must")]
        [Range(10,50,ErrorMessage ="Age Must be within 10 to 50")]
        public int? Age { get; set; }

        //[Required(ErrorMessage = "Password is Must")]
        //[RegularExpression("(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$")]
        //public string Password { get; set; }

        //[Required(ErrorMessage ="Confirm Password is Must")]
        //[Compare("Password",ErrorMessage ="Both Passwords Must be Identical")]
        //[Display(Name="Enter Confirm Password")]
        //public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Number is Must")]
        [RegularExpression("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage ="Invalid Mobile Number")]
        public String INumber { get; set; }
        [Required(ErrorMessage =" Website URL is Must")]
        [Url(ErrorMessage ="Invalid URL")]
        public string WebsiteURL { get; set; }

    }
}
