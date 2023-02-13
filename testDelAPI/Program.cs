using Microsoft.EntityFrameworkCore;

using testDelAPI;
using testDelAPI.Data;

// tutorial https://www.youtube.com/watch?v=_8nLSsK5NDo&list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0

var builder = WebApplication.CreateBuilder(args);

// get the conn str in appsettings.json
var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
// var connStr = builder.Configuration.GetConnectionString("MoreSecureConn");


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<DBSeeding>(); // dep injection ??? add scope ???
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connStr);
}
);

var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seedData")
{
    seedData(app);
}

// ??? wtf
void seedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    Console.WriteLine("asd");

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DBSeeding>();
        service.SeedDataContext();
    }
}


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
