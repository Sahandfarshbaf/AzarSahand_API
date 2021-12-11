using Contracts.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserAccessLocationRepository : RepositoryBase<UserAccessLocation>, IUserAccessLocationRepository
    {
        public UserAccessLocationRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}