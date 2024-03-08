using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Implementation;
using PrepaidMerchantAPI.Repository.Interface;
using PrepaidMerchantAPI.Services.Implementation;
using PrepaidMerchantAPI.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddScoped<ITransactionRepo, TransactionRepo>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddScoped<IRequestManagemetRepo, RequestManagementRepo>();
builder.Services.AddScoped<IRequestManagementService, RequestManagementService>();

builder.Services.AddScoped<ICardRepo, CardRepo>();
builder.Services.AddScoped<ICardService, CardService>();

builder.Services.AddScoped<IBalanceManagementRepo, BalanceManagementRepo>();
builder.Services.AddScoped<IBalanceManagementService, BalanceManagementService>();

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
