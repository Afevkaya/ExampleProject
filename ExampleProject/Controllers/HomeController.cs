using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Controllers;

// Controller aslında bildiğimiz sınıflardır.
// Bir sınıfın request alabilir ve response döndürebilir olabilmesi yani Controller olabilmesi için Microsoft.AspNetCore.Mvc altında bulunan Controller sınıfından türetilmesi gerekmektedir
// Controller sınıfı içerisinde requestleri/istekleri karşılayan metotlara Action Metot denir

// MVC mimarisindeki View uygulamada Views klasörü altında bulunmaktadır.
// Views klasörü altında şema/şablon şu şekildedir.
// - Controller'a ait bir klasör
// - Action metoda ait dosya(.cshtml uzantılı) ilgili kalsörün altında ve action metod adındadır.
// cs + html = cshtm ==> Razor(Html içerisinde C# koldarını çalıştırmayı sağlayan bir teknolojidir.)

// MVC mimarisinde Model katmanı db işlerinin yürütüldüğü katmandır
// Uygulamada ise diğer iki katmanda olduğu gibi bir klasörden ibarettir.
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index","Product");
    }
}