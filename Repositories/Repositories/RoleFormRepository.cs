using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IRepositories;
using Entities.DataTransferObjects.Account;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class RoleFormRepository : RepositoryBase<RoleForm>, IRoleFormRepository
    {
        public RoleFormRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }
        

    }
}
