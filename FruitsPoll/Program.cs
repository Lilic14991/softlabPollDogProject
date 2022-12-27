// -------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
using Microsoft.Extensions.Configuration;
using PollDog.API.Exceptions;
using PollDog.API.Helpers;
using WebAPI.Core.Repositories;
using WebAPI.Core.Services;
using WebAPI.Infrastructure.Repositories;
using WebAPI.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISurveyResultRepository, SurveyResultRepository>();
builder.Services.AddScoped<ISurveyResultService, SurveyResultService>();
builder.Services.AddScoped<IConfigService, ConfigService>();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

var allowWebClient = "allowWebClient";
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: allowWebClient,
        policy =>
    {
        policy.WithOrigins("http://localhost:3000/")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

// builder.Host.UseSerilog();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
});

var app = builder.Build();

    // Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseCors(allowWebClient);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();