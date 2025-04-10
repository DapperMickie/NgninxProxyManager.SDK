using System.Threading;
using System.Threading.Tasks;
using NginxProxyManager.SDK.Models.ServerErrors;

namespace NginxProxyManager.SDK.Services.Interfaces
{
    public interface IServerErrorService
    {
        Task<ServerError[]> GetServerErrorsAsync(CancellationToken cancellationToken = default);
        Task<ServerError> GetServerErrorAsync(int serverErrorId, CancellationToken cancellationToken = default);
        Task<ServerError[]> GetServerErrorsByHostIdAsync(int hostId, CancellationToken cancellationToken = default);
        Task DeleteServerErrorAsync(int serverErrorId, CancellationToken cancellationToken = default);
        Task DeleteServerErrorsByHostIdAsync(int hostId, CancellationToken cancellationToken = default);
    }
} 