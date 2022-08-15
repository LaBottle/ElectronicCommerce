namespace ElectronicCommerce.Server.Services.AuthService;
public interface IAuthService {
    Task<ServiceResponse<int>> Register(User user, string password);
    Task<bool> UserExists(string email);
    Task<ServiceResponse<string>> Login(string userName, string password);
    Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
    Task<ServiceResponse<bool>> ChangeAddress(int userId, string newAddress);
    int GetUserId();
}

