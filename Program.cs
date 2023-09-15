using HCMIS;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Blazored.LocalStorage;
using HCMIS.Model;
using Microsoft.Extensions.DependencyInjection;
using Blazor.SubtleCrypto;
using static HCMIS.Pages.NonStaff.NonStaffQualificationPage;
using HCMIS.ViewModel;
using Blazored.Toast;
using static HCMIS.Pages.NonStaff.NonStaffWorkExperiencePage;
using static HCMIS.Pages.NonStaff.NonStaffSkillsPage;
using static HCMIS.Pages.NonStaff.NonStaffNextOfKinPage;
using static HCMIS.Pages.NonStaff.NonStaffLanguagesKnownPage;
using static HCMIS.Pages.HR.JobTitlePage;
using static HCMIS.Pages.HR.ADepartmentPage;
using static HCMIS.Pages.HR.JD.JobDescriptionPage;
using static HCMIS.Pages.HR.JD.JobOpeningPage;
//using static HCMIS.Pages.EmployeeRegistration.EmployeeRegistrationPage;
using HCMIS.Repository;
using static HCMIS.Pages.HR.Aptitudde.AptitudeTestPage;
using HCMIS.Interface;
using static HCMIS.Pages.HR.Applicants.SubmittedApplicationPage;
using static HCMIS.Pages.HR.Applicants.InterviewApplicationPage;
using static HCMIS.Pages.HR.Applicants.FinalApplicationAssessmentPage;

using static HCMIS.Pages.Utilities.BscPerspectivesFormPage;
using static HCMIS.Pages.Training.AssessmentSurveyPage;
using static HCMIS.Pages.Training.SurveyDeadlinePage;
using static HCMIS.Pages.Training.TrainingEvaluationForm;
using static HCMIS.Pages.Training.CPDPage;
using static HCMIS.Pages.Training.GeneralInternalPage;
using static HCMIS.Pages.Training.CPDSummaryPage;
using static HCMIS.Pages.Training.SubscriptionPage;
using static HCMIS.Pages.BalanceScoreCard.AppraisalFormPage;
using HCMIS.Services;
//using static HCMIS.Pages.EmployeeDisplinary.DisplinaryActionPage;
//using static HCMIS.Pages.EmployeeDisplinary.DisplinaryCaseStatusPage;
//using static HCMIS.Pages.EmployeeDisplinary.DisplinaryCategoryPage;
//using static HCMIS.Pages.EmployeeDisplinary.DisplinaryIncidencesPage;
//using static HCMIS.Pages.EmployeeDisplinary.DisplinaryWarningPage;
//using static HCMIS.Pages.EmployeeDisplinary.EmployeeResponsePage;
//using static HCMIS.Pages.EmployeeDisplinary.PreviousCasesPage;
//using static HCMIS.Pages.EmployeeDisplinary.ReferredDisciplinaryCasesPage;
//using static HCMIS.Pages.EmployeeRegistration.EmployeeListPage;
using static HCMIS.Pages.Utilities.DistrictPage;
using Microsoft.AspNetCore.Components.Authorization;
using HCMIS.AuthProviders;
using static HCMIS.Pages.Account.UserManagementPage;
using static HCMIS.Pages.Account.ChangeUserPasswordPage;
using static HCMIS.Pages.Utilities.SubcountyPage;
using static HCMIS.Pages.Utilities.ParishPage;
using static HCMIS.Pages.Utilities.VillagePage;
using static HCMIS.Pages.EmployeeLeave.EmployeeLeaveRequestPage;
using static HCMIS.Pages.PartialViews.SupervisorPartialApprovalPage;
using static HCMIS.Pages.Utilities.PublicHolidaysPage;
using Syncfusion.Blazor.Schedule;
using static HCMIS.Pages.Utilities.BankPage;
using static HCMIS.Pages.Utilities.RelationshipPage;
using static HCMIS.Pages.EmployeeExit.EmployeeExitsPage;
using static HCMIS.Pages.EmployeeRegistration.EmployeeRegistrationNewPage;
using static HCMIS.Pages.EmployeeLeave.AnnualLeavePlanPage;
using MudBlazor.Services;
using static HCMIS.Pages.Utilities.MeasurementUnitPage;
using static HCMIS.Pages.EmployeeLeave.AnnualLeaveRosterPage;
using static HCMIS.Pages.EmployeeDisplinary.DisciplinaryPage;
using static HCMIS.Pages.Utilities.FinancialYearPage;
using static HCMIS.Pages.Utilities.BSCKPIFormPage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton(builder.Configuration.GetSection("ApiConfig").Get<ApiConfig>());
builder.Services.AddScoped<AppState>();
builder.Services.AddScoped<SystemSettings>();
builder.Services.AddSubtleCrypto(opt =>
    opt.Key = builder.Configuration.GetSection("EncreptionKeys")["secretkey"] //Use another key
);
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.Configuration.GetSection("ApiConfig")["BaseUrl"]),
        Timeout = TimeSpan.FromMinutes(10)
    });
builder.Services.AddScoped<encrypt_decrypt_string>();
builder.Services.AddScoped<ISettingsRepository, SettingsRepository>();
builder.Services.AddScoped<IAptituddeTestReopsitory, AptituddeTestReopsitory>();
builder.Services.AddScoped<DocumentUploadModel>();
builder.Services.AddScoped<IJobApplications, JobApplications>();

