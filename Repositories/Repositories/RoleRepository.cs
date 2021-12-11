using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.IRepositories;
using Entities.DataTransferObjects.Account;

namespace Repository.Repositories
{
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }


    }
}
