using AzarSahand_API.Services.Interfaces;
using Contracts;

namespace AzarSahand_API.Services
{
    public class AccountService
    {
        #region IOC & Constructor


        private readonly IRepositoryWrapper _repository;
        //private readonly ILogHandler _logger;
        private readonly IConfiguration _configuration;
        private readonly ICurrentUserService _currentUserService;



        public AccountService( IRepositoryWrapper repository, IConfiguration configuration, ICurrentUserService currentUserService)
        {

            _repository = repository;
            //_logger = logger;
            _configuration = configuration;
            _currentUserService = currentUserService;
            //_baseService = baseService;
        }

        #endregion
    }
}
