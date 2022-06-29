using EndpointDefinitions;
using ExampleEndpointDefinitions.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add All endpoint definitions and services to the App
builder.Services.AddAllEndpointDefinitions();

//its also possible to filter for specific endpointDefinitions
//builder.Services.AddEndpointDefinitions(typeof(WeatherEndpoint));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Start Endpoint definitions
app.UseEndpointDefinitions();

app.Run();

