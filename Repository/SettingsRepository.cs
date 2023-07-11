using Blazored.LocalStorage;
using HCMIS.Interface;
using HCMIS.Model;

namespace HCMIS.Repository
{
    public class SettingsRepository : ISettingsRepository
    {
        private ILocalStorageService localStore;
        private encrypt_decrypt_string decrpt;
        private SystemCredentials systemCredentials;
        public SettingsRepository(ILocalStorageService _localStore,
           encrypt_decrypt_string _decrpt)
        {
            localStore = _localStore;
            decrpt = _decrpt;

        }

        private async Task GetLoginCredentials()
        {
            //string credentials = await localStore.GetItemAsync<string>("Credentials");
            //if (credentials != null)
            //{
            //    systemCredentials = await decrpt.DecryptCredentials(credentials);

            //}

            systemCredentials = await localStore.GetItemAsync<SystemCredentials>("Credentials");
        }

        public async Task<string?> GetAccessToken()
        {
            await GetLoginCredentials();
            string? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.AccessToken;
            }
            return result;
        }

        public async Task<string?> GetAccountName()
        {
            await GetLoginCredentials();
            string? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.AccountHolderName;
            }
            return result;
        }

        public async Task<DateTime?> GetExpiryDate()
        {
            await GetLoginCredentials();
            DateTime? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.ExpiryDate;
            }
            return result;
        }
        public async Task<int?> GetStaffId()
        {
            await GetLoginCredentials();
            int? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.StaffId;
            }
            return result;
        }

        public async Task<string?> GetUsername()
        {
            await GetLoginCredentials();
            string? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.Username;
            }
            return result;
        }

        public async Task<string?> GetUserRole()
        {
            await GetLoginCredentials();
            string? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.UserRole;
            }
            return result;
        }
        public async Task<string?> GetPassword()
        {
            await GetLoginCredentials();
            string? result = null;
            if (systemCredentials != null)
            {
                result = systemCredentials.Password;
            }
            return result;
        }
    }
}
