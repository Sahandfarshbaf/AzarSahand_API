using Contracts.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CatFormRepository : RepositoryBase<CatForm>, ICatFormRepository
    {
        public CatFormRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}