builder.Services.AddScoped<NonStaffQualificationAdapter>();
builder.Services.AddScoped<NonStaffWorkExperienceAdapter>();
builder.Services.AddScoped<NonStaffSkillsAdapter>();
builder.Services.AddScoped<NonStaffNextOfKinAdapter>();
builder.Services.AddScoped<NonStaffLanguagesKnownAdapter>();
builder.Services.AddScoped<AJobTitleAdapter>();
builder.Services.AddScoped<ADepartmentAdapter>();
builder.Services.AddScoped<JobDescriptionAdapter>();
builder.Services.AddScoped<JobDescriptionKnowledgeAdapter>();
builder.Services.AddScoped<JobDescriptionResponsibilityAdapter>();
builder.Services.AddScoped<JobDescriptionWorkExperienceRequirementAdapter>();
builder.Services.AddScoped<JobDescriptionBenefitAdapter>();
builder.Services.AddScoped<JobOpeningAdapter>();
//builder.Services.AddScoped<EmployeeRecordAdapter>();
builder.Services.AddScoped<AptituddeTestAdapter>();
builder.Services.AddScoped<SubmittedApplicationAdapter>();
builder.Services.AddScoped<InterviewApplicationAdapter>();
builder.Services.AddScoped<FinalStageApplicationAdapter>();
builder.Services.AddScoped<BscPerspectiveAdapter>();
builder.Services.AddScoped<AssessmentAdapter>(); 
builder.Services.AddScoped<AssessmentDeadlineAdapter>();
builder.Services.AddScoped<EvaluationAdapter>(); 
builder.Services.AddScoped<CPDAdapter>(); 
builder.Services.AddScoped<GeneralInternalAdapter>();
builder.Services.AddScoped<CPDSummaryAdapter>();
builder.Services.AddScoped<SubscriptionSummaryAdapter>(); 
builder.Services.AddScoped<BSCAdapter>();
///
builder.Services.AddScoped<DocumentUploadModel>();
builder.Services.AddScoped<NonStaffQualificationAdapter>();
builder.Services.AddScoped<NonStaffWorkExperienceAdapter>();
builder.Services.AddScoped<NonStaffSkillsAdapter>();
builder.Services.AddScoped<NonStaffLanguagesKnownAdapter>();
//builder.Services.AddScoped<EmployeeRecordAdapter>();

//builder.Services.AddScoped<PreviousCaseAdapter>();
//builder.Services.AddScoped<DisplinaryActionAdapter>();
//builder.Services.AddScoped<ADisplinaryWarningAdapter>();
//builder.Services.AddScoped<ADisplinaryCategoryAdapter>();
//builder.Services.AddScoped<ADisplinaryCaseStatusAdapter>();
//builder.Services.AddScoped<ADisplinaryReasonAdapter>();
//builder.Services.AddScoped<ReferedDisplinaryDataAdapter>();
//builder.Services.AddScoped<DisplinaryResponseAdapter>();
builder.Services.AddScoped<DistrictAdapter>(); 
builder.Services.AddScoped<SubcountyAdapter>();
builder.Services.AddScoped<ParishAdapter>();
builder.Services.AddScoped<VillageAdapter>();
builder.Services.AddScoped<EmployeeDisplinaryDataAdapter>();
//builder.Services.AddScoped<ILeaveRosterService, LeaveRosterService>();
//builder.Services.AddScoped<EmployeeMasterAdapter>();
builder.Services.AddScoped<UserManagementAdapter>(); 
builder.Services.AddScoped<ChangeUserPasswordAdapter>();
//builder.Services.AddScoped<AnnualLeaveAdapter>();
builder.Services.AddScoped<LeaveRequestAdapter>();
builder.Services.AddScoped<SupervisorApprovalAdapter>(); 
builder.Services.AddScoped<PublicHolidayAdapter>();
builder.Services.AddScoped<BankAdapter>();
builder.Services.AddScoped<RelationshipAdapter>();
builder.Services.AddScoped<EmployeeExitAdapter>();
builder.Services.AddScoped<EmployeeRecordNewAdapter>();
builder.Services.AddScoped<LeavePlanHeaderAdapter>();
builder.Services.AddScoped<BasicUnitAdapter>();
builder.Services.AddScoped<AnnualLeaveRosterAdapter>();
builder.Services.AddScoped<FinancialYearAdapter>();
builder.Services.AddScoped<ObjectivesAdapter>(); 
builder.Services.AddScoped<ObjectivesDetailsAdapter>();
builder.Services.AddScoped<PerspectivesDetailsAdapter>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IExitInterviewService, ExitInterviewService>();


//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
//builder.Services.AddApiAuthorization();
builder.Services.AddScoped<AuthenticationStateProvider, HCMISAuthStateProvider>();
builder.Services.AddScoped<IUtilityRepository,UtilityRepository>();
builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();

//builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = false; });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU1MjcyMEAzMjMyMmUzMDJlMzBMY0tNSlY4TkUyc2w5TFdSUWJreVkzYWhLaGMxSmpIa3gzTTlteWcvL0NVPQ==");
await builder.Build().RunAsync();

