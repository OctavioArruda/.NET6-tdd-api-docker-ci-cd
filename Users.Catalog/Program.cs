var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// debug purposes = swagger on pdn
app.UseSwagger();
app.UseSwaggerUI();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
//     // app.UseSwaggerUI(options => {
//     //     options.SwaggerEndpoint("/swagger/v1/users.json", "v1");
//     // });
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
