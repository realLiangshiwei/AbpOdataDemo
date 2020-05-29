using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpOdataDemo.Users;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace AbpOdataDemo.Controllers
{
    public class UsersController :  ODataController
    {
        private readonly IRepository<AppUser> _userRepository;

        public UsersController(IRepository<AppUser> userRepository)
        {
            _userRepository = userRepository;
        }

        // GET
        [EnableQuery]
        public virtual async  Task<IEnumerable<AppUser>> Get()
        {
            return await _userRepository.GetListAsync();
        }
    }
}
