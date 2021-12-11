using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.IRepositories;
using Entities.DataTransferObjects.BaseInfo;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class ProvinceRepository : RepositoryBase<Province>, IProvinceRepository
    {
        public ProvinceRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }

       
    }
}
