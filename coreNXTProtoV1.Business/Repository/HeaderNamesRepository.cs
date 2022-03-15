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
    public class HeaderNamesRepository : IHeaderNamesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public HeaderNamesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<IEnumerable<HeaderNamesDTO>> GetAllHeaderNames()
        {
            try
            {
                var headerNames =
                    _mapper.Map<IEnumerable<HeaderNames>, IEnumerable<HeaderNamesDTO>>
                    (_db.HeaderNames);
                return await Task.FromResult(headerNames);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
