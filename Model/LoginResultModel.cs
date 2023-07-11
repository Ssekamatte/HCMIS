namespace HCMIS.Model
{
    public class LoginResultModel
    {
        public bool IsSuccess { get; set; }
        public string token { get; set; }
        public DateTime expiration { get; set; }
        public string UserRole { get; set; }
        public string AccountHolderName { get; set; }
        public int StaffId { get; set; }
        public string? UserRoleId { get; set; }
        public bool IsLockedOut { get; set; }
        public string? ErrorMsg { get; set; }
    }
}
