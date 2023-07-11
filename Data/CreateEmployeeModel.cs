using HCMIS.Model;

namespace HCMIS.Data
{
    public class CreateEmployeeModel
    {
        public int Employeeid { get; set; }
        public Employee? EmployeeHeader { get; set; }
        public List<EmployeeQualification>? Employeequalifications { get; set; }
        public List<EmployeeSpouse>? Employeespouse { get; set; }
        public List<AEmployeeChildren>? AEmployeechildren { get; set; }
    }
}
