using System.Net.Http;
using System.Data;
using System.Linq;
//using Newtonsoft.Json;
using coreNXTProtoV1.Client.Services.IServices;
using coreNXTProtoV1.Models;
using System.Net.Http.Json;

namespace coreNXTProtoV1.Client.Services
{

    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            try
            {
                var cat = _httpClient.GetFromJsonAsync<IEnumerable<CategoryDTO>>("api/category");
                return (IEnumerable<CategoryDTO>)await Task.FromResult(cat);
            
    }
            catch
            {
                throw new Exception();
            }
        }




    }
}
