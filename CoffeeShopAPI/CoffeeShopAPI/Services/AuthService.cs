namespace CoffeeShopAPI.Services
{
    using CoffeeShopAPI.Application.DTOs.Auth;
    using CoffeeShopAPI.Application.Interfaces;
    using CoffeeShopAPI.Domain.Entities;
    using Microsoft.AspNetCore.Identity;

    public class AuthService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPasswordHasher<Customer> _passwordHasher;
        private readonly IJwtTokenService _jwtTokenService;

        public AuthService(
            ICustomerRepository customerRepository,
            IPasswordHasher<Customer> passwordHasher,
            IJwtTokenService jwtTokenService)
        {
            _customerRepository = customerRepository;
            _passwordHasher = passwordHasher;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<string?> LoginAsync(LoginRequestDto request)
        {
            var customer = await _customerRepository
                .GetByEmailAsync(request.Email);

            if (customer == null)
                return null;

            var result = _passwordHasher.VerifyHashedPassword(
                customer,
                customer.PasswordHash,
                request.Password
            );

            if (result == PasswordVerificationResult.Failed)
                return null;

            return _jwtTokenService.GenerateToken(customer);
        }
    }
}
