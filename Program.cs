var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Sýrayla ekle
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "þifre.html" }
});
app.UseStaticFiles();

app.Run();