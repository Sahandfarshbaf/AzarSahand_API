using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.IRepositories;
using Entities.DataTransferObjects.Account;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
	{
		public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
		{
			public UserRoleRepository(shahghassemi_SahandAzarContext repositoryContext)
				: base(repositoryContext)
			{
			}

           
	}
	}
