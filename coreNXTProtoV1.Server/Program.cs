using coreNXTProtoV1.Server.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using coreNXTProtoV1.Business.Repository;
using coreNXTProtoV1.Business.Repository.IRepository;
using coreNXTProtoV1.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAttributeNamesRepository,AttributeNamesRepository>();
builder.Services.AddScoped<ICategoryDisplayAttributesRepository,CategoryDisplayAttributesRepository>();
builder.Services.AddScoped<ICategoryHeaderRepository,CategoryHeaderRepository>();
builder.Services.AddScoped<ICategoryNamesRepository,CategoryNamesRepository>();
builder.Services.AddScoped<ICategorySearchAttributesRepository,CategorySearchAttributesRepository>();
builder.Services.AddScoped<IHeaderNamesRepository,HeaderNamesRepository>();
builder.Services.AddScoped<ILocalesRepository,LocalesRepository>();
builder.Services.AddScoped<IManufacturerRepository,ManufacturerRepository>();
builder.Services.AddScoped<IMapped_CategoryRepository,Mapped_CategoryRepository>();
builder.Services.AddScoped<IMapped_Category_NamesRepository,Mapped_Category_NamesRepository>();
builder.Services.AddScoped<IMapped_Category_TaxonomyRepository,Mapped_Category_TaxonomyRepository>();
builder.Services.AddScoped<IProductAccessoriesRepository,ProductAccessoriesRepository>();
builder.Services.AddScoped<IProductAttributeRepository,ProductAttributeRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
