namespace BlazorApp3.Data
{
    public class Mutations
    {
        public async Task Create([Service] MyDbContext db, Data data)
        {
            await db.AddAsync(data);
            await db.SaveChangesAsync();
        }

        public async Task Update([Service] MyDbContext db, Data data)
        {
            db.Update(data);
            await db.SaveChangesAsync();
        }

        public async Task Delete([Service] MyDbContext db, string id)
        {
            var data = await db.Set<Data>().FindAsync(id);
            db.Remove(data);
            await db.SaveChangesAsync();
        }
    }
}
