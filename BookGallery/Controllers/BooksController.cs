using BookGallery.Models;
using BookGallery.Services;

using Microsoft.AspNetCore.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {
        private IData _tempdata;
        //dependency injection

        public BooksController(IData tempdata)
        {

            _tempdata = tempdata;


        }

        public IActionResult Details(int? id)
        {
            var buk = _tempdata.GetBook(id);

            if (buk == null)
            {

                return NotFound();

            }

            return View(buk);

        }

        //sending the list of employees to the view 
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel(); //temp class 
            model.Books = _tempdata.ReadAll();
            return View(model);
        }
    }
}
