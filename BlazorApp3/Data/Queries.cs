using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data
{
    public class Queries
    {
        public async Task<IEnumerable<Data>> Read([Service]MyDbContext db)
        {
            return await db.Set<Data>().ToListAsync();
        }

        public async Task<Data> Get([Service] MyDbContext db, string id)
        {
            return await db.Set<Data>().FindAsync(id);
        }
    }
}
