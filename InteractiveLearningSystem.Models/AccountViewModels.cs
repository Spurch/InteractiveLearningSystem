namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class UserSnippetViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }
    }

    public class UserListDetailsAdminView
    {
        public string Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        public int? SchoolId { get; set; }

        [Display(Name = "Clan")]
        public string GroupName { get; set; }

        public int? GroupId { get; set; }
    }

    public class UserDetailsAdminView
    {
        public string Id { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Display(Name = "Clan")]
        public string GroupName { get; set; }

        [Display(Name = "Points")]
        public double GroupPoints { get; set; }

        [Display(Name = "Experience")]
        public double GroupExperience { get; set; }

        [Display(Name = "Level")]
        public int GroupLevel { get; set; }

        [Display(Name = "Points")]
        public double SchoolPoints { get; set; }

        [Display(Name = "Experience")]
        public double SchoolExperience { get; set; }

        [Display(Name = "Level")]
        public int SchoolLevel { get; set; }

        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        public int? SchoolId { get; set; }

        public int? GroupId { get; set; }
    }

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
