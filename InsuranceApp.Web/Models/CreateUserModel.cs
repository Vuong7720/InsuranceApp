namespace InsuranceApp.Web.Models
{
    public class CreateUserModel
    {
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "User";
    }
}
