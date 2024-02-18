// builder uygulamaya servislerin eklenmesini sağlayan bir değişkendir
var builder = WebApplication.CreateBuilder(args);

// MVC mimarisi .Net'e bir servis olarak dahil edilmiştir/tasarlanmıştır.
// Uygulamanın MVC mimarisinde çalışabilmesi yani o davranışı sergileyebilmesi için AddControllersWithViews ya da AddControllers servislerinden birini eklemmeiz gereklidir
// Aksi takdirde uygulama bir mvc mantığında çalışmayacaktır
builder.Services.AddControllersWithViews();

// app uygulamada kullanılacak middleware/ara katman/ara yazılımların eklenmesini sağlayan değişkendir
var app = builder.Build();

// Gelen isteklerin rotası bu middleware sayesinde belirlenir
app.UseRouting();

// Uygulamaya gelen isteklerin hangi rotalar/şablonlar eşliğinde gelebileceğini buradan bildireceğiz
// app.MapGet("/", () => "Hello World!");

// Uygulamaya gelen isteklerin belirli bir formatta/şablonda olmasını sağlayan middleware'dir
app.UseEndpoints(endpoints=> endpoints.MapDefaultControllerRoute());

app.Run(); 