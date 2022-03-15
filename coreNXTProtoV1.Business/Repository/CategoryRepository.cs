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
    public class CategoryRepository:ICategoryRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public CategoryRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<CategoryDTO>> GetAllCategories()
        {
            try
            {
                var categories =
                    _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>
                    (_db.Category);
                //var tax = await _db.Mapped_Category_Taxonomy.ToListAsync();
                return await Task.FromResult(categories);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        //public async Task<T> GetAllFromTable<T>(T tablename)
        //{
        //    var Tsource = tablename;
        //    var Tdestination = tablename + "DTO";
        //    var dbobj = "_db." + Tsource;
        //    var result =
        //        _mapper.Map<Tsource>, < Tdestination >
        //        (dbobj);


        //    return await Task.FromResult(result);
        //}
    }
}
