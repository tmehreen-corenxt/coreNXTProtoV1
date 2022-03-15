using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreNXTProtoV1.Business.Repository.IRepository;
using coreNXTProtoV1.Models;
using coreNXTProtoV1.DataAccess.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace coreNXTProtoV1.Business.Repository
{
    public class CategorySearchAttributesRepository : ICategorySearchAttributesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public CategorySearchAttributesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<IEnumerable<CategorySearchAttributesDTO>> GetAllCategorySearchAttributes()
        {
            try
            {
                var categorySearchAttributes =
                    _mapper.Map<IEnumerable<CategorySearchAttributes>, IEnumerable<CategorySearchAttributesDTO>>
                    (_db.CategorySearchAttributes);
                return await Task.FromResult(categorySearchAttributes);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
