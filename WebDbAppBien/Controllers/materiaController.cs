using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDbApp.Models;
using WebDbApp.Miscellaneous;
using Microsoft.EntityFrameworkCore;

namespace WebDbApp.Controllers
{
    public class materiaController : Controller
    {
        private DataAccess _dataaccess;

        public materiaController(DataAccess dataaccess)
        {
            _dataaccess = dataaccess;
            
        }

        // GET: materiaController  aqui saco los datos de la tabla materia, con el _dataaccess es la conexón a la tabla.
        public ActionResult Index()
        {
            
            IEnumerable<Materia>? mat = _dataaccess.Materia;
           
                return View (mat);
            
         }

        // GET: materiaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: materiaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: materiaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: materiaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: materiaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: materiaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: materiaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}
