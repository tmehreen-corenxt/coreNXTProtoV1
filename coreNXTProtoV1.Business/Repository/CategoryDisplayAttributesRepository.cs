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
    public class CategoryDisplayAttributesRepository : ICategoryDisplayAttributesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public CategoryDisplayAttributesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<IEnumerable<CategoryDisplayAttributesDTO>> GetAllCategoryDisplayAttributes()
        {
            try
            {
                var categoryDisplayAttributes  =
                    _mapper.Map<IEnumerable<CategoryDisplayAttributes>, IEnumerable<CategoryDisplayAttributesDTO>>
                    (_db.CategoryDisplayAttributes);
                return await Task.FromResult(categoryDisplayAttributes);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
