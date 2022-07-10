using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Data
{
    public class Repository
    {
        private MyDbContext db;

        public Repository(MyDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Data>> GetAll()
        {
            return await db.Set<Data>().ToListAsync();
        }

        public async Task<Data> Get(string id)
        {
            return await db.Set<Data>().FindAsync(id);
        }

        public async Task Create(Data data)
        {
            await db.AddAsync(data);
            await db.SaveChangesAsync();
        }

        public async Task Update(Data data)
        {
            db.Update(data);
            await db.SaveChangesAsync();
        }

        public async Task Delete(Data data)
        {
            db.Remove(data);
            await db.SaveChangesAsync();
        }
    }
}
