using HCMIS.SHARED.DTOs.BSC;
using HCMIS.Model;
using HCMIS.SHARED.DTOs;

namespace HCMIS.Interface
{
    public interface IUtilityRepository
    {
        Task<List<ViewBscEmployeeDto>?> GetEmployees();
        Task<List<ImageDTO>> GetLocalLogos();
    }
}
