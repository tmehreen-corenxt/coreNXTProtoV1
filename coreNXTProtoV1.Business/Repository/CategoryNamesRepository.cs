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
    public class CategoryNamesRepository : ICategoryNamesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public CategoryNamesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<IEnumerable<CategoryNamesDTO>> GetAllCategoryNames()
        {
            try
            {
                var categoryNames =
                    _mapper.Map<IEnumerable<CategoryNames>, IEnumerable<CategoryNamesDTO>>
                    (_db.CategoryNames);
                return await Task.FromResult(categoryNames);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
