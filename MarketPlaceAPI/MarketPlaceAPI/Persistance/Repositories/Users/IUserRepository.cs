namespace MarketPlaceAPI.Persistance.Repositories.User
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email, CancellationToken ct);
    }
}
