using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<HelloSerenity.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = HelloSerenity.Administration.LanguageRow;


namespace HelloSerenity.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}