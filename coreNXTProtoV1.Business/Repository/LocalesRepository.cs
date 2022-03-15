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
    public class LocalesRepository : ILocalesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public LocalesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<LocalesDTO>> GetAllLocales()
        {
            try
            {
                var locales =
                    _mapper.Map<IEnumerable<Locales>, IEnumerable<LocalesDTO>>
                    (_db.Locales);
                return await Task.FromResult(locales);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
