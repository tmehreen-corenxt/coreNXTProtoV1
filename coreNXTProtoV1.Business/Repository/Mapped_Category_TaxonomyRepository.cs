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
    public class Mapped_Category_TaxonomyRepository : IMapped_Category_TaxonomyRepository
    {
        private readonly AppDBContext _db;
        private readonly IMapper _mapper;
        public Mapped_Category_TaxonomyRepository(AppDBContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<IEnumerable<Mapped_Category_TaxonomyDTO>> GetAllMapped_Category_Taxonomies()
        {
            try
            {
                var mapped_Category_Taxonomies =
                    _mapper.Map<IEnumerable<Mapped_Category_Taxonomy>, IEnumerable<Mapped_Category_TaxonomyDTO>>
                    (_db.Mapped_Category_Taxonomy);
                return await Task.FromResult(mapped_Category_Taxonomies);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}
