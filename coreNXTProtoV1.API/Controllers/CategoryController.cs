using Microsoft.AspNetCore.Mvc;
using coreNXTProtoV1.Business.Repository.IRepository;
namespace coreNXTProtoV1.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _catRepository;
        public CategoryController(ICategoryRepository catRepository)
        {
            _catRepository = catRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _catRepository.GetAllCategories();
            if (categories == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(categories);
            }
        }

    }
}
