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
    public class ProductRepository: IProductRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public ProductRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
       
        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            try
            {
                var products =
                    _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>
                    (_db.Product);
                return await Task.FromResult(products);
            }
            catch
            {
                throw new NotImplementedException();
            }

        }


    }
}
