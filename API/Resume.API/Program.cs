////using Amazon.Extensions.NETCore.Setup;
////using Amazon.S3;
////using Data.Repositories;
////using Microsoft.Extensions.Options;
////using OpenAI;
////using Resume.Core.IRepository;
////using Resume.Core.IServices;
////using Resume.Core;
////using Resume.Data.Repositories;
////using Resume.Data;
////using Resume.Service.Services;

////the code:
////using System.Text.Json.Serialization;
////using Microsoft.AspNetCore.Cors.Infrastructure;
////using System.Text.Json.Serialization;
////using Microsoft.EntityFrameworkCore;
////using Microsoft.OpenApi.Models;
////using System.Text;
////using Resume.Core.IRepository;
////using Resume.Core.IServices;
////using Resume.Service.Services;
////using Data.Repositories;
////using Resume.Data;
////using Microsoft.AspNetCore.Hosting;
////using Resume.Core;
////using Resume.Data.Repositories;
////using Amazon.S3;
////using Microsoft.AspNetCore.Builder;
////using Microsoft.Extensions.Options;
////using Amazon.Extensions.NETCore.Setup;
////using OpenAI;

//////using File = EduShare.Core.Entities.File;
////DotNetEnv.Env.Load();

////var builder = WebApplication.CreateBuilder(args);
////// Add services to the container.

////builder.Services.AddControllers();
////builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen();
////builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy => { policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
//////builder.Services.AddSwaggerGen(c =>
//////{
//////    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
//////});
////// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
////builder.Services.AddOpenApi();
////builder.Services.AddScoped<IUserService, UserService>();
////builder.Services.AddScoped<IUserRepository, UserRepository>();
////builder.Services.AddScoped<IAuthService, AuthService>();
////builder.Services.AddScoped<IAuthRepository, AuthRepository>();
////builder.Services.AddScoped<IResumeFileService, ResumeFileService>();
////builder.Services.AddScoped<IResumefileRepository, ResumeFileRepository>();
////builder.Services.AddScoped<IAIService, AIService>();
////builder.Services.AddScoped<IAIRepository, AIRepository>();
//////builder.Services.AddSingleton<ResumeContext>();
////builder.Services.AddDbContext<ResumeContext>();
////builder.Services.AddAutoMapper(typeof(MappingProFile));
////builder.Services.AddSingleton<IAmazonS3>(serviceProvider =>
////{
////    var options = serviceProvider.GetRequiredService<IOptions<AWSOptions>>().Value;

////    // äâãøú Credentials áàåôï éãðé
////    var credentials = new Amazon.Runtime.BasicAWSCredentials(
////        builder.Configuration["AWS:AccessKey"],
////        builder.Configuration["AWS:SecretKey"]
////    );

////    // äâãøú Region
////    var region = Amazon.RegionEndpoint.GetBySystemName(builder.Configuration["AWS:Region"]);

////    return new AmazonS3Client(credentials, region);
////});
////builder.Services.AddScoped<OpenAIClient>(provider =>
////{
////    var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
////    if (string.IsNullOrEmpty(apiKey))
////    {
////        throw new Exception("API key is not set.");
////    }
////    return new OpenAIClient(apiKey);
////});

//////builder.Services.AddScoped<OpenAIClient>(provider =>
//////            new OpenAIClient(Environment.GetEnvironmentVariable("OPENAI_API_KEY")));
////var app = builder.Build();
////// הפעלת Swagger
////app.UseSwagger();
////app.UseSwaggerUI(c =>
////{
////    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
////    c.RoutePrefix = string.Empty;
////});
////// Configure the HTTP request pipeline.
////if (app.Environment.IsDevelopment())
////{
////    app.MapOpenApi();
////}
////app.UseCors("MyPolicy");
////app.UseAuthorization();

////app.MapControllers();

////app.Run();


////// Swagger




