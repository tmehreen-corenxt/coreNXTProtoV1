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
    public class Mapped_CategoryRepository : IMapped_CategoryRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public Mapped_CategoryRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<Mapped_CategoryDTO>> GetAllMapped_Categories()
        {
            try
            {
                var mapped_Categories =
                    _mapper.Map<IEnumerable<Mapped_Category>, IEnumerable<Mapped_CategoryDTO>>
                    (_db.Mapped_Category);
                return await Task.FromResult(mapped_Categories);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
