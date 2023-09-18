using Microsoft.AspNetCore.Mvc.Formatters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opt =>  // or AddMvc()
{
  //## 禁止自動把 HTTP Response 為 null 時轉換成 204 NoContent。因為 System.Text.Json 無法對 204 NoContent 解序列化！
  // 此設定應該只適用於 Web API。
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
