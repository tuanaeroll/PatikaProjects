var builder = WebApplication.CreateBuilder(args);

// Bu projenin Controller lar kullanacağını, bu controllerların da geriye View lar döneceğini söyleyen kod bloğu
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Projeye hangi şekilde istek atılacağını MappControllerRoute metodu ile tanımlıyoruz.
app.MapControllerRoute(
    name : "default",
    pattern : "{controller=Home}/{action=Index}"
    );

app.Run();