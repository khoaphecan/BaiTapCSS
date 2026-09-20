var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // Bắt buộc phải có để đọc được HTML, CSS

app.MapGet("/", () => "Hello World!");
app.Run();