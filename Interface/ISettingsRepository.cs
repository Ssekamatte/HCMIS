namespace HCMIS.Interface
{
    public interface ISettingsRepository
    {
        Task<string?> GetAccessToken();
        Task<string?> GetUserRole();
        Task<string?> GetUsername();
        Task<string?> GetPassword();
        Task<DateTime?> GetExpiryDate();
        Task<string?> GetAccountName();
        Task<int?> GetStaffId();
    }
}
