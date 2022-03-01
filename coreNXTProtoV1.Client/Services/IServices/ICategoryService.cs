using coreNXTProtoV1.Models;

namespace coreNXTProtoV1.Client.Services.IServices
{
    public interface ICategoryService
    {
            public Task<IEnumerable<CategoryDTO>> GetAllCategories();

        
    }
}
