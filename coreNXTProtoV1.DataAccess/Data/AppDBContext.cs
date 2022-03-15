using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using coreNXTProtoV1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {

        }
        public DbSet<Category> Category { get; set; } = null!;
        public DbSet<Locales> Locales { get; set; } = null!;
        public DbSet<AttributeNames> AttributeNames { get; set; } = null!;
        public DbSet<CategoryDisplayAttributes> CategoryDisplayAttributes { get; set; } = null!;
        public DbSet<HeaderNames> HeaderNames { get; set; } = null!;  
        public DbSet<CategoryHeader> CategoryHeader { get;set; } = null!;
        public DbSet<CategoryNames> CategoryNames { get; set; } = null!;
        public DbSet<CategorySearchAttributes> CategorySearchAttributes { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturer { get; set; } = null!;
        public DbSet<Mapped_Category> Mapped_Category { get; set; } = null!;
        public DbSet<Mapped_Category_Names> Mapped_Category_Names { get; set; } = null!;
        public DbSet<Mapped_Category_Taxonomy> Mapped_Category_Taxonomy { get; set; } = null!;
        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<ProductAccessories> ProductAccessories { get; set; } = null!;
       public DbSet<ProductAttribute> ProductAttribute { get; set; } = null!;




    }
}
