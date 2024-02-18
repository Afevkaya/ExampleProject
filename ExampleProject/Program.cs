// builder uygulamaya servislerin eklenmesini sağlayan bir değişkendir
var builder = WebApplication.CreateBuilder(args);

// app uygulamada kullanılacak middleware/ara katman/ara yazılımların eklenmesini sağlayan değişkendir
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run(); 