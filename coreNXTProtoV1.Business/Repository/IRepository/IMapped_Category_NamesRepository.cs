using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreNXTProtoV1.Models;
namespace coreNXTProtoV1.Business.Repository.IRepository
{
    public interface IMapped_Category_NamesRepository
    {
        public Task<IEnumerable<Mapped_Category_NamesDTO>> GetAllMapped_Category_Names();

    }
}
