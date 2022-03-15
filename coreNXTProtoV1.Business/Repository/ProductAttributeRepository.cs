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
    public class ProductAttributeRepository: IProductAttributeRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public ProductAttributeRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<ProductAttributeDTO>> GetAllProductAttributes()
        {
            try
            {
                var productAttributes =
                    _mapper.Map<IEnumerable<ProductAttribute>, IEnumerable<ProductAttributeDTO>>
                    (_db.ProductAttribute);
                return await Task.FromResult(productAttributes);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
