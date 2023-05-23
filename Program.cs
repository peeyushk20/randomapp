var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Random random = new Random();
app.MapGet("/", () => $"Here is a random number : {random.Next()}");

app.Run();
