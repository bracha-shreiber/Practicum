using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text;
using Resume.Core.IRepository;
using Resume.Core.IServices;
using Resume.Service.Services;
using Data.Repositories;
using Resume.Data;
using Microsoft.AspNetCore.Hosting;
using Resume.Core;
using Resume.Data.Repositories;

//using File = EduShare.Core.Entities.File;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy => { policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthRepository,AuthRepository>();
//builder.Services.AddSingleton<ResumeContext>();
builder.Services.AddDbContext<ResumeContext>();
builder.Services.AddAutoMapper(typeof(MappingProFile));

var app = builder.Build();
// הפעלת Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty;
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


// Swagger




//var builder = WebApplication.CreateBuilder(args);
// Repository
//builder.Services.AddScoped<IRepositoryGeneric<File>, FileRepository>();
//builder.Services.AddScoped<IRepositoryGeneric<Rating>, RatingRepository>();
//builder.Services.AddScoped<IRepositoryGeneric<Recommendation>, RecommendationRepository>();
//builder.Services.AddScoped<IRepositoryGeneric<Topic>, TopicRepository>();
//builder.Services.AddScoped<IRepositoryGeneric<User>, UserRepository>();
//builder.Services.AddScoped<IFileRopository, FileRepository>();
//builder.Services.AddScoped<IRatingRepository, RatingRepository>();
//builder.Services.AddScoped<IRecommendationRepository, RecommendationRepository>();
//builder.Services.AddScoped<ITopicRepository, TopicRepository>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();

// Services
//builder.Services.AddScoped<IFileService, FileService>();
//builder.Services.AddScoped<IRatingService, RatingService>();
//builder.Services.AddScoped<IRecommendationService, RecommendationService>();
//builder.Services.AddScoped<ITopicService, TopicService>();
//builder.Services.AddScoped<IUserService, UserService>();

// Repository Manager
//builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
//builder.Services.AddScoped(typeof(IRepositoryGeneric<>));

// DbContext
//builder.Services.AddDbContext<DataContext>(options =>
//    options.UseMySql(@"server=localhost:3306;database=EduShare;user=rachel;password=rachel56204",
//        new MySqlServerVersion(new Version(8, 0, 41))));
//builder.Services.AddDbContext<DataContext>(
//    options => options.UseMySql(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db",
//    new MySqlServerVersion(new Version(8, 0, 41))));
//builder.Services.AddDbContext<DataContext>(
//    options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db"));

//builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(PostModelMappingProfile));

//// Add services to the container.
//builder.Services.AddControllers().AddJsonOptions(options =>//כדי להמנע ממעגל
//{
//    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    options.JsonSerializerOptions.WriteIndented = true;
//});








