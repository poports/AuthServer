using AuthServer.Infrastructure.Data.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;



namespace AuthServer.Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppIdentityDbContext _appIdentityDbContext;

        public UserRepository(AppIdentityDbContext appIdentityDbContext)
        {
            _appIdentityDbContext = appIdentityDbContext;
        }

        public async Task InsertEntity(string role, string userId, string fullName)
        {
            // Insert in entity table
            var commandText = $"INSERT {role + "s"} (Id,Created,FullName) VALUES (@Id,datetime('now'),@FullName)";
            var id = new SqliteParameter("@Id", userId);
            var name = new SqliteParameter("@FullName", fullName);
            await _appIdentityDbContext.Database.ExecuteSqlRawAsync(commandText, id, name);
        }
    }
}