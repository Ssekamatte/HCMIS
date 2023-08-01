using HCMIS.SHARED.DTOs.BSC;
using HCMIS.Model;
using HCMIS.SHARED.DTOs;
using HCMIS.SHARED;

namespace HCMIS.Interface
{
    public interface IUtilityRepository
    {
        Task<List<EmployeeDto>?> GetEmployees();
        Task<List<ImageDTO>> GetLocalLogos();
    }
}
