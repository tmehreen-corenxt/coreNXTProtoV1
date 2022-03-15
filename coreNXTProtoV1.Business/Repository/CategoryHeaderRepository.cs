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
    public class CategoryHeaderRepository : ICategoryHeaderRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public CategoryHeaderRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<IEnumerable<CategoryHeaderDTO>> GetAllCategoryHeaders()
        {
            try
            {
                var categoryHeaders =
                    _mapper.Map<IEnumerable<CategoryHeader>, IEnumerable<CategoryHeaderDTO>>
                    (_db.CategoryHeader);
                return await Task.FromResult(categoryHeaders);
            }
            catch
            {
                throw new NotImplementedException();
            }

        }
    }
}
