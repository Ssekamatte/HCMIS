
using HCMIS.SHARED;
using HCMIS.SHARED.Models;
using HCMISAPI.Models;

namespace HCMIS.ViewModel
{
    public class ExternalRegistrationModel
    {
        public List<ACountry>? Coutry { get; set; }
        public List<AGender>? Gender { get; set; }
        public List<AIdentificationType>? IdentificationType { get; set; }
        public List<ADistrict>? District { get; set; }
        public List<AParish>? Parish { get; set; }
        public List<ASubCounty>? SubCounty { get; set; }
        public List<AVillage>? Village { get; set; }
        public List<AMaritalStatus>? MaritalStatus { get; set; }
        public List<ABank>? Bank { get; set; }
        public List<AFieldOfStudy>? FieldOfStudy { get; set; }
        public List<ALevelofEducation>? LevelofEducation { get; set; }
        public List<ASkillLevel>? SkillLevel { get; set; }
        public List<ARelationship>? Relationship { get; set; }
        public List<ALanguageProlific>? LanguageProlific { get; set; }
        public List<ALanguages>? Languages { get; set; }
        public List<AUniversities>? Universities { get; set; }
    }

    public class EmployeeRegistrationModel
    {
        public List<ACountry>? Coutry { get; set; }
        public List<AGender>? Gender { get; set; }
        public List<AIdentificationType>? IdentificationType { get; set; }
        public List<ADistrict>? District { get; set; }
        public List<ViewAparish>? Parish { get; set; }
        public List<ASubCounty>? SubCounty { get; set; }
        public List<ViewAvillage>? Village { get; set; }
        public List<AMaritalStatus>? MaritalStatus { get; set; }
        public List<ABank>? Bank { get; set; }
        public List<AFieldOfStudy>? FieldOfStudy { get; set; }
        public List<ALevelofEducation>? LevelofEducation { get; set; }
        public List<ASkillLevel>? SkillLevel { get; set; }
        public List<ARelationship>? Relationship { get; set; }
        public List<ALanguageProlific>? LanguageProlific { get; set; }
        public List<ALanguages>? Languages { get; set; }
        public List<ADepartment>? Departments { get; set; }
        public List<JobDescription>? jobDescriptions { get; set; }
        public List<AUniversities>? universities { get; set; }
    }

    public class EmployeeExitPrimaryData
    {
        public List<ViewEmployeeDisplinary>? viewExit { get; set; }
        public List<AYesNo>? YesNos { get; set; }
    }

    public class LeaveApplicationModel
    {
        public EmployeeLeave? EmpLeave { get; set; }
        public List<ADepartment>? Departments { get; set; }
        public List<ViewEmployeeLeaveDetails>? EmployeeLeaveDetails { get; set; }
        public List<ALeaveType>? EmployeeLeaveTypes { get; set; }

    }

}
