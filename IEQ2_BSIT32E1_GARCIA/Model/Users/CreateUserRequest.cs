using System.ComponentModel.DataAnnotations;

namespace IEQ2_BSIT32E1_GARCIA.Model.Users

{
    public class CreateUserRequest
    {
        [Required]
        public string name { get; set; }
        [EmailAddress]

        public string Name { get; set; }
        public string Email { get; set; }
    }
}
