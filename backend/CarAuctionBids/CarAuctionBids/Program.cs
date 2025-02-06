using CarAuctionBids.Extensions;
using CarAuctionBids.Hubs;
using CarAuctionBids_Business.Abstraction;
using CarAuctionBids_Business.Concrete;
using CarAuctionBids_Core.Models;
using CarAuctionBids_DataAccess.Context;
using CarAuctionBids_DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddCors();
builder.Services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
builder.Services.AddSwaggerCollection(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSignalR();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin => true).AllowCredentials());
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapHub<BidUpdateHub>("/BidUpdate/Hub");
app.UseStaticFiles();

app.MapControllers();

app.Run();
