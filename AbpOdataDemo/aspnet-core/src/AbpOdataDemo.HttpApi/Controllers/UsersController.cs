using System;
using System.Linq;
using AbpOdataDemo.Users;
using Microsoft.AspNet.OData;
using Volo.Abp.Domain.Repositories;

namespace AbpOdataDemo.Controllers
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
        public virtual IQueryable<AppUser> Get()
        {
            return _userRepository.GetDbSet().AsQueryable();
        }
    }
}
