var builder = WebApplication.CreateBuilder(args);

// Bu projenin Controller lar kullanacağını, bu controllerların da geriye View lar döneceğini söyleyen kod bloğu
builder.Services.AddControllersWithViews();

var app = builder.Build();

// wwwroot klasöründeki  statik dosyaların tarayıcıdan erişilebilir olmasını sağlayan metot
app.UseStaticFiles();

// Routing, tarayıcının yaptığı istekleri doğru Contoller-Action metodlarına yönlendirir, bu satır da bu erişimi sağlar
app.UseRouting();

// Projeye hangi şekilde istek atılacağını MappControllerRoute metodu ile tanımlıyoruz.
app.MapControllerRoute(
    name : "default",
    pattern : "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();

// Controller -> Kullanıcıdan gelen isteklere karşılık veren sınıflar. İş mantığının yazıldığı yerdir.
// Action -> Controller içinde tanımlanan metodlardır.
// View -> Kullanıcıya sunulan HTML tabanlı arayüzlerdir.
// Razor -> C# kodu ile HTML’i iç içe yazmaya izin veren bir şablon dilidir.
// RazorView -> .cshtml uzantılı HTML + Razor kodlarını içeren dosyalardır.
// wwwroot -> statik dosyaların tutulduğu klasördür.
// builder.Build() -> Uygulamayı oluşturur ve gerekli bağımlılıkları yükler.
// app.Run() -> Uygulamayı başlatır ve HTTP isteklerini dinlemeye başlar.