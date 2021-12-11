using Contracts.IRepositories;
using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class FormRepository : RepositoryBase<Form>, IFormRepository
    {
        public FormRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }

    }
}