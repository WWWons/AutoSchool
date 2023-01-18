using System.Security.Claims;
using System.Threading.Tasks;
using Autoschool.Domain.Response;
using Autoschool.Domain.ViewModels.Account;

namespace Autoschool.Service.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}