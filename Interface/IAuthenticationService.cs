using HCMIS.DTOs;
using HCMIS.Model;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;
using HCMIS.SHARED.Usermanagement;

namespace HCMIS.Interface
{
    public interface IAuthenticationService
    {
        Task<Response> RegisterUser(RegisterModel userForRegistration);
        Task<LoginResultModel> Login(LoginModel userForAuthentication);
        Task Logout();
        Task<bool> CheckAuthenticationStatus();
        Task<LoginResultModel> GetUserCredentials();
        Task<List<AspNetRoles>> GetUserRoles();
        Task<List<ViewUserManagement>> GetSystemUsers();
        Task ChangeUserPassword(ChangePasswordModel model);
        Task ChangePassword(ChangePasswordViewModel model);
        Task InitialisePasswordReset(ResetPasswordDTO data);
        Task UpdateAccountInformation(ViewUserManagement data);

        int RandomNumber(int min, int max);
        string RandomString(int size, bool lowerCase);
        char RandomCharacter();
        string RandomPassword(int size = 0);
    }
}
