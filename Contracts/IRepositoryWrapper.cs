using Contracts.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contracts
{
    public interface IRepositoryWrapper
    {

        ICatFormRepository CatForm { get; }
        ICatRoleRepository CatRole { get; }
        ICityRepository City { get; }
        IFormRepository Form { get; }
        IProvinceRepository Province { get; }
        IRoleRepository Role { get; }
        IRoleFormRepository RoleForm { get; }
        IUserAccessLocationRepository UserAccessLocation { get; }
        IUserActivationRepository UserActivation { get; }
        IUserRoleRepository UserRole { get; }
        IUsersRepository Users { get; }


        void Save();
    }
}