using System;
using System.Threading;
using System.Threading.Tasks;

namespace cubetimer.Services
{
    public interface IUserService
    {
        public Task GetUser(Guid userId, CancellationToken cancellationToken);
    }
}