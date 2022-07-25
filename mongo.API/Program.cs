using mongo.Application.IoC;
using mongo.Infra.IOC;
using mongo.Infra.IOC.ORMs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ApplicationServicesIoC();
builder.Services.AdicionarORMIoC<MongoDbIoC>();
builder.Services.AddControllers();
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
