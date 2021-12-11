using Contracts.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserActivationRepository : RepositoryBase<UserActivation>, IUserActivationRepository
    {
        public UserActivationRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}
