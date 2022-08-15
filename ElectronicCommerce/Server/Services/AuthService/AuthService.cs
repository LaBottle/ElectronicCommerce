using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
namespace ElectronicCommerce.Server.Services.AuthService;

public class AuthService : IAuthService {
    private readonly DataContext _context;
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthService(DataContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) {
        _context = context;
        _configuration = configuration;
        _httpContextAccessor = httpContextAccessor;
    }

    public int GetUserId() => 
        int.Parse(_httpContextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier));

    public async Task<ServiceResponse<int>> Register(User user, string password) {
        if (await UserExists(user.UserName)) {
            return new ServiceResponse<int> {
                Success = false,
                Message = "用户名已存在！"
            };
        }

        (user.PasswordHash, user.PasswordSalt) = CreatePasswordHash(password);
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return new ServiceResponse<int> {Data = user.Id, Message = "注册成功"};
    }

    public async Task<bool> UserExists(string email) {
        return await _context.Users.AnyAsync(user =>
            user.UserName.ToLower().Equals(email.ToLower()));
    }

    public async Task<ServiceResponse<string>> Login(string userName, string password) {
        var response = new ServiceResponse<string>();
        var user =
            await _context.Users.FirstOrDefaultAsync(x =>
                x.UserName.ToLower().Equals(userName.ToLower()));
        if (user == null) {
            response.Success = false;
            response.Message = "用户名不存在！";
        }
        else if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) {
            response.Success = false;
            response.Message = "密码错误！";
        }
        else {
            response.Data = CreateToken(user);
        }

        return response;
    }

    public async Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword) {
        var user = await _context.Users.FindAsync(userId);
        if (user==null) {
            return new ServiceResponse<bool> {
                Success = false,
                Message = "用户名不存在！"
            };
        }

        (user.PasswordHash, user.PasswordSalt) = CreatePasswordHash(newPassword);
        await _context.SaveChangesAsync();
        return new ServiceResponse<bool> {
            Data = true,
            Message = "修改密码成功！"
        };
    }
    
    public async Task<ServiceResponse<bool>> ChangeAddress(int userId, string newAddress) {
        var user = await _context.Users.FindAsync(userId);
        if (user==null) {
            return new ServiceResponse<bool> {
                Success = false,
                Message = "用户名不存在！"
            };
        }

        user.Address = newAddress;
        await _context.SaveChangesAsync();
        return new ServiceResponse<bool> {
            Data = true,
            Message = "修改地址成功！"
        };
    }

    private string CreateToken(User user) {
        List<Claim> claims = new List<Claim> {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var key = new SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) {
        using (var hmac = new HMACSHA512(passwordSalt)) {
            var computedHash =
                hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }

    (byte[] passwordHash, byte[] passwordSalt) CreatePasswordHash(string password) {
        byte[] passwordHash, passwordSalt;
        using (var hmac = new HMACSHA512()) {
            passwordSalt = hmac.Key;
            passwordHash =
                hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }

        return (passwordHash, passwordSalt);
    }
}