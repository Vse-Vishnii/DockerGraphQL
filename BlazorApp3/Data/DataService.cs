namespace BlazorApp3.Data
{
    public class DataService
    {
        private readonly Repository repository;

        public DataService(Repository repository)
        {
            this.repository = repository;
        }


        public async Task<IEnumerable<Data>> Get()
        {
            return await repository.GetAll();
        }

        public async Task Add(Data data)
        {
            await repository.Create(data);
        }

        public async Task Delete(string id)
        {
            var data = await repository.Get(id);
            await repository.Delete(data);
        }
    }
}
