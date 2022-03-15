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
            CreateMap<AttributeNames,AttributeNamesDTO>().ReverseMap();
            CreateMap<CategoryDisplayAttributes,CategoryDisplayAttributesDTO>().ReverseMap();
            CreateMap<CategoryHeader,CategoryHeaderDTO>().ReverseMap();
            CreateMap<CategoryNames,CategoryNamesDTO>().ReverseMap();   
            CreateMap<CategorySearchAttributes,CategorySearchAttributesDTO>().ReverseMap();
            CreateMap<HeaderNames,HeaderNamesDTO>().ReverseMap();
            CreateMap<Locales,LocalesDTO>().ReverseMap();
            CreateMap<Manufacturer,ManufacturerDTO>().ReverseMap();
            CreateMap<Mapped_Category_Names,Mapped_Category_NamesDTO>().ReverseMap();
            CreateMap<Mapped_Category_Taxonomy,Mapped_Category_TaxonomyDTO>().ReverseMap();
            CreateMap<Mapped_Category, Mapped_CategoryDTO>().ReverseMap();
            CreateMap<ProductAccessories, ProductAccessoriesDTO>().ReverseMap();
            CreateMap<ProductAttribute, ProductAttributeDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();


            

        }
    }
}
