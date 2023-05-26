var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app
    .UseStaticFiles()
    .Use(next => context => context.Response.SendFileAsync("wwwroot/index.html"));

await app.RunAsync();
