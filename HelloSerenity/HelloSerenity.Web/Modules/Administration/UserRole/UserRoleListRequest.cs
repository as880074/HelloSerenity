using Serenity.Services;

namespace HelloSerenity.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}