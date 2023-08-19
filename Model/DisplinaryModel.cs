using HCMIS.SHARED.DTOs.Employeez;

namespace HCMIS.Model
{
    public class DisplinaryModel
    {
        public int EmployeeDisplinaryId { get; set; }
        public EmployeeDisciplinaryDto? EmployeeDisplinaryHeader { get; set; }
        public List<ADisplinaryRefered>? aDisplinaryRefereds { get; set; }
        public List<ADisplinaryAppeal>? aDisplinaryAppeals { get; set; }
    }
}
