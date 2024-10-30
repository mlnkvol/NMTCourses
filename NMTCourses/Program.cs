using Microsoft.EntityFrameworkCore; // Потрібен для використання UseSqlServer
using Azure.Storage.Blobs; // Необхідно для роботи з Blob Storage

var builder = WebApplication.CreateBuilder(args);

// Налаштування підключення до бази даних
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Додайте BlobServiceClient
builder.Services.AddSingleton<BlobServiceClient>(new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=teacherphotos;AccountKey=F+RyhL3NAzXdTSSMZhG2E5IOezv7S+5LlmBBEMl29w7Spd4PFOflrtCKe1Nsk5sDAksvAGeN1/b0+AStJbzbpg==;EndpointSuffix=core.windows.net"));

// Додати MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Далі - стандартна конфігурація середовища
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "teachers",
    pattern: "Teachers/{action=Index}/{id?}",
    defaults: new { controller = "Teachers" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Courses}/{action=Index}/{id?}");

app.Run();
