using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface IProductRepository
    {
        public Task<Product> CreateAsync(Product obj);
        public Task<Product> UpdateAsync(Product obj);
        public Task<bool> DeleteAsync(int id);
        public Task<Product> GetAsync(int obj);
        public Task<IEnumerable<Product>> GetAllAsync();

    }
}
