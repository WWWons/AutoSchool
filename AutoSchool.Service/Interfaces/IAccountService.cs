using System.Security.Claims;
using System.Threading.Tasks;
using AutoSchool.Domain.ViewModels.Account;
using AutoSchool.Domain.Response;

namespace AutoSchool.Service.Interfaces
{
    public interface IAccountService
    {
        

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        
    }
}
