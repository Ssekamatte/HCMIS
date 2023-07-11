using HCMIS.DTOs;
using HCMIS.ViewModel;

namespace HCMIS.Interface
{
    public interface IAptituddeTestReopsitory
    {
        Task<List<AptituddeTestModel>?> GetAllAptituddeTests();
        Task<List<AptituddeTestModel>?> GetAptituddeTestsForDepartment();
        Task<AptituddeTestModel?> GetAplittuddeTestForJobTitleAsync(int JobTitleId);
        Task<HttpResponseMessage> SaveAptituddeTest(AptituddeTestModel model);
        Task<AmptituddeTestDoneDto> SaveTestDone(AmptituddeTestDoneDto model);
    }
}
