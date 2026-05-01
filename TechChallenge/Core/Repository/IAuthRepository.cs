using Core.Dto;

namespace Core.Repository
{
    public interface IAuthRepository
    {
        string Login(LoginDto loginDto);
    }
}
