namespace BlazorApp3.Data
{
    public class Mutations
    {
        public async Task<Data> Create([Service] MyDbContext db, Data data)
        {
            await db.AddAsync(data);
            await db.SaveChangesAsync();
            return data;
        }

        public async Task<Data> Update([Service] MyDbContext db, Data data)
        {
            db.Update(data);
            await db.SaveChangesAsync();
            return data;
        }

        public async Task<Data> Delete([Service] MyDbContext db, string id)
        {
            var data = await db.Set<Data>().FindAsync(id);
            db.Remove(data);
            await db.SaveChangesAsync();
            return data;
        }
    }
}
