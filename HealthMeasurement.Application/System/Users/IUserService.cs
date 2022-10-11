using HealthMeasurement.ViewModels.Common;
using HealthMeasurement.ViewModels.System.Users;
using System.Threading.Tasks;

namespace HealthMeasurement.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

    }
}