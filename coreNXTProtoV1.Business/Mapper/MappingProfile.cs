using AutoMapper;
using coreNXTProtoV1.DataAccess.Data;
using coreNXTProtoV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace coreNXTProtoV1.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            

        }
    }
}
