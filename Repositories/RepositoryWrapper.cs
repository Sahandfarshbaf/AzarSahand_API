using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.IRepositories;
using Entities;
using Entities.Models;
using Repository.Repositories;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private shahghassemi_SahandAzarContext _repoContext;

        public RepositoryWrapper(shahghassemi_SahandAzarContext repositoryContext)
        {
            _repoContext = repositoryContext;

        }


        private ICatFormRepository _catForm;
        private ICatRoleRepository _catRole;
        private ICityRepository _city;
        private IFormRepository _form;
        private IProvinceRepository _province;
        private IRoleRepository _role;
        private IRoleFormRepository _roleForm;
        private IUserAccessLocationRepository _userAccessLocation;
        private IUserActivationRepository _userActivation;
        private IUsersRepository _users;
        private IUserRoleRepository _userRole;





        public ICatFormRepository CatForm => _catForm ??= new CatFormRepository(_repoContext);
        public ICatRoleRepository CatRole => _catRole ??= new CatRoleRepository(_repoContext);
        public ICityRepository City => _city ??= new CityRepository(_repoContext);
        public IFormRepository Form => _form ??= new FormRepository(_repoContext);
        public IProvinceRepository Province => _province ??= new ProvinceRepository(_repoContext);
        public IRoleRepository Role => _role ??= new RoleRepository(_repoContext);
        public IRoleFormRepository RoleForm => _roleForm ??= new RoleFormRepository(_repoContext);
        public IUserAccessLocationRepository UserAccessLocation => _userAccessLocation ??= new UserAccessLocationRepository(_repoContext);
        public IUserActivationRepository UserActivation => _userActivation ??= new UserActivationRepository(_repoContext);
        public IUsersRepository Users => _users ??= new UsersRepository(_repoContext);
        public IUserRoleRepository UserRole => _userRole ??= new UserRoleRepository(_repoContext);



        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
