using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Qc.Users;
using Volo.Abp.Domain.Repositories;

namespace Qc.Controllers
{
    public class UsersController : ODataController
    {
        private readonly IBasicRepository<AppUser, Guid> _userRepository;

        public UsersController(IRepository<AppUser, Guid> userRepository)
        {
            _userRepository = userRepository;
        }

        // GET
        [EnableQuery]
        public virtual async Task<IQueryable<AppUser>> GetAsync()
        {
            var dbSet =await _userRepository.GetDbSetAsync();

            return dbSet.AsQueryable();
        }
    }
}
