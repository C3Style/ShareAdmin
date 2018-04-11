using System.Threading.Tasks;
using Abp.Application.Services;
using ShareAdmin.Sessions.Dto;

namespace ShareAdmin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
