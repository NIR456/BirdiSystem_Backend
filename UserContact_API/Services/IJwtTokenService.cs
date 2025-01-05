namespace Employee_API.Services
{
    public interface IJwtTokenService
    {
        public string GenerateToken(string username);
    }
}