//////var builder = WebApplication.CreateBuilder(args);
////// Repository
//////builder.Services.AddScoped<IRepositoryGeneric<File>, FileRepository>();
//////builder.Services.AddScoped<IRepositoryGeneric<Rating>, RatingRepository>();
//////builder.Services.AddScoped<IRepositoryGeneric<Recommendation>, RecommendationRepository>();
//////builder.Services.AddScoped<IRepositoryGeneric<Topic>, TopicRepository>();
//////builder.Services.AddScoped<IRepositoryGeneric<User>, UserRepository>();
//////builder.Services.AddScoped<IFileRopository, FileRepository>();
//////builder.Services.AddScoped<IRatingRepository, RatingRepository>();
//////builder.Services.AddScoped<IRecommendationRepository, RecommendationRepository>();
//////builder.Services.AddScoped<ITopicRepository, TopicRepository>();
//////builder.Services.AddScoped<IUserRepository, UserRepository>();

////// Services
//////builder.Services.AddScoped<IFileService, FileService>();
//////builder.Services.AddScoped<IRatingService, RatingService>();
//////builder.Services.AddScoped<IRecommendationService, RecommendationService>();
//////builder.Services.AddScoped<ITopicService, TopicService>();
//////builder.Services.AddScoped<IUserService, UserService>();

////// Repository Manager
//////builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
//////builder.Services.AddScoped(typeof(IRepositoryGeneric<>));

////// DbContext
//////builder.Services.AddDbContext<DataContext>(options =>
//////    options.UseMySql(@"server=localhost:3306;database=EduShare;user=rachel;password=rachel56204",
//////        new MySqlServerVersion(new Version(8, 0, 41))));
//////builder.Services.AddDbContext<DataContext>(
//////    options => options.UseMySql(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db",
//////    new MySqlServerVersion(new Version(8, 0, 41))));
//////builder.Services.AddDbContext<DataContext>(
//////    options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db"));

//////builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(PostModelMappingProfile));

//////// Add services to the container.
//////builder.Services.AddControllers().AddJsonOptions(options =>//כדי להמנע ממעגל
//////{
//////    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//////    options.JsonSerializerOptions.WriteIndented = true;
//////});
//using System.Text.Json.Serialization;
//using Microsoft.AspNetCore.Cors.Infrastructure;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.OpenApi.Models;
//using Amazon.S3;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Options;
//using Amazon.Extensions.NETCore.Setup;
//using OpenAI;
//using Resume.Core.IRepository;
//using Resume.Core.IServices;
//using Resume.Service.Services;
//using Data.Repositories;
//using Resume.Data;
//using Resume.Core;
//using Resume.Data.Repositories;

//DotNetEnv.Env.Load();

//var builder = WebApplication.CreateBuilder(args);
//builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

//// Add services to the container.
//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
//{
//    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//}));

//builder.Services.AddOpenApi();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IAuthService, AuthService>();
//builder.Services.AddScoped<IAuthRepository, AuthRepository>();
//builder.Services.AddScoped<IResumeFileService, ResumeFileService>();
//builder.Services.AddScoped<IResumefileRepository, ResumeFileRepository>();
//builder.Services.AddScoped<IAIService, AIService>();
//builder.Services.AddScoped<IAIRepository, AIRepository>();

//builder.Services.AddDbContext<ResumeContext>();
//builder.Services.AddAutoMapper(typeof(MappingProFile));

//builder.Services.AddSingleton<IAmazonS3>(serviceProvider =>
//{
//    var options = serviceProvider.GetRequiredService<IOptions<AWSOptions>>().Value;
//    var credentials = new Amazon.Runtime.BasicAWSCredentials(
//        builder.Configuration["AWS:AccessKey"],
//        builder.Configuration["AWS:SecretKey"]
//    );
//    var regionValue = builder.Configuration["AWS:Region"];
//    if (string.IsNullOrEmpty(regionValue))
//    {
//        throw new InvalidOperationException("AWS:Region is not configured.");
//    }

//    var region = Amazon.RegionEndpoint.GetBySystemName(regionValue);

