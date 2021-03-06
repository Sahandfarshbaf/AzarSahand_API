using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts.IRepositories;

namespace Repository.Repositories
{
    public class UsersRepository : RepositoryBase<User>, IUsersRepository
    {
        public UsersRepository(shahghassemi_SahandAzarContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public User GetUserByUserName(string userName)
        {

            return RepositoryContext.Users.FirstOrDefault(c => c.UserName == userName && c.Ddate==null);

        }
    }
}
