using AutoSchool.Domain.Entity;
using AutoSchool.Domain.Response;
using AutoSchool.Domain.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchool.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model);

        BaseResponse<Dictionary<int, string>> GetRoles();

        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();

        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}
