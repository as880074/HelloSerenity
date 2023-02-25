using Serenity.Services;
using MyRequest = HelloSerenity.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<HelloSerenity.Administration.UserRow>;
using MyRow = HelloSerenity.Administration.UserRow;

namespace HelloSerenity.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}