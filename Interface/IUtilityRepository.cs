
using HCMIS.SHARED;
using HCMIS.SHARED.Data;
using HCMIS.SHARED.Models;

namespace HCMIS.Interface
{
    public interface IUtilityRepository
    {
        Task<List<Employee>?> GetEmployees();
        Task<List<Image>> GetLocalLogos();
    }
}
