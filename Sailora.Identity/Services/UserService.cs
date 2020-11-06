using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Sailora.Identity.Entities;
using Sailora.Identity.Helpers;
using Sailora.Identity.Models;

namespace Sailora.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<User> _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public UserService(IEfRepository<User> userRepository, IConfiguration configuration, IMapper mapper)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _userRepository
                .GetAll()
                .FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (user == null)
            {
                // todo: need to add logger
                return null;
            }

            var token = _configuration.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public async Task<AuthenticateResponse> Register(UserModel userModel)
        {
            var user = _mapper.Map<User>(userModel);

            var addedUser = await _userRepository.Add(user);

            var response = Authenticate(new AuthenticateRequest
            {
                Username = user.Username,
                Password = user.Password
            });
            
            return response;
        }
        
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}