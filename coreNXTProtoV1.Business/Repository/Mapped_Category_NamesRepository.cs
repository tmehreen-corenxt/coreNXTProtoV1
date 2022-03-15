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
    public class Mapped_Category_NamesRepository : IMapped_Category_NamesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public Mapped_Category_NamesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<Mapped_Category_NamesDTO>> GetAllMapped_Category_Names()
        {
            try
            {
                var mapped_Category_Names =
                    _mapper.Map<IEnumerable<Mapped_Category_Names>, IEnumerable<Mapped_Category_NamesDTO>>
                    (_db.Mapped_Category_Names);
                return await Task.FromResult(mapped_Category_Names);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
