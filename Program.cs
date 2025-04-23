var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// S�rayla ekle
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "�ifre.html" }
});
app.UseStaticFiles();

app.Run();