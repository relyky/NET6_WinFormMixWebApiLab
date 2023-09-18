using Microsoft.AspNetCore.Mvc.Formatters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opt =>  // or AddMvc()
{
  //## �T��۰ʧ� HTTP Response �� null ���ഫ�� 204 NoContent�C�]�� System.Text.Json �L�k�� 204 NoContent �ѧǦC�ơI
  // ���]�w���ӥu�A�Ω� Web API�C
  // remove formatter that turns nulls into 204 - No Content responses
  opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
});

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
