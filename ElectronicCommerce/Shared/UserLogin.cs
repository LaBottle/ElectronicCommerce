using System.ComponentModel.DataAnnotations;

namespace ElectronicCommerce.Shared;

public class UserLogin {
    [Required(ErrorMessage = "请输入用户名")]
    public string UserName { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "请输入密码")]
    public string Password { get; set; } = string.Empty;
}