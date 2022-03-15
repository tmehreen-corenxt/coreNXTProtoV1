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
    public class ProductAccessoriesRepository : IProductAccessoriesRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public ProductAccessoriesRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<ProductAccessoriesDTO>> GetAllProductAccessories()
        {
            try
            {
                var productAccessories =
                    _mapper.Map<IEnumerable<ProductAccessories>, IEnumerable<ProductAccessoriesDTO>>
                    (_db.ProductAccessories);
                return await Task.FromResult(productAccessories);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
