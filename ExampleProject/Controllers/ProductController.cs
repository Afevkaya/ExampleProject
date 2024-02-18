using ExampleProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProject.Controllers;

public class ProductController : Controller
{
    // public IActionResult GetProducts()
    // {
    //     return View();
    // }

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
    public IActionResult GetProducts()
    {
        return View();
    }
    #endregion

}
