using System.ComponentModel.DataAnnotations;

namespace ElectronicCommerce.Shared; 

public class UserChangePassword {
    [Required(ErrorMessage = "请输入密码"), StringLength(100, MinimumLength = 6, ErrorMessage = "密码长度必须在6位与100位之间")]
    public string Password { get; set; } = string.Empty;
    
    [Compare("Password", ErrorMessage = "前后密码不匹配")]
    public string ConfirmPassword { get; set; } = string.Empty;
}