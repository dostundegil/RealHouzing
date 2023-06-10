using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrate;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrate;
using RealHouzing.DataAccessLayer.EntityFramework;
using RealHouzing.EntityLayer.Concrate;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<ICategoryDal,EfCategoryDal>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IAboutUsDal, EfAboutUsDal>();
builder.Services.AddScoped<IAboutUsService, AboutUsManager>();

builder.Services.AddScoped<IAgentDal, EfAgentDal>();
builder.Services.AddScoped<IAgentService, AgentManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IFeatuesDal, EfFeatuesDal>();
builder.Services.AddScoped<IFeatuesService, FeatuesManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();
builder.Services.AddScoped<IContactUsService, ContactUsManager>();

builder.Services.AddScoped<IMessageDal, EfMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();

builder.Services.AddScoped<IPropertyFeaturesDal, EfPropertyFeaturesDal>();
builder.Services.AddScoped<IPropertyFeaturesService, PropertyFeaturesManager>();

builder.Services.AddScoped<IProductPropertyFeaturesDal, EfProductPropertyFeaturesDal>();
builder.Services.AddScoped<IProductPropertyFeaturesService, ProductPropertyFeaturesManager>();



builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
