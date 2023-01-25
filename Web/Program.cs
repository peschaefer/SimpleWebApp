using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Factorial of 9 = " + FactorialService.Factorial(9));

app.Run();