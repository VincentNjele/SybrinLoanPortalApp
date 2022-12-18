using Microsoft.EntityFrameworkCore;
using SybrinLoanPortal.Server.Data;
using SybrinLoanPortal.Server.Services.Interfaces;

namespace SybrinLoanPortal.Server.Services.Repositories
{
    public class Repository : IService
    {
        private readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<T>> LoadData<T>() where T : class
        {
            var clients = await context.Set<T>().ToListAsync();

            return clients;
        }
    }
}
