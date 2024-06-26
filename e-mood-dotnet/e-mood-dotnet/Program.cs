using e_mood_dotnet.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IMusicContext, MusicContext>(options =>
{
    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "storage"));
    var datasource = Path.Combine(Directory.GetCurrentDirectory(), "storage", "mood.db");
    options.UseSqlite($"Data Source={datasource}");
});

builder.Services
    .AddControllers().AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        options.SerializerSettings.Converters.Add(new StringEnumConverter());
    });
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Music API",
        Version = "v1",
    });
});
builder.Services.AddSwaggerGenNewtonsoftSupport();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();

app.UseSwagger(c => { c.RouteTemplate = "api/swagger/{documentName}/swagger.json"; });
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/api/swagger/v1/swagger.json", "Music API V1");
    c.RoutePrefix = "api/swagger";
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "storage", "tracks")),
    RequestPath = "/api/Files/Content"
});

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<IMusicContext>() as MusicContext;
    if (context != null)
    {
        if (context.Database.GetPendingMigrations().Any())
            context.Database.Migrate();
    }
}

app.Run();