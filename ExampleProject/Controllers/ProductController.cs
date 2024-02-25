using System.Text.Json;
using ExampleProject.Models;
using ExampleProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Controllers;

#region NonController
// Bazı durumlarda Controller classını requetlere kapatıp sadece uygulamadaki işlerde kullanmak gerekebilir.
// Bu durumlarda [NonController] attribute ilgili controller'ı requestlere kapatır
// [NonController]
#endregion
public class ProductController : Controller
{

    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product {Id = 1, Name="A Product", Quantity = 100},
            new Product {Id = 2, Name="B Product", Quantity = 200},
            new Product {Id = 3, Name="C Product", Quantity = 300}
        };
        #region Model Bazlı Veri Gönderimi
        // return View(products);
        #endregion
        
        #region Veri Taşıma Kontrolleri
        #region ViewBag
        // View'a gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişken ile taşımamızı sağlayan veri taşıma kontrolüdür.

        ViewBag.products = products;
        #endregion

        #region ViewData
        // ViewBag'de olduğu gibi actşondakş datayı view'e taşımamızı sağlayan bir kontroldür
        // Tek fark ViewData action atarfında boxing yapar ve cshtml tarafında unboxing yapmamızı ister

        ViewData["products"] = products;
        #endregion

        #region TempData
        // ViewData'de olduğu gibi actşondakş datayı view'e taşımamızı sağlayan bir kontroldür
        // ViewData dan farklı olarak TempData tarayıcının cookie'si üzerinden taşınmaktadır
        // Yani TempData üzerinden taşınan veriler başka Actionlar üzerinden de erişilebilir yani Actionlar üzerinde veri aktarımı TempData üzerinde yapılabilmektedir.

        // string data = JsonSerializer.Serialize(products);
        // TempData["products"] = data;
        // return RedirectToAction("Index2");
        #endregion

        return View();
        #endregion

        
    }

    #region TempData
    // public IActionResult Index2()
    // {
    //     var data = TempData["products"].ToString();
    //     var products = JsonSerializer.Deserialize<List<Product>>(data);
    //     return View(products);
    // }

    #endregion

    #region GetProducts
    public IActionResult GetProducts()
    {
        var product = new Product 
        {
            Id = 1,
            Name = "A Product",
            Quantity = 15
        };

        var user = new User 
        {
            Id = 1,
            Name = "Ahmet",
            LastName = "Evkaya"
        };

        // Birden fazla veriyi View tarafına taşımanın en uygun iki yolu vardır
        // 1- ViewModel --> Taşınacak veriler için ortak bir sınıf oluşturmak
        // var userProduct = new UserProduct 
        // {
        //     User = user,
        //     Product = product
        // };
        
        // return View(userProduct);
        // 2- Tuple Nesne --> C# ın getirmiş olduğu birden fazla veriyi taşınmasını sağlayan teknik
        var userProduct = (product,user);
        return View(userProduct);
    }
    #endregion

    

    #region NonAction
    // Controller sınıfı içindeki her metod uygulama  tarafından bir action metod olarak algılanır
    // Bu da demektir ki istek(request) alabilir bir metottur
    // Controller içinde istenmese de bazı durumlarda business işlerin yürütüldüğü metotlar bulunabilir.
    // Bu metotlar business ile ilgili işlemler yürtüütğü için requestlere kapalı olması istenir.
    // İşte bu durumlarda [NonAction] attribute ilgili metodu requestlere kapatır
    // [NonAction]
    // public void X()
    // {

    // }
    #endregion

    #region ViewResult

    // Kullanıcıya bir View dönmek istendiğinde kullanılır 
    // public ViewResult GetProducts()
    // {
    //     ViewResult result = View();
    //     return result;
    // }
    #endregion

    #region PartialViewResult

    // Gelen istekler sonucunda response olarak client'a bir View dönmek istendiğinde kullanılır.
    // ViewResult tan farkı bir sayfadaki belirli bir alanı değiştirip kullanıcıya döner
    // Daha çok client tabanlı isteklerde (ajax istekler) kullanılır
    // public PartialViewResult GetProducts()
    // {
    //     PartialViewResult result = PartialView();
    //     return result;
    // }
    #endregion

    #region JsonResult

    // Gelen istekler sonucunda response olarak client'a Json formatında veri dnmek istendiğinde kullanılır
    // Daha çok client tabanlı isteklerde (ajax istekler) kullanılır
    // public JsonResult GetProducts()
    // {
    //     JsonResult result = Json(new Product{Id = 5, Name="Terlik",Quantity=15});
    //     return result;
    // }
    #endregion
    
    #region EmptyResult

    // Gelen istekler sonucunda response olarak client'a bir herhangi bir şey döndürmek istenmediğinde kullanılır
    // Bir response var ama result(bir veri) yok manasındadır
    // public EmptyResult GetProducts()
    // {
    //     EmptyResult result = new EmptyResult();
    //     return result;
    // }
    #endregion

    #region ContentResult

    // Gelen istekler sonucunda response olarak client'a metinsel bir değer döndürülmek istendiğinde kullanılır
    // Daha çok client tabanlı isteklerde (ajax istekler) kullanılır
    // public ContentResult GetProducts()
    // {
    //     ContentResult result = Content("Hi guys");
    //     return result;
    // }
    #endregion

    #region ActionResult

    // Bütün bu gerin dönüş tiplerinin(resultların) base classıdır
    // Gelen istekler sonucunda response olarak client'a dönülecek tip değişkenlik göstermesi durumunda kullanılan geri dönüş tipidir.
    // public ActionResult GetProducts()
    // {
    //     if (true)
    //     {
    //         // ...
    //         return Json(new object());
    //     }
    //     else if (false)
    //     {
    //         return Content("Eoo");
    //     }
    //     return View();
    // }
    #endregion

    #region IActionResult

    // AcitonResult geri dönüş tipinin nterface'i arayüzüdür
    // Gelen istekler sonucunda response olarak client'a dönülecek tip değişkenlik göstermesi durumunda kullanılan geri dönüş tipidir.
    // public IActionResult GetProducts()
    // {
    //     return View();
    // }
    #endregion

}