//    //var region = Amazon.RegionEndpoint.GetBySystemName(builder.Configuration["AWS:Region"]);
//    return new AmazonS3Client(credentials, region);
//});

//builder.Services.AddScoped<OpenAIClient>(provider =>
//{
//    var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
//    if (string.IsNullOrEmpty(apiKey))
//    {
//        throw new Exception("API key is not set.");
//    }
//    return new OpenAIClient(apiKey);
//});

//var app = builder.Build();

//// הפעלת Swagger
//app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//    c.RoutePrefix = string.Empty;
//});

//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

//app.UseCors("MyPolicy");
//app.UseAuthorization();
//app.MapControllers();
//app.Run();


using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Amazon.S3;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Amazon.Extensions.NETCore.Setup;
using OpenAI;
using Resume.Core.IRepository;
using Resume.Core.IServices;
using Resume.Service.Services;
using Data.Repositories;
using Resume.Data;
using Resume.Core;
using Resume.Data.Repositories;
using Swashbuckle.AspNetCore.SwaggerGen;
//using ResumeAnalyzer;
using var client = new HttpClient();

// Your API key
var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

var response = await client.GetAsync("https://api.openai.com/v1/models");

if (response.IsSuccessStatusCode)
{
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine("Available Models:");
    Console.WriteLine(content); // This will print the models your API key has access to
}
else
{
    Console.WriteLine($"Error fetching models: {response.StatusCode}");
}
    

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// ✅ Load appsettings.json (required)
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
Console.WriteLine("AWS Region: " + builder.Configuration["AWS:Region"]);
// ✅ Register AWSOptions from configuration
builder.Services.Configure<AWSOptions>(builder.Configuration.GetSection("AWS"));

// ✅ Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    c.OperationFilter<SwaggerFileOperationFilter>(); // ✅ Add this line
});

//builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MyPolicy", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddOpenApi();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IResumeFileService, ResumeFileService>();
builder.Services.AddScoped<IResumefileRepository, ResumeFileRepository>();
builder.Services.AddScoped<IAIService,AIService>();
builder.Services.AddScoped<IAIRepository, AIRepository>();

builder.Services.AddDbContext<ResumeContext>();
builder.Services.AddAutoMapper(typeof(MappingProFile));

// ✅ Add Amazon S3 with region fix
builder.Services.AddSingleton<IAmazonS3>(serviceProvider =>
{
    var config = builder.Configuration;
    var options = serviceProvider.GetRequiredService<IOptions<AWSOptions>>().Value;

    var accessKey = config["AWS:AccessKey"];
    var secretKey = config["AWS:SecretKey"];
    var regionValue = config["AWS:Region"];

    if (string.IsNullOrEmpty(accessKey) || string.IsNullOrEmpty(secretKey) || string.IsNullOrEmpty(regionValue))
    {
        throw new InvalidOperationException("AWS credentials or region are not configured properly in appsettings.json.");
    }

    var credentials = new Amazon.Runtime.BasicAWSCredentials(accessKey, secretKey);
    var region = Amazon.RegionEndpoint.GetBySystemName(regionValue);

    return new AmazonS3Client(credentials, region);
});

// ✅ OpenAI client from env variable
builder.Services.AddScoped<OpenAIClient>(provider =>
{
    var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
    if (string.IsNullOrEmpty(apiKey))
    {
        throw new Exception("OPENAI_API_KEY environment variable is not set.");
    }
    return new OpenAIClient(apiKey);
});

var app = builder.Build();

// ✅ Use Swagger
try
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
}
catch (Exception ex)
{
    Console.WriteLine($"Swagger Error: {ex.Message}");
}

//app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//    c.RoutePrefix = string.Empty;
//});

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// ✅ Middleware
app.UseCors("MyPolicy");
app.UseAuthorization();
app.MapControllers();



// ✅ Catch startup errors for better debug info
try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Startup Error: {ex.Message}");
    throw;
}




