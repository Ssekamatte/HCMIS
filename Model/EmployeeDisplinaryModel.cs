namespace HCMIS.Model
{
    public class EmployeeDisplinaryModel
    {
      // public EmployeeDisplinary? EmpDisplinary { get; set; }
        //public List<ADepartment>? Departments { get; set; }
        public List<ADisplinaryReason>? DisplinaryReason { get; set; }
        public List<ViewEmployeeDisplinary>? ViewEmployeeDisplinaryDetails { get; set; }
        public List<ADisplinaryAction>? DisplinaryAction { get; set; }
        public List<ADisplinaryWarning>? DisplinaryWarnings { get; set; }
        public List<ADisplinaryCategory>? DisplinaryCategories { get; set; }
        public List<ViewDisciplinaryCommittee>? ViewDisciplinaries { get; set; }
    }
}
